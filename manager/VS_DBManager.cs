using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TBDT_2D.Manager
{
    public class VS_DBManager
    {
        public const string DBDateTimeFormat = "d/M/yyyy h:mm:ss tt";

        public static VS_DBHandler VS_Database = new VS_DBHandler();


        //EXERCISES
        public static List<VS_LoaiSung> LoadDanhSachSung()
        {
            var result = new List<VS_LoaiSung>();

            try
            {
                using (SqlConnection conn = new SqlConnection(VS_Database.dbConnection))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_GetDanhSachSung", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            da.Fill(dataTable);

                            foreach (DataRow dRow in dataTable.Rows)
                            {
                                var s = new VS_LoaiSung
                                {
                                    Id = dRow["IDSung"].ToString(),
                                    Name = dRow["TenLoaiSung"].ToString(),
                                    Note = dRow["GhiChu"].ToString(),
                                    IsActive = Convert.ToBoolean(dRow["Status"])
                                };
                                result.Add(s);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy xuất dữ liệu SPL: " + ex.Message);
            }

            return result;
        }


        public static List<VS_Baiban> LoadDSBBTheoLoaiSung(string idSung)
        {
            var result = new List<VS_Baiban>();

            try
            {
                using (SqlConnection conn = new SqlConnection(VS_Database.dbConnection))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_GetBaiBanTheoLoaiSung", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IDSung", idSung);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            da.Fill(dataTable);

                            foreach (DataRow dRow in dataTable.Rows)
                            {
                                string idBB = dRow[0]?.ToString() ?? "Unknown";
                                string tenBB = dRow[1]?.ToString() ?? "Unknown";
                                int.TryParse(dRow[2]?.ToString(), out int soDan);
                                string dsBia = dRow[3]?.ToString();
                                string timeShowHide = dRow[4]?.ToString();
                                int.TryParse(dRow[5]?.ToString(), out int gioi);
                                int.TryParse(dRow[6]?.ToString(), out int kha);
                                int.TryParse(dRow[7]?.ToString(), out int dat);
                                bool.TryParse(dRow[8]?.ToString(), out bool typeMarked);
                                bool.TryParse(dRow[9]?.ToString(), out bool typeHit);
                                bool.TryParse(dRow[10]?.ToString(), out bool byTarget);
                                bool.TryParse(dRow[11]?.ToString(), out bool byGun);
                                string order2D = dRow[12]?.ToString();
                                string biaDKKha = dRow[13]?.ToString();
                                string biaKTTruDiem = dRow[14]?.ToString();
                                string biaKDBan = dRow[15]?.ToString();

                                bool.TryParse(dRow[16]?.ToString(), out bool totalHitCheck);
                                int.TryParse(dRow[17]?.ToString(), out int totalHit_Gioi);
                                int.TryParse(dRow[18]?.ToString(), out int totalHit_Kha);
                                int.TryParse(dRow[19]?.ToString(), out int totalHit_Dat);

                                bool.TryParse(dRow[20]?.ToString(), out bool firstHitCheck);
                                int.TryParse(dRow[21]?.ToString(), out int firstHit_Gioi);
                                int.TryParse(dRow[22]?.ToString(), out int firstHit_Kha);
                                int.TryParse(dRow[23]?.ToString(), out int firstHit_Dat);

                                bool.TryParse(dRow[24]?.ToString(), out bool bulletRemainsCheck);
                                bool.TryParse(dRow[25]?.ToString(), out bool bulletRemain_Gioi);
                                bool.TryParse(dRow[26]?.ToString(), out bool bulletRemain_Kha);
                                bool.TryParse(dRow[27]?.ToString(), out bool bulletRemain_Dat);

                                bool.TryParse(dRow[28]?.ToString(), out bool drawHitPoint);

                                var s = new VS_Baiban
                                {
                                    Id = idBB,
                                    TenBB = tenBB,
                                    IdSung = idSung,
                                    SoLuongDan = soDan,
                                    DanhSachBia = dsBia,
                                    ThuTuSapXep2D = order2D,
                                    ThoiGianAnHien = timeShowHide,
                                    DiemGioi = gioi,
                                    DiemKha = kha,
                                    DiemDat = dat,
                                    ScoreType = typeMarked ? (int)VS_BBScoreType.Marked : (int)VS_BBScoreType.Hit,
                                    DisplayType = byTarget ? (int)VS_BBDisplayType.ByTarget : (int)VS_BBDisplayType.ByGun,
                                    BiaDKKha = biaDKKha,
                                    BiaKoTrungTruDiem = biaKTTruDiem,
                                    BiaKoDuocBan = biaKDBan,

                                    TotalHitCheck = totalHitCheck,
                                    TotalHit_Gioi = totalHit_Gioi,
                                    TotalHit_Kha = totalHit_Kha,
                                    TotalHit_Dat = totalHit_Dat,

                                    FirstHitCheck = firstHitCheck,
                                    FirstHit_Gioi = firstHit_Gioi,
                                    FirstHit_Kha = firstHit_Kha,
                                    FirstHit_Dat = firstHit_Dat,

                                    BulletRemainsCheck = bulletRemainsCheck,
                                    BulletRemain_Gioi = bulletRemainsCheck ? bulletRemain_Gioi : false,
                                    BulletRemain_Kha = bulletRemainsCheck ? bulletRemain_Kha : false,
                                    BulletRemain_Dat = bulletRemainsCheck ? bulletRemain_Dat : false,

                                    DrawHitPoint = drawHitPoint
                                };

                                result.Add(s);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy xuất dữ liệu SPL1: " + ex.Message);
            }

            return result;
        }


        public static bool UpdateDKBaiBan(VS_Baiban baiban)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(VS_Database.dbConnection))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_UpdateDKBaiBan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IDSung", baiban.IdSung);
                        cmd.Parameters.AddWithValue("@IDBaiBan", baiban.Id);
                        cmd.Parameters.AddWithValue("@ThoiGianAnHien", baiban.ThoiGianAnHien.Trim());
                        cmd.Parameters.AddWithValue("@SoLuongDan", baiban.SoLuongDan);
                        cmd.Parameters.AddWithValue("@DiemGioi", baiban.DiemGioi);
                        cmd.Parameters.AddWithValue("@DiemKha", baiban.DiemKha);
                        cmd.Parameters.AddWithValue("@DiemDat", baiban.DiemDat);

                        cmd.Parameters.AddWithValue("@TotalHitCheck", baiban.TotalHitCheck);
                        cmd.Parameters.AddWithValue("@TotalHit_Gioi", baiban.TotalHit_Gioi);
                        cmd.Parameters.AddWithValue("@TotalHit_Kha", baiban.TotalHit_Kha);
                        cmd.Parameters.AddWithValue("@TotalHit_Dat", baiban.TotalHit_Dat);

                        cmd.Parameters.AddWithValue("@FirstHitCheck", baiban.FirstHitCheck);
                        cmd.Parameters.AddWithValue("@FirstHit_Gioi", baiban.FirstHit_Gioi);
                        cmd.Parameters.AddWithValue("@FirstHit_Kha", baiban.FirstHit_Kha);
                        cmd.Parameters.AddWithValue("@FirstHit_Dat", baiban.FirstHit_Dat);

                        cmd.Parameters.AddWithValue("@BulletRemainsCheck", baiban.BulletRemainsCheck);
                        cmd.Parameters.AddWithValue("@BulletRemain_Gioi", baiban.BulletRemain_Gioi);
                        cmd.Parameters.AddWithValue("@BulletRemain_Kha", baiban.BulletRemain_Kha);
                        cmd.Parameters.AddWithValue("@BulletRemain_Dat", baiban.BulletRemain_Dat);

                        cmd.Parameters.AddWithValue("@DrawHitPoint", baiban.DrawHitPoint);

                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật dữ liệu!\n" + ex.Message);
                return false;
            }
        }



        //USERS
        public static List<VS_QuanHam> LoadAllQuanHams()
        {
            var result = new List<VS_QuanHam>();

            try
            {
                using (SqlConnection conn = new SqlConnection(VS_Database.dbConnection))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_GetAllQuanHam", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var s = new VS_QuanHam
                                {
                                    Id = reader.GetInt32(0),
                                    QuanHam = reader.GetString(1)
                                };
                                result.Add(s);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi truy xuất dữ liệu Quan Hàm!");
            }

            return result;
        }


        public static List<VS_User> LoadAllUsers(string filterTen, int filterQH, string filterChucVu, string filterDonVi, string filterGhiChu)
        {
            var result = new List<VS_User>();

            try
            {
                using (SqlConnection conn = new SqlConnection(VS_Database.dbConnection))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_GetAllUsersFiltered", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Ten", string.IsNullOrEmpty(filterTen) ? (object)DBNull.Value : filterTen);
                        cmd.Parameters.AddWithValue("@QuanHamId", filterQH);
                        cmd.Parameters.AddWithValue("@ChucVu", string.IsNullOrEmpty(filterChucVu) ? (object)DBNull.Value : filterChucVu);
                        cmd.Parameters.AddWithValue("@DonVi", string.IsNullOrEmpty(filterDonVi) ? (object)DBNull.Value : filterDonVi);
                        cmd.Parameters.AddWithValue("@GhiChu", string.IsNullOrEmpty(filterGhiChu) ? (object)DBNull.Value : filterGhiChu);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            int stt = 0;
                            while (reader.Read())
                            {
                                stt++;
                                var s = new VS_User
                                {
                                    Id = reader.GetInt32(0),
                                    ThuTu = stt,
                                    Ten = reader.GetString(1),
                                    QuanHamId = reader.GetInt32(2),
                                    QuanHam = reader.IsDBNull(3) ? "" : reader.GetString(3),
                                    ChucVu = reader.IsDBNull(4) ? "" : reader.GetString(4),
                                    DonVi = reader.IsDBNull(5) ? "" : reader.GetString(5),
                                    GhiChu = reader.IsDBNull(6) ? "" : reader.GetString(6)
                                };
                                result.Add(s);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy xuất dữ liệu người dùng!\n" + ex.Message);
            }

            return result;
        }


        public static bool AddEditUser(VS_User userData)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(VS_Database.dbConnection))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_AddEditUser", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Id", userData.Id);
                        cmd.Parameters.AddWithValue("@Ten", userData.Ten.Trim());
                        cmd.Parameters.AddWithValue("@QuanHamId", userData.QuanHamId);
                        cmd.Parameters.AddWithValue("@ChucVu", userData.ChucVu ?? "");
                        cmd.Parameters.AddWithValue("@DonVi", userData.DonVi ?? "");
                        cmd.Parameters.AddWithValue("@GhiChu", userData.GhiChu ?? "");

                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật dữ liệu!\n" + ex.Message);
                return false;
            }
        }


        public static bool DeleteUser(VS_User userData)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(VS_Database.dbConnection))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_DeleteUser", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id", userData.Id);

                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa dữ liệu!\n" + ex.Message);
                return false;
            }
        }


        public static List<VS_GiaoVu> LoadAllGiaoVu(int filterQH, string filterHoTen, int? filterNamSinh)
        {
            var result = new List<VS_GiaoVu>();

            try
            {
                Debug.WriteLine(">>> Vào hàm LoadAllGiaoVu");

                using (SqlConnection conn = new SqlConnection(VS_Database.dbConnection))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_GetAllGiaoVuFiltered", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@HoTen", string.IsNullOrEmpty(filterHoTen) ? (object)DBNull.Value : filterHoTen);
                        cmd.Parameters.AddWithValue("@QuanHamID", filterQH == 0 ? (object)DBNull.Value : filterQH);
                        cmd.Parameters.AddWithValue("@NamSinh", filterNamSinh.HasValue ? (object)filterNamSinh.Value : DBNull.Value);


                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            int stt = 0;
                            while (reader.Read())
                            {
                                stt++;
                                var s = new VS_GiaoVu
                                {
                                    Id = reader.GetInt32(0),
                                    ThuTu = stt,
                                    QuanHamId = reader.GetInt32(3),
                                    HoTen = reader.GetString(1),
                                    NamSinh = reader.GetInt32(2),
                                    QuanHam = reader.GetString(4),
                                };
                                Debug.WriteLine($"[GiaoVu] STT: {s.ThuTu}, Id: {s.Id} QHId: {s.QuanHamId}, HoTen: {s.HoTen}, NamSinh: {s.NamSinh}, QuanHam: {s.QuanHam}");
                                result.Add(s);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[ERROR] LoadAllGiaoVu - " + ex.ToString());
                MessageBox.Show("Lỗi truy xuất dữ liệu người dùng!\n" + ex.Message);
            }

            return result;
        }


        public static bool AddEditGiaoVu(VS_GiaoVu gvData)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(VS_Database.dbConnection))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_AddEditGiaoVu", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Id", gvData.Id);
                        cmd.Parameters.AddWithValue("@QuanHamId", gvData.QuanHamId);
                        cmd.Parameters.AddWithValue("@HoTen", gvData.HoTen.Trim());
                        cmd.Parameters.AddWithValue("@NamSinh", gvData.NamSinh);

                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật dữ liệu!\n" + ex.Message);
                return false;
            }
        }


        public static bool DeleteGiaoVu(VS_GiaoVu gvData)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(VS_Database.dbConnection))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_DeleteGiaoVu", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id", gvData.Id);

                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa dữ liệu!\n" + ex.Message);
                return false;
            }
        }

        //CREW
        public static List<VS_KipBan> LoadDSKipBan(VS_SearchConditions conds)
        {
            var result = new List<VS_KipBan>();

            try
            {
                using (SqlConnection conn = new SqlConnection(VS_Database.dbConnection))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_LoadDSKipBan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@From", conds.From);
                        cmd.Parameters.AddWithValue("@To", conds.To);
                        cmd.Parameters.AddWithValue("@IdSung", string.IsNullOrEmpty(conds.IdSung) ? (object)DBNull.Value : conds.IdSung);
                        cmd.Parameters.AddWithValue("@IdBaiBan", string.IsNullOrEmpty(conds.IdBaiBan) ? (object)DBNull.Value : conds.IdBaiBan);
                        cmd.Parameters.AddWithValue("@IdNguoiDung", conds.IdTeacher);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var st = DateTime.Parse(reader["ThoiGianBatDau"].ToString());
                                if (st < conds.From || st > conds.To) continue;

                                var s = new VS_KipBan
                                {
                                    Id = int.Parse(reader["Id"].ToString()),
                                    ThoiGianBatDau = DateTime.Parse(reader["ThoiGianBatDau"].ToString()),
                                    ThoiGianKetThuc = DateTime.Parse(reader["ThoiGianKetThuc"].ToString()),
                                    IdBaiBan = reader["IdBaiBan"].ToString(),
                                    TenBaiBanFull = reader["TenBaiBanFull"].ToString(),
                                    IdNguoiDung = int.Parse(reader["IdNguoiDung"].ToString()),
                                    IsSelected = true
                                };
                                result.Add(s);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy xuất dữ liệu!\n" + ex.Message);
            }

            return result;
        }


        public static bool SaveCrewResult(VS_KipBan info, List<VS_KetQua> result)
        {
            try
            {
                using (var conn = new SqlConnection(VS_Database.dbConnection))
                {
                    conn.Open();

                    // 1. Gọi SP chèn Kíp Bắn
                    int newKipBanId = 0;
                    using (var cmd = new SqlCommand("sp_InsertKipBan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ThoiGianBatDau", info.ThoiGianBatDau.ToString(DBDateTimeFormat));
                        cmd.Parameters.AddWithValue("@ThoiGianKetThuc", info.ThoiGianKetThuc.ToString(DBDateTimeFormat));
                        cmd.Parameters.AddWithValue("@IdBaiBan", info.IdBaiBan.Trim());
                        cmd.Parameters.AddWithValue("@TenBaiBanFull", info.TenBaiBanFull.Trim());
                        cmd.Parameters.AddWithValue("@IdNguoiDung", info.IdNguoiDung);
                        var outParam = new SqlParameter("@NewId", SqlDbType.Int) { Direction = ParameterDirection.Output };
                        cmd.Parameters.Add(outParam);
                        cmd.ExecuteNonQuery();
                        newKipBanId = (int)outParam.Value;
                    }

                    // 2. Tạo DataTable từ result
                    var dt = new DataTable();
                    dt.Columns.Add("IdNguoiDung", typeof(int));
                    dt.Columns.Add("IdSung", typeof(string));
                    dt.Columns.Add("ThanhTich", typeof(string));
                    dt.Columns.Add("TongDiem", typeof(int));
                    dt.Columns.Add("XepLoai", typeof(string));

                    foreach (var r in result)
                        dt.Rows.Add(r.IdNguoiDung, r.IdSung, r.ThanhTich, r.TongDiem, r.XepLoai);

                    // 3. Gọi SP chèn danh sách kết quả
                    using (var cmd = new SqlCommand("sp_InsertKetQuaList", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdKipBan", newKipBanId);
                        var tvp = new SqlParameter("@KetQuaList", SqlDbType.Structured)
                        {
                            TypeName = "KetQuaType",
                            Value = dt
                        };
                        cmd.Parameters.Add(tvp);
                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi lưu kết quả kíp bắn!");
                return false;
            }
        }


        //SEARCH
        public static List<VS_SearchResult> SearchResultByCondtions(VS_SearchConditions conds)
        {
            var result = new List<VS_SearchResult>();

            try
            {
                using (SqlConnection conn = new SqlConnection(VS_Database.dbConnection)) // thay bằng connection string của bạn
                using (SqlCommand cmd = new SqlCommand("sp_SearchKetQua", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdSung", conds.IdSung != null ? (object)conds.IdSung : DBNull.Value);
                    cmd.Parameters.AddWithValue("@IdBaiBan", conds.IdBaiBan != null ? (object)conds.IdBaiBan : DBNull.Value);
                    cmd.Parameters.AddWithValue("@IdKBRange", conds.IdKBRange != null ? (object)conds.IdKBRange : DBNull.Value);
                    cmd.Parameters.AddWithValue("@IdTeacher", conds.IdTeacher);

                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        da.Fill(dataTable);

                        foreach (DataRow dRow in dataTable.Rows)
                        {
                            if (string.IsNullOrEmpty(dRow["IdKetQua"]?.ToString()))
                                continue;

                            DateTime batDau = Convert.ToDateTime(dRow["TGBatDau"]);
                            if (batDau < conds.From || batDau > conds.To)
                                continue;

                            var s = new VS_SearchResult
                            {
                                IdKetQua = Convert.ToInt32(dRow["IdKetQua"]),
                                IdBaiBan = dRow["IdBaiBan"].ToString(),
                                TenBaiBanFull = dRow["TenBaiBanFull"].ToString(),
                                TGBatDau = Convert.ToDateTime(dRow["TGBatDau"]),
                                TGKetThuc = Convert.ToDateTime(dRow["TGKetThuc"]),
                                ND_Id = Convert.ToInt32(dRow["ND_Id"]),
                                ND_Ten = dRow["ND_Ten"].ToString(),
                                ND_QuanHam = dRow["ND_QuanHam"].ToString(),
                                ND_ChucVu = dRow["ND_ChucVu"].ToString(),
                                ND_DonVi = dRow["ND_DonVi"].ToString(),
                                ND_GhiChu = dRow["ND_GhiChu"].ToString(),
                                ND_IdSungBan = Convert.ToInt32(dRow["ND_IdSungBan"]),
                                ND_ThanhTich = dRow["ND_ThanhTich"].ToString(),
                                ND_TongDiem = Convert.ToInt32(dRow["ND_TongDiem"]),
                                ND_XepLoai = dRow["ND_XepLoai"].ToString(),
                                IsSelected = true
                            };

                            result.Add(s);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy xuất dữ liệu!\n" + ex.Message);
            }

            return result;
        }

    }
}
