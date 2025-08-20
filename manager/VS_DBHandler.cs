using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace PBDT_2D.Manager
{
    public class VS_DBHandler
    {
        public string dbDefaultFileName = "KyThuatBanBoBinh";
        public string dbConnection;

        private DataTable dt = new DataTable();

        public static DataSet ds = new DataSet();


        public VS_DBHandler()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var dbName = config.AppSettings.Settings[VS_Helper.AppConfigKey_DBName].Value;

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource = @"DESKTOP-O5CQR88\SQLEXPRESS",
                InitialCatalog = dbName,       
                IntegratedSecurity = false,
                TrustServerCertificate = true,
                UserID = "sa",
                Password = "123"
            };

            dbConnection = builder.ConnectionString;
        }



        public VS_DBHandler(string inputFileName)
        {
            string str = string.Format("{0}\\{1}", Application.StartupPath, inputFileName);
            dbConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + str + ";Persist Security Info=False";
        }

        public int ExecuteNonQuery(string sql)
        {
            int result = -1;
            try
            {
                using (SqlConnection conn = new SqlConnection(dbConnection))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        result = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }


        public int ExecuteNonQuerysTransaction(List<string> sqls)
        {
            int result = -1;
            using (SqlConnection conn = new SqlConnection(dbConnection))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    int num = 0;
                    foreach (var sql in sqls)
                    {
                        using (SqlCommand cmd = new SqlCommand(sql, conn, transaction))
                        {
                            num = cmd.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                    result = num;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
            return result;
        }


        public DataTable GetDataTable(string sql)
        {
            dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(dbConnection))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    ds.Reset();
                    da.Fill(ds);
                    dt = ds.Tables[0];

                    MessageBox.Show("Tổng dòng: " + dt.Rows.Count);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi truy vấn: " + e.Message);
                throw;
            }
            return dt;
        }



        public bool Insert(string tableName, Dictionary<string, string> data)
        {
            bool result = true;

            try
            {
                using (SqlConnection conn = new SqlConnection(dbConnection))
                {
                    conn.Open();

                    var columns = string.Join(", ", data.Keys);
                    var parameters = string.Join(", ", data.Keys.Select(k => "@" + k));

                    string sql = $"INSERT INTO {tableName} ({columns}) VALUES ({parameters})";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        foreach (var kvp in data)
                        {
                            cmd.Parameters.AddWithValue("@" + kvp.Key, kvp.Value);
                        }

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                result = false;
                throw e;
            }

            return result;
        }

        public bool Update(string tableName, Dictionary<string, string> data, string where)
        {
            bool result = true;

            try
            {
                using (SqlConnection conn = new SqlConnection(dbConnection))
                {
                    conn.Open();

                    var setClause = string.Join(", ", data.Keys.Select(k => $"{k} = @{k}"));
                    string sql = $"UPDATE {tableName} SET {setClause}";
                    if (!string.IsNullOrWhiteSpace(where))
                    {
                        sql += $" WHERE {where}";
                    }

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        foreach (var kvp in data)
                        {
                            cmd.Parameters.AddWithValue("@" + kvp.Key, kvp.Value);
                        }

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                result = false;
                throw e;
            }

            return result;
        }

        public bool Delete(string tableName, string where)
        {
            bool result = true;

            try
            {
                using (SqlConnection conn = new SqlConnection(dbConnection))
                {
                    conn.Open();

                    string sql = $"DELETE FROM {tableName}";
                    if (!string.IsNullOrWhiteSpace(where))
                    {
                        sql += $" WHERE {where}";
                    }

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                result = false;
                throw e;
            }

            return result;
        }


        public bool Transction(List<VS_DBTransactionQueryItem> tqis)
        {
            bool result = true;
            
            var sqls = new List<string>();
            for (int i = 0; i < tqis.Count; i++)
            {
                //case: INSERT
                if (tqis[i].Type == VS_DBCommandType.Insert)
                {
                    string text = "";
                    string text2 = "";
                    string tableName = tqis[i].TableName;
                    var data = tqis[i].Data;
                    foreach (KeyValuePair<string, string> keyValuePair in data)
                    {
                        text += string.Format(" {0},", keyValuePair.Key.ToString());
                        text2 += string.Format(" '{0}',", keyValuePair.Value);
                    }
                    text = text.Substring(0, text.Length - 1);
                    text2 = text2.Substring(0, text2.Length - 1);
                    sqls.Add(string.Format("insert into {0}({1}) values({2});", tableName, text, text2));
                }
                //case: UPDATE
                else if (tqis[i].Type == VS_DBCommandType.Update)
                {
                    string text = "";
                    string tableName = tqis[i].TableName;
                    var data = tqis[i].Data;
                    string where = tqis[i].WhereClause;
                    if (data.Count >= 1)
                    {
                        foreach (KeyValuePair<string, string> keyValuePair in data)
                        {
                            text += string.Format(" {0} = '{1}',", keyValuePair.Key.ToString(), keyValuePair.Value.ToString());
                        }
                        text = text.Substring(0, text.Length - 1);
                    }
                    if (where != "")
                    {
                        sqls.Add(string.Format("update {0} set {1} where {2};", tableName, text, where));
                    }
                    else
                    {
                        sqls.Add(string.Format("update {0} set {1};", tableName, text));
                    }
                }
                //case: DELETE
                else if (tqis[i].Type == VS_DBCommandType.Delete)
                {
                    string tableName = tqis[i].TableName;
                    string where = tqis[i].WhereClause;
                    if (where != "")
                    {
                        sqls.Add(string.Format("delete from {0} where {1};", tableName, where));
                    }
                    else
                    {
                        sqls.Add(string.Format("delete from {0};", tableName));
                    }
                }           
            }

            try
            {
                ExecuteNonQuerysTransaction(sqls);
            }
            catch (Exception e)
            {
                result = false;
                throw e;
            }

            return result;
        }
    }
}
