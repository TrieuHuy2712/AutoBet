using AutoBet.Application.ScreenshotForm;
using AutoBet.Data.Enums;
using AutoBet.Data.Models;
using AutoBet.Service.ConfigurationService;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AutoBet.Application.Module
{
    public static class InputConfigurationHandler
    {
        public static ComboBox cbProvider;
        public static ComboBox cbChipType;
        public static Form mainForm;
        public static Bitmap bmp;
        public static PictureBox pbCapture;
        public static TextBox tbFolderPath;
        public static TextBox tbTableName;
        public static DataGridView gridChipData;

        public static string positionXY;
        public static string widthHeight;
        public static int currentID;
        public static bool isRecording = false;
        public static string imgPath;
        public static InformationConfiguration configuration;

        //public static System.Timers.Timer timer;
        //public static AutoItX3 autoIt;

        #region Event Handler
        public static void formAutoBet_Load(object sender, EventArgs e)
        {
            LoadProviderToComboBox();
            cbChipType.DataSource = Enum.GetNames(typeof(ConfigurationEnum));
            tbFolderPath.Text = "D:";
        }

        public static void btnRecord_Click(object sender, EventArgs e)
        {
            isRecording = true;
            MessageBox.Show("Bắt đằu ghi hình");
            //SetTimerEvent();
        }

        public static void formAutoBet_KeyDown(object sender, KeyEventArgs e)
        {
            if(isRecording && e.KeyCode == Keys.Escape)
            {
                //timer.Stop();
                isRecording = false;
                SelectArea selectArea = new SelectArea();
                selectArea.Show();
            }
        }

        public static void btnConfigurationSave_Click(object sender, EventArgs e)
        {
            if (CheckValidData())
            {
                if (!CheckChipHasBeenCreate())
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thêm ?", "Thêm cấu hình", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SaveImage();
                        MappingConfigurationData();
                        new ConfigurationService().AddConfiguration(configuration);
                        MessageBox.Show("Đã tạo thông tin thành công!");
                    }
                }
                else MessageBox.Show("Thông tin đã được tạo. Vui lòng nhấn cập nhật!");
            }
        }

        public static void btnConfigurationUpdate_Click(object sender, EventArgs e)
        {
            if (CheckValidData())
            {
                if (CheckChipHasBeenCreate())
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thêm ?", "Thêm cấu hình", MessageBoxButtons.YesNo);
                    if(dialogResult == DialogResult.Yes)
                    {
                        SaveImage();
                        MappingConfigurationData();
                        new ConfigurationService().UpdateConfiguration(configuration);
                        MessageBox.Show("Cập nhật thông tin thành công!");
                    }
                }
                else MessageBox.Show("Thông tin chưa được tạo. Vui lòng nhấn lưu!");

            }
        }

        public static void btnConfigurationSearch_(object sender, EventArgs e)
        {
            BindingDataToGridView();
        }

        public static void gridChipData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get and binding data;
                DataGridViewRow row = gridChipData.Rows[e.RowIndex];
                imgPath = row.Cells["ImageName"].Value.ToString();
                currentID = Convert.ToInt32(row.Cells["ID"].Value);
                positionXY = row.Cells["PositionXY"].Value.ToString();
                widthHeight = row.Cells["WidthHeight"].Value.ToString();
                pbCapture.ImageLocation = imgPath;
                cbChipType.SelectedIndex = Convert.ToInt32(row.Cells["ChipName"].Value);
            }
        }

        public static void btnConfigurationDelete(object sender, EventArgs e)
        {
            if (File.Exists(imgPath)) File.Delete(imgPath);
            new ConfigurationService().RemoveConfiguration(currentID);
            BindingDataToGridView();
            MessageBox.Show("Đã xóa thành công");
        }

        public static void btnCheck(object sender, EventArgs e)
        {
            Extension.Extension.GetImageRectangle(out bmp, positionXY, widthHeight);
            if (Extension.Extension.CheckImageValid(bmp, imgPath)) MessageBox.Show("Tìm thấy hình ảnh");
            else MessageBox.Show("Không tìm thấy hình ảnh");
        }

        #endregion

        #region Extend Function

        private static void SaveImage()
        {
            imgPath = @"" + tbFolderPath.Text + "/" + cbProvider.Text + "_" + cbChipType.Text + "_" + tbTableName.Text + ".bmp";
            if (File.Exists(imgPath)) File.Delete(imgPath);
            pbCapture.Image.Save(imgPath, ImageFormat.Bmp);
        }

        private static void MappingConfigurationData()
        {
            configuration = new InformationConfiguration
            {
                ID = currentID,
                LocationPath = imgPath,
                Position = positionXY,
                WidthHeight = widthHeight,
                ProviderID = new ConfigurationService().GetProviderByName(cbProvider.Text).ID,
                TableName = tbTableName.Text,
                TypeOfChip = cbChipType.SelectedIndex
            };
        }

        private static bool CheckValidData()
        {
            if (pbCapture.Image == null)
            {
                MessageBox.Show("Vui lòng chọn hình ảnh");
                return false;
            };
            if (string.IsNullOrWhiteSpace(tbFolderPath.Text))
            {
                MessageBox.Show("Vui lòng chọn đường dẫn");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbTableName.Text))
            {
                MessageBox.Show("Vui lòng chọn tên bàn");
                return false;
            }
            return true;
        }

        private static bool CheckChipHasBeenCreate()
        {
            int chipType = (int)(ConfigurationEnum)Enum.Parse(typeof(ConfigurationEnum), cbChipType.Text);
            var listConfigruation = new ConfigurationService().GetProviderName(cbProvider.Text, tbTableName.Text).
                Where(t => t.TypeOfChip == Convert.ToInt32(chipType)).FirstOrDefault();
            if (listConfigruation == null) return false;
            else return true;
        }

        private static void BindingDataToGridView()
        {
            var listConfigruation = new ConfigurationService().GetProviderName(cbProvider.Text, tbTableName.Text).Select(t => new
            {
                Binding = Enum.GetName(typeof(ConfigurationEnum), t.TypeOfChip) + "_" + t.Position + "_" + t.WidthHeight,
                ImageName = t.LocationPath,
                ID = t.ID,
                PositionXY = t.Position,
                WidthHeight = t.WidthHeight,
                ChipName = t.TypeOfChip
            }).ToList();
            gridChipData.DataSource = listConfigruation;
            gridChipData.Columns[0].HeaderText = "Danh sách thông tin";
            gridChipData.Columns[1].Visible = false;
            gridChipData.Columns[2].Visible = false;
            gridChipData.Columns[3].Visible = false;
            gridChipData.Columns[4].Visible = false;
            gridChipData.Columns[5].Visible = false;

            //Resize column
            gridChipData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridChipData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        public static void BindingImage(Int32 x, Int32 y, Int32 w, Int32 h, Size s)
        {
            Rectangle rect = new Rectangle(x, y, w, h);
            bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, s, CopyPixelOperation.SourceCopy);
            pbCapture.Image = bmp;
            positionXY = $"{x},{y}";
            widthHeight = $"{w},{h}";
        }

        public static void LoadProviderToComboBox()
        {
            var listProvider = new ConfigurationService().GetListProvider();
            cbProvider.DataSource = listProvider.Select(t => t.ProviderName).ToList();
        }
        #endregion

        //private static void SetTimerEvent()
        //{
        //    timer = new System.Timers.Timer(1000);
        //    timer.Elapsed += SetToolTipCursor;
        //    timer.Start();
        //}

        //private static void SetToolTipCursor(object sender, ElapsedEventArgs e)
        //{
        //    autoIt = new AutoItX3();
        //    autoIt.ToolTip($"Position {Cursor.Position.X},{Cursor.Position.Y} ", Cursor.Position.X, Cursor.Position.Y);
        //}
    }
}
