using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PBDT_2D.Manager;
using System.Drawing.Printing;
using System.IO;
using System.Configuration;
using System.Diagnostics;

namespace PBDT_2D.Forms
{
    public partial class VS_PrintPreview : Form
    {
        DataGridView printData;
        VS_PrintPreviewSettings settings;
        int viewPagesPerRow = 2;
        int currentPrintPageNumber;
        int totalPageNumber;

        public VS_PrintPreview()
        {
            InitializeComponent();
        }

        public VS_PrintPreview(DataGridView dgv)
        {
            InitializeComponent();
            InitData(dgv);
            GetDefaultSettings();
            btnPreview_Click(null, null);
        }

        #region Methods
        void InitData(DataGridView dgv)
        {
            settings = new VS_PrintPreviewSettings
            {
                Page_Lanscape = true,

                Header_Draw = true,
                Header_Font = new Font("Times New Roman", 16, FontStyle.Bold),
                Header_Format = new StringFormat
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Center
                },

                Title_Draw = true,
                Title_Font = new Font("Times New Roman", 24, FontStyle.Bold),
                Title_Format = new StringFormat
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Center
                },

                FirstSentences_Draw = true,
                FirstSentences_Font = new Font("Times New Roman", 12),
                FirstSentences_Format = new StringFormat
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Near
                },

                Content_HeaderFont = new Font("Times New Roman", 12, FontStyle.Bold),
                Content_Font = new Font("Times New Roman", 12),
                Content_GridFormat = new StringFormat
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Center
                },

                Footer_Draw = true,
                Footer_Font = new Font("Times New Roman", 12),
                Footer_TextPattern = "Page {0}",
                Footer_Format = new StringFormat
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Far
                }
            };

            //sections format
            header_cboAlign.SelectedIndex = GetCboAlignmentIndex(settings.Header_Format.Alignment);
            title_cboAlign.SelectedIndex = GetCboAlignmentIndex(settings.Title_Format.Alignment);
            firstSentences_cboAlign.SelectedIndex = GetCboAlignmentIndex(settings.FirstSentences_Format.Alignment);
            content_cboAlign.SelectedIndex = GetCboAlignmentIndex(settings.Content_GridFormat.Alignment);
            footer_cboAlign.SelectedIndex = GetCboAlignmentIndex(settings.Footer_Format.Alignment);

            footer_cboType.SelectedIndex = 1;

            //page settings
            others_rdPortrait.Checked = !settings.Page_Lanscape;
            others_rdLanscape.Checked = settings.Page_Lanscape;

            //grid
            printData = dgv;
            grdSetupHeaders.DataSource = GetAvaiableFields(dgv);
        }

        void GetDefaultSettings()
        {
            try
            {
                // Open App.Config of executable
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var defaultFileName = config.AppSettings.Settings[VS_Helper.AppConfigKey_PrintDefault].Value;
                if (string.IsNullOrWhiteSpace(defaultFileName)) return;

                var folderPath = string.Format("{0}\\{1}", Path.GetDirectoryName(Application.ExecutablePath), VS_Helper.DefaultPrintSetupFileFolder);
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                var defaultFilePath = string.Format("{0}\\{1}", folderPath, defaultFileName);
                var data = VS_Helper.ReadDataFromFile<VS_PrintSettings>(defaultFilePath);
                ParseSettingsData(data);
            }
            catch (Exception)
            {
                MessageBox.Show("Đọc thiết lập mặc định lỗi");
            }
        }

        void PrintPrepare(PrintPageEventArgs e)
        {
            //I.PAGE
            settings.Page_Bounds = e.PageSettings.Bounds;
            settings.Page_Margins = e.PageSettings.Margins;
            settings.Page_x0 = e.PageSettings.Margins.Left;
            settings.Page_y0 = e.PageSettings.Margins.Top;
            settings.Page_w = e.PageSettings.Bounds.Width - settings.Page_x0 - settings.Page_y0;
            settings.Page_h = e.PageSettings.Bounds.Height - e.PageSettings.Margins.Top - e.PageSettings.Margins.Bottom;

            //II.HEADER
            settings.Header_Draw = header_cbDraw.Checked;
            settings.Header_Text = header_tbText.Text;
            settings.Header_Bounds = new RectangleF(settings.Page_x0, 0, e.MarginBounds.Width, e.PageSettings.Margins.Top);
            using (Graphics graphics = Graphics.FromImage(new Bitmap(1, 1)))
            {
                var sizeF = graphics.MeasureString(settings.Header_Text, settings.Header_Font, new SizeF(e.MarginBounds.Width, e.PageSettings.Margins.Top));
                settings.Header_LineStartPoint = new PointF(settings.Page_x0, e.PageSettings.Margins.Top / 2 + sizeF.Height / 2 + 2f);
                settings.Header_LineEndPoint = new PointF(settings.Page_x0 + settings.Page_w, e.PageSettings.Margins.Top / 2 + sizeF.Height / 2 + 2f);
            }

            //III.TITLE
            settings.Title_Draw = title_cbDraw.Checked;
            if (settings.Title_Draw)
            {
                settings.Title_Text = title_tbText.Text;
                using (Graphics graphics = Graphics.FromImage(new Bitmap(1, 1)))
                {
                    var sizeF = graphics.MeasureString(settings.Title_Text, settings.Title_Font, new SizeF(e.MarginBounds.Size));
                    settings.Title_Bounds = new RectangleF(settings.Page_x0, settings.Page_y0, e.MarginBounds.Width, sizeF.Height);
                }
            }
            else
            {
                settings.Title_Text = string.Empty;
                settings.Title_Bounds = new RectangleF(settings.Page_x0, settings.Page_y0, e.MarginBounds.Width, 0);
            }
            

            //IV.FIRST SENTENCES
            settings.FirstSentences_Draw = firstSentences_cbDraw.Checked;
            if (settings.FirstSentences_Draw)
            {
                settings.FirstSentences_Text = firstSentences_tbText.Text;
                using (Graphics graphics = Graphics.FromImage(new Bitmap(1, 1)))
                {
                    var sizeF = graphics.MeasureString(settings.FirstSentences_Text, settings.FirstSentences_Font, new SizeF(e.MarginBounds.Size));
                    settings.FirstSentences_Bounds = new RectangleF(settings.Page_x0, settings.Page_y0 + settings.Title_Bounds.Height, e.MarginBounds.Width, sizeF.Height);
                }
            }
            else
            {
                settings.FirstSentences_Text = string.Empty;
                settings.FirstSentences_Bounds = new RectangleF(settings.Page_x0, settings.Page_y0 + settings.Title_Bounds.Height, e.MarginBounds.Width, 0);
            }
            

            //V.CONTENT
            settings.Content_DataRows = new List<VS_PrintDataRow>();
            float content_x = settings.Page_x0;
            float content_y = settings.Page_y0 + settings.Title_Bounds.Height + settings.FirstSentences_Bounds.Height;
            //1.header row
            int countPage = 1;
            settings.Content_HeaderRow = new VS_PrintDataRow { PageNumber = countPage };
            float maxH = 0;
            foreach (DataGridViewRow r in grdSetupHeaders.Rows)
            {
                if (!bool.Parse(r.Cells["IsSelected"].Value.ToString())) continue;

                string id = r.Cells["HeaderId"].Value.ToString();
                string txt = r.Cells["HeaderDisplay"].Value == null ? string.Empty : r.Cells["HeaderDisplay"].Value.ToString();
                int w = int.Parse(r.Cells["HeaderWidth"].Value.ToString());
                RectangleF b;                

                using (Graphics graphics = Graphics.FromImage(new Bitmap(1, 1)))
                {
                    var sizeF = graphics.MeasureString(txt, settings.Content_HeaderFont, new SizeF(w, e.MarginBounds.Size.Height));
                    b = new RectangleF(content_x, content_y, w, sizeF.Height);
                    if (maxH < sizeF.Height)
                        maxH = sizeF.Height;
                }

                settings.Content_HeaderRow.Cells.Add(new VS_PrintDataCell
                {
                    GridColumnId = id,
                    Text = txt,
                    Bounds = b
                });

                content_x += w;
            }
            //rebuild row height
            foreach (var c in settings.Content_HeaderRow.Cells)
            {
                c.Bounds = new RectangleF(c.Bounds.X, c.Bounds.Y, c.Bounds.Width, maxH);
            }
            //2.data rows            
            foreach (DataGridViewRow dataRow in printData.Rows)
            {
                if (dataRow.Cells["IsSelected"].Value == null 
                    || !bool.Parse(dataRow.Cells["IsSelected"].Value.ToString())) continue;

                content_x = settings.Page_x0;
                content_y += maxH;

                var printRow = new VS_PrintDataRow { PageNumber = countPage };
                RectangleF b;

                maxH = 0;
                foreach (var col in settings.Content_HeaderRow.Cells)
                {
                    if (dataRow.Cells[col.GridColumnId].Value == null) continue;

                    string txt = dataRow.Cells[col.GridColumnId].Value.ToString();
                    using (Graphics graphics = Graphics.FromImage(new Bitmap(1, 1)))
                    {
                        var sizeF = graphics.MeasureString(txt, settings.Content_Font, new SizeF(col.Bounds.Width, e.MarginBounds.Size.Height));
                        b = new RectangleF(content_x, content_y, col.Bounds.Width, sizeF.Height);
                        if (maxH < sizeF.Height)
                            maxH = sizeF.Height;
                    }

                    printRow.Cells.Add(new VS_PrintDataCell
                    {
                        GridColumnId = col.GridColumnId,
                        Text = txt,
                        Bounds = b
                    });

                    content_x += col.Bounds.Width;
                }
                //rebuild row height
                bool goToNextPage = false;
                foreach (var c in printRow.Cells)
                {
                    c.Bounds = new RectangleF(c.Bounds.X, c.Bounds.Y, c.Bounds.Width, maxH);

                    //check if current printed row exceed page height
                    if (content_y + maxH > settings.Page_y0 + e.MarginBounds.Size.Height)
                    {
                        goToNextPage = true;
                        c.Bounds = new RectangleF(c.Bounds.X, settings.Page_y0, c.Bounds.Width, maxH);
                    }
                }
                if (goToNextPage)
                {
                    countPage++;
                    printRow.PageNumber = countPage;

                    content_y = settings.Page_y0;
                }
                settings.Content_DataRows.Add(printRow);
            }
            
            //3.align grid
            if (settings.Content_GridFormat.Alignment != StringAlignment.Near)
            {
                float gridWidth = settings.Content_HeaderRow.Cells.Sum(c => c.Bounds.Width);
                float blank = e.MarginBounds.Width - gridWidth;
                float xShift = settings.Content_GridFormat.Alignment == StringAlignment.Far ? blank : blank / 2;

                //change grid position base on alignment setting
                foreach (var c in settings.Content_HeaderRow.Cells)
                {
                    c.Bounds = new RectangleF(c.Bounds.X + xShift, c.Bounds.Y, c.Bounds.Width, c.Bounds.Height);
                }
                foreach (var r in settings.Content_DataRows)
                {
                    foreach (var c in r.Cells)
                    {
                        c.Bounds = new RectangleF(c.Bounds.X + xShift, c.Bounds.Y, c.Bounds.Width, c.Bounds.Height);
                    }
                }
            }

            //VI.FOOTER
            settings.Footer_Draw = footer_cbDraw.Checked;
            settings.Footer_Bounds = new RectangleF(settings.Page_x0, settings.Page_y0 + e.MarginBounds.Height, e.MarginBounds.Width, e.PageSettings.Margins.Bottom);
            using (Graphics graphics = Graphics.FromImage(new Bitmap(1, 1)))
            {
                var sizeF = graphics.MeasureString("Page 1", settings.Footer_Font, new SizeF(e.MarginBounds.Width, e.PageSettings.Margins.Bottom));
                settings.Footer_LineStartPoint = new PointF(settings.Page_x0, e.PageSettings.Bounds.Height - e.PageSettings.Margins.Bottom / 2 - sizeF.Height / 2 - 2);
                settings.Footer_LineEndPoint = new PointF(settings.Page_x0 + settings.Page_w,
                                                            e.PageSettings.Bounds.Height - e.PageSettings.Margins.Bottom / 2 - sizeF.Height / 2 - 2);
            }

            totalPageNumber = countPage;

            //setup print preview control pages view
            if (countPage >= viewPagesPerRow)
            {
                printPreview.Columns = viewPagesPerRow;
                printPreview.Rows = (int)Math.Ceiling((double)countPage / viewPagesPerRow);
            }
        }

        List<VS_PrintHeaderSetup> GetAvaiableFields(DataGridView dgv)
        {
            var result = new List<VS_PrintHeaderSetup>();

            foreach (DataGridViewColumn cl in dgv.Columns)
            {
                if (!cl.Visible || cl.DataPropertyName == "IsSelected") continue;

                result.Add(new VS_PrintHeaderSetup
                {
                    HeaderId = cl.DataPropertyName,
                    HeaderDisplay = cl.HeaderText,
                    HeaderWidth = 100,
                    IsSelected = true
                });
            }

            return result;
        }

        VS_PrintSettings WrapPrintSettings()
        {
            var ps = new VS_PrintSettings();

            ps.Page_Lanscape = others_rdLanscape.Checked;

            ps.Header_Draw = header_cbDraw.Checked;
            ps.Header_Text = header_tbText.Text;
            ps.Header_Font = settings.Header_Font;
            ps.Header_Format = settings.Header_Format.Alignment;

            ps.Title_Draw = title_cbDraw.Checked;
            ps.Title_Text = title_tbText.Text;
            ps.Title_Font = settings.Title_Font;
            ps.Title_Format = settings.Title_Format.Alignment;

            ps.FirstSentences_Draw = firstSentences_cbDraw.Checked;
            ps.FirstSentences_Text = firstSentences_tbText.Text;
            ps.FirstSentences_Font = settings.FirstSentences_Font;
            ps.FirstSentences_Format = settings.FirstSentences_Format.Alignment;

            ps.Content_GridHeaderSetup = new List<VS_PrintHeaderSetup>();
            foreach (DataGridViewRow r in grdSetupHeaders.Rows)
            {
                ps.Content_GridHeaderSetup.Add(new VS_PrintHeaderSetup
                {
                    HeaderId = r.Cells["HeaderId"].Value.ToString(),
                    HeaderDisplay = r.Cells["HeaderDisplay"].Value.ToString(),
                    HeaderWidth = int.Parse(r.Cells["HeaderWidth"].Value.ToString()),
                    IsSelected = bool.Parse(r.Cells["IsSelected"].Value.ToString())
                });
            }
            ps.Content_HeaderFont = settings.Content_HeaderFont;
            ps.Content_Font = settings.Content_Font;
            ps.Content_GridFormat = settings.Content_GridFormat.Alignment;

            ps.Footer_Draw = footer_cbDraw.Checked;
            ps.Footer_Font = settings.Footer_Font;
            ps.Footer_TextPatternIndex = footer_cboType.SelectedIndex;
            ps.Footer_Format = settings.Footer_Format.Alignment;

            return ps;
        }

        void ParseSettingsData(VS_PrintSettings data)
        {
            //header
            header_cbDraw.Checked = data.Header_Draw;
            header_tbText.Text = data.Header_Text;
            settings.Header_Font = data.Header_Font;
            header_cboAlign.SelectedIndex = GetCboAlignmentIndex(data.Header_Format);

            //title
            title_cbDraw.Checked = data.Title_Draw;
            title_tbText.Text = data.Title_Text;
            settings.Title_Font = data.Title_Font;
            title_cboAlign.SelectedIndex = GetCboAlignmentIndex(data.Title_Format);

            //first sentences
            firstSentences_cbDraw.Checked = data.FirstSentences_Draw;
            firstSentences_tbText.Text = data.FirstSentences_Text;
            settings.FirstSentences_Font = data.FirstSentences_Font;
            firstSentences_cboAlign.SelectedIndex = GetCboAlignmentIndex(data.FirstSentences_Format);

            //content
            grdSetupHeaders.DataSource = data.Content_GridHeaderSetup;
            settings.Content_HeaderFont = data.Content_HeaderFont;
            settings.Content_Font = data.Content_Font;
            content_cboAlign.SelectedIndex = GetCboAlignmentIndex(data.Content_GridFormat);

            //footer
            footer_cbDraw.Checked = data.FirstSentences_Draw;
            settings.Footer_Font = data.Footer_Font;
            footer_cboType.SelectedIndex = data.Footer_TextPatternIndex;
            footer_cboAlign.SelectedIndex = GetCboAlignmentIndex(data.Footer_Format);

            //page
            others_rdLanscape.Checked = data.Page_Lanscape;
            others_rdPortrait.Checked = !data.Page_Lanscape;
        }
        int GetCboAlignmentIndex(StringAlignment alignment)
        {
            if (alignment == StringAlignment.Near)
                return 0;
            else if (alignment == StringAlignment.Far)
                return 2;
            else
                return 1;
        }

        void PrintToPDF()
        {
            try
            {
                var sfd = new SaveFileDialog();
                sfd.Title = "Lưu kết quả dưới dạng PDF";
                sfd.InitialDirectory = Directory.GetCurrentDirectory();
                sfd.Filter = "All files (*.*) | *.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string fileName = sfd.FileName;
                    string extesion = Path.GetExtension(fileName);
                    switch (extesion)
                    {
                        case ".pdf":                            
                            printPreview.Document.PrinterSettings = new PrinterSettings
                            {
                                // set the printer to 'Microsoft Print to PDF'
                                PrinterName = "Microsoft Print to PDF",
                                // tell the object this document will print to file
                                PrintToFile = true,
                                // set the filename to whatever you like (full path)
                                PrintFileName = fileName
                            };
                            printPreview.Document.DefaultPageSettings.Landscape = settings.Page_Lanscape;

                            printPreview.Document.Print();
                            MessageBox.Show("Lưu kết quả dưới dạng PDF thành công");

                            //Process.Start("explorer.exe", Path.GetDirectoryName(fileName));
                            break;
                        default:
                            MessageBox.Show("Đuôi file lưu không đúng định dạng");
                            break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        #endregion

        #region Events
        private void header_btnFont_Click(object sender, EventArgs e)
        {
            var fd = new FontDialog();            
            fd.Font = settings.Header_Font;

            if (fd.ShowDialog() == DialogResult.OK)
                settings.Header_Font = fd.Font;
        }
        private void header_cboAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (header_cboAlign.SelectedIndex == 0)
                settings.Header_Format.Alignment = StringAlignment.Near;
            else if (header_cboAlign.SelectedIndex == 2)
                settings.Header_Format.Alignment = StringAlignment.Far;
            else
                settings.Header_Format.Alignment = StringAlignment.Center;
        }
        private void title_btnFont_Click(object sender, EventArgs e)
        {
            var fd = new FontDialog();
            fd.Font = settings.Title_Font;

            if (fd.ShowDialog() == DialogResult.OK)
                settings.Title_Font = fd.Font;
        }
        private void title_cboAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (title_cboAlign.SelectedIndex == 0)
                settings.Title_Format.Alignment = StringAlignment.Near;
            else if (title_cboAlign.SelectedIndex == 2)
                settings.Title_Format.Alignment = StringAlignment.Far;
            else
                settings.Title_Format.Alignment = StringAlignment.Center;
        }
        private void firstSentences_btnFont_Click(object sender, EventArgs e)
        {
            var fd = new FontDialog();
            fd.Font = settings.FirstSentences_Font;

            if (fd.ShowDialog() == DialogResult.OK)
                settings.FirstSentences_Font = fd.Font;
        }
        private void firstSentences_cboAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstSentences_cboAlign.SelectedIndex == 0)
                settings.FirstSentences_Format.Alignment = StringAlignment.Near;
            else if (firstSentences_cboAlign.SelectedIndex == 2)
                settings.FirstSentences_Format.Alignment = StringAlignment.Far;
            else
                settings.FirstSentences_Format.Alignment = StringAlignment.Center;
        }
        private void content_btnHeaderFont_Click(object sender, EventArgs e)
        {
            var fd = new FontDialog();
            fd.Font = settings.Content_HeaderFont;

            if (fd.ShowDialog() == DialogResult.OK)
                settings.Content_HeaderFont = fd.Font;
        }
        private void content_btnDataFont_Click(object sender, EventArgs e)
        {
            var fd = new FontDialog();
            fd.Font = settings.Content_Font;

            if (fd.ShowDialog() == DialogResult.OK)
                settings.Content_Font = fd.Font;
        }
        private void content_cboAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (content_cboAlign.SelectedIndex == 0)
                settings.Content_GridFormat.Alignment = StringAlignment.Near;
            else if (content_cboAlign.SelectedIndex == 2)
                settings.Content_GridFormat.Alignment = StringAlignment.Far;
            else
                settings.Content_GridFormat.Alignment = StringAlignment.Center;
        }
        private void grdSetupHeaders_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                var colName = grdSetupHeaders.Columns[e.ColumnIndex].Name;
                if (colName == "HeaderWidth")
                {
                    if (!int.TryParse(e.FormattedValue.ToString(), out int tmp) || tmp <= 0)
                    {
                        grdSetupHeaders.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                        e.Cancel = true;
                    }
                    else
                    {
                        grdSetupHeaders.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("err");
            }
        }
        private void footer_btnFont_Click(object sender, EventArgs e)
        {
            var fd = new FontDialog();
            fd.Font = settings.Footer_Font;

            if (fd.ShowDialog() == DialogResult.OK)
                settings.Footer_Font = fd.Font;
        }
        private void footer_cboAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (footer_cboAlign.SelectedIndex == 0)
                settings.Footer_Format.Alignment = StringAlignment.Near;
            else if (footer_cboAlign.SelectedIndex == 2)
                settings.Footer_Format.Alignment = StringAlignment.Far;
            else
                settings.Footer_Format.Alignment = StringAlignment.Center;
        }
        private void footer_cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //0. #
            //1. Page #
            //2. Page #|#
            //3. Page # of #
            //4. Trang #
            //5. Trang #|#

            switch (footer_cboType.SelectedIndex)
            {
                case 0:
                    settings.Footer_TextPattern = "{0}";
                    break;
                case 1:
                    settings.Footer_TextPattern = "Page {0}";
                    break;
                case 2:
                    settings.Footer_TextPattern = "Page {0}|{1}";
                    break;
                case 3:
                    settings.Footer_TextPattern = "Page {0} of {1}";
                    break;
                case 4:
                    settings.Footer_TextPattern = "Trang {0}";
                    break;
                case 5:
                    settings.Footer_TextPattern = "Trang {0}|{1}";
                    break;
                default:
                    settings.Footer_TextPattern = "{0}";
                    break;
            }
        }        
        private void others_PageType_CheckedChanged(object sender, EventArgs e)
        {
            settings.Page_Lanscape = others_rdLanscape.Checked;
        }
        private void btnLoadSettings_Click(object sender, EventArgs e)
        {
            try
            {
                var folderPath = string.Format("{0}\\{1}", Path.GetDirectoryName(Application.ExecutablePath), VS_Helper.DefaultPrintSetupFileFolder);
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                var ofd = new OpenFileDialog() { InitialDirectory = folderPath };
                ofd.Title = "Chọn file cài đặt";
                ofd.Filter = "All files (*.*) | *.print";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string fileName = ofd.FileName;
                    string extesion = Path.GetExtension(fileName);
                    switch (extesion)
                    {
                        case ".print":
                            var data = VS_Helper.ReadDataFromFile<VS_PrintSettings>(fileName);
                            ParseSettingsData(data);
                            break;
                        default:
                            MessageBox.Show("Đuôi file mở không đúng định dạng");
                            break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đọc thiết lập in lỗi");
            }
        }
        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                var folderPath = string.Format("{0}\\{1}", Path.GetDirectoryName(Application.ExecutablePath), VS_Helper.DefaultPrintSetupFileFolder);
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                var sfd = new SaveFileDialog() { InitialDirectory = folderPath };
                sfd.Title = "Lưu thiết lập ra file";
                sfd.Filter = "All files (*.*) | *.print";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string fileName = sfd.FileName;
                    string extesion = Path.GetExtension(fileName);
                    switch (extesion)
                    {
                        case ".print":
                            VS_Helper.WriteDataToFile(fileName, WrapPrintSettings());
                            break;
                        default:
                            MessageBox.Show("Đuôi file lưu không đúng định dạng");
                            break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lưu thiết lập in lỗi");
            }
        }
        private void btnSetAsDefault_Click(object sender, EventArgs e)
        {
            try
            {
                var folderPath = string.Format("{0}\\{1}", Path.GetDirectoryName(Application.ExecutablePath), VS_Helper.DefaultPrintSetupFileFolder);
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                var ofd = new OpenFileDialog() { InitialDirectory = folderPath };
                ofd.Title = "Chọn 1 file để đặt làm thiết lập mặc định";
                ofd.Filter = "All files (*.*) | *.print";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string fileName = ofd.FileName;
                    string extesion = Path.GetExtension(fileName);
                    switch (extesion)
                    {
                        case ".print":
                            // Open App.Config of executable
                            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                            //Edit key
                            config.AppSettings.Settings[VS_Helper.AppConfigKey_PrintDefault].Value = Path.GetFileName(fileName);
                            //Save config
                            config.Save(ConfigurationSaveMode.Modified);

                            MessageBox.Show(string.Format("File {0} đã được chọn thành file cài đặt mặc định!", Path.GetFileName(fileName)));
                            break;
                        default:
                            MessageBox.Show("Đuôi file chọn không đúng định dạng");
                            break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đặt thiết lập làm mặc định lỗi");
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (printPreview.Document == null)
            {
                printPreview.Document = new PrintDocument();
                printPreview.Document.DefaultPageSettings.Landscape = settings.Page_Lanscape;
                printPreview.Document.BeginPrint += Document_BeginPrint;
                printPreview.Document.PrintPage += Document_PrintPage;
            }
            else
            {
                printPreview.Document = printPreview.Document;
                printPreview.Document.DefaultPageSettings.Landscape = settings.Page_Lanscape;
            }
        }
        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            printPreview.Zoom += 0.1f;
        }
        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            printPreview.Zoom = Math.Max(0.1f, printPreview.Zoom - 0.1f);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            pd.PrinterSettings.DefaultPageSettings.Landscape = settings.Page_Lanscape;

            if (pd.ShowDialog() == DialogResult.OK)
            {
                printPreview.Document.Print();
            }
        }
        private void btnExportToPDF_Click(object sender, EventArgs e)
        {
            PrintToPDF();
        }
        #endregion

        #region Print events handlers
        private void Document_BeginPrint(object sender, PrintEventArgs e)
        {
            try
            {
                currentPrintPageNumber = 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                PrintPrepare(e);

                //Draw page header
                if (settings.Header_Draw)
                {
                    e.Graphics.DrawString(settings.Header_Text, settings.Header_Font, Brushes.Black, settings.Header_Bounds, settings.Header_Format);
                    e.Graphics.DrawLine(Pens.Black, settings.Header_LineStartPoint, settings.Header_LineEndPoint);
                }

                //Draw page footer
                if (settings.Footer_Draw)
                {
                    var fText = string.Format(settings.Footer_TextPattern, currentPrintPageNumber, totalPageNumber);
                    e.Graphics.DrawString(fText, settings.Footer_Font, Brushes.Black, settings.Footer_Bounds, settings.Footer_Format);
                    e.Graphics.DrawLine(Pens.Black, settings.Footer_LineStartPoint, settings.Footer_LineEndPoint);
                }

                if (currentPrintPageNumber == 1)
                {
                    if (settings.Title_Draw)
                        e.Graphics.DrawString(settings.Title_Text, settings.Title_Font, Brushes.Black, settings.Title_Bounds, settings.Title_Format);

                    if (settings.FirstSentences_Draw)
                        e.Graphics.DrawString(settings.FirstSentences_Text, settings.FirstSentences_Font, Brushes.Black, settings.FirstSentences_Bounds, settings.FirstSentences_Format);

                    //Data header row
                    foreach (var cell in settings.Content_HeaderRow.Cells)
                    {
                        e.Graphics.DrawRectangle(Pens.Black, cell.Bounds.X, cell.Bounds.Y, cell.Bounds.Width, cell.Bounds.Height);
                        e.Graphics.DrawString(cell.Text, settings.Content_HeaderFont, Brushes.Black, cell.Bounds, settings.Title_Format);
                    }
                }

                //Data rows
                foreach (var row in settings.Content_DataRows)
                {
                    if (row.PageNumber < currentPrintPageNumber) continue;

                    if (row.PageNumber == currentPrintPageNumber)
                    {
                        e.HasMorePages = false;
                        foreach (var cell in row.Cells)
                        {
                            e.Graphics.DrawRectangle(Pens.Black, cell.Bounds.X, cell.Bounds.Y, cell.Bounds.Width, cell.Bounds.Height);
                            e.Graphics.DrawString(cell.Text, settings.Content_Font, Brushes.Black, cell.Bounds, settings.Title_Format);
                            
                        }
                    }
                    else
                    {
                        currentPrintPageNumber = row.PageNumber;
                        e.HasMorePages = true;
                        return;
                    }                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        #endregion

        
    }
}
