using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Text.Json;

namespace PBDT_2D.Manager
{
    public class VS_Helper
    {
        public const string DefaultCrewSetupFileFolder = "Kipban";
        public const string DefaultPrintSetupFileFolder = "Print";
        public const string AppConfigKey_PrintDefault = "printDefault";
        public const string AppConfigKey_DBName = "db";

        public static Image LoadEmbeddedImage(string fileName)
        {
            var fileBB = string.Format("{0}.jpg", fileName);

            string[] all = System.Reflection.Assembly.GetEntryAssembly().GetManifestResourceNames();

            foreach (string one in all)
            {
                if (one.ToLower().Contains(fileBB.ToLower()))
                    return Image.FromStream(System.Reflection.Assembly.GetEntryAssembly().GetManifestResourceStream(one));
            }
            
            return null;
        }

        public static Image Image16x16(Image img)
        {
            return new Bitmap(img, new Size(16, 16));
        }

        public static Image Image32x32(Image img)
        {
            return new Bitmap(img, new Size(32, 32));
        }

        public static void DrawHitPointOnImage(PictureBox picBox, float xRatio, float yRatio, string targetName)
        {
            if (picBox == null || picBox.Image == null) return;

            //get draw pos
            var x = picBox.Image.Size.Width * xRatio;
            var y = picBox.Image.Size.Height * yRatio;

            //draw hit point on image
            var img = picBox.Image;
            var g = Graphics.FromImage(img);

            //calculate scale radius factor
            //if img 3 times bigger then picbox, we use radius = 15
            var sFactorW = (float)img.Width / picBox.ClientSize.Width;
            var sFactorH = (float)img.Height / picBox.ClientSize.Height;
            //var sFactor = (sFactorW + sFactorH) / 2;
            var sFactor = Math.Max(sFactorW, sFactorH);
            float radius = (15 / 3) * sFactor;            

            //draw red circle as hit point
            if (!string.IsNullOrWhiteSpace(targetName) && targetName.ToLower().IndexOf("biasobong") != -1)
                g.FillEllipse(Brushes.Blue, x - radius / 2, y - radius / 2, radius, radius);//draw on red balloon
            else
                g.FillEllipse(Brushes.Red, x - radius / 2, y - radius / 2, radius, radius);

            //assign back to picture box
            picBox.Image = img;
        }

        public static void SetDataTable_To_Excel(DataTable dtTable, string PathFileName)
        {
            try
            {
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                xlWorkSheet.Name = "KetQua";
                for (int i = 0; i <= dtTable.Rows.Count - 1; i++)
                {
                    for (int j = 0; j <= dtTable.Columns.Count - 1; j++)
                    {
                        if (i == 0)
                            ((Excel.Range)xlWorkSheet.Cells[i + 1, j + 1]).Value2 = dtTable.Columns[j].ColumnName;

                        ((Excel.Range)xlWorkSheet.Cells[i + 2, j + 1]).Value2 = dtTable.Rows[i].ItemArray[j].ToString();
                    }
                }


                xlWorkBook.SaveAs(PathFileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlApp);
                releaseObject(xlWorkBook);
                releaseObject(xlWorkSheet);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi ghi kết quả ra file Excel !");
            }
        }
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }


        public static void WriteContentToFile(string filePath, string content)
        {
            try
            {
                using (var stream = File.Open(filePath, FileMode.Create))
                {
                    var bytes = Encoding.UTF8.GetBytes(content);
                    var base64 = Convert.ToBase64String(bytes);
                    var bytes64 = Encoding.UTF8.GetBytes(base64);
                    stream.Write(bytes64, 0, bytes64.Length);
                    
                }
            }
            catch (Exception)
            {   
                throw;
            }
        }

        public static string ReadFileContent(string filePath)
        {
            try
            {   
                using (var stream = File.Open(filePath, FileMode.Open))
                {
                    var bytes64 = new byte[stream.Length];
                    stream.Read(bytes64, 0, bytes64.Length);

                    var base64 = Encoding.UTF8.GetString(bytes64);
                    var bytes = Convert.FromBase64String(base64);
                    var content = Encoding.UTF8.GetString(bytes);

                    return content;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Write serializable object data to file
        public static void WriteDataToFile<T>(string filePath, T data)
        {
            try
            {
                var json = JsonSerializer.Serialize(data);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving file: " + ex.Message);
            }
        }

        //Read file data then deserialize to object
        public static T ReadDataFromFile<T>(string filePath)
        {
            try
            {
                var json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<T>(json);
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading file: " + ex.Message);
            }
        }

        /// <summary>
        /// Perform a deep copy of the object via serialization.
        /// </summary>
        /// <typeparam name="T">The type of object being copied.</typeparam>
        /// <param name="source">The object instance to copy.</param>
        /// <returns>A deep copy of the object.</returns>
        public static T Clone<T>(T source)
        {
            if (source == null)
                return default;

            var json = JsonSerializer.Serialize(source);
            return JsonSerializer.Deserialize<T>(json);
        }

    }
}
