using AutoBet.Data;
using AutoBet.Service.DieuKienService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBet.Application.Module
{
    public static class InputDieuKienHandler
    {
        public static TextBox tbNoiDung;
        public static TextBox tbTenDieuKien;
        public static Form mainForm;
        public static DataGridView dgvDieuKien;
        public static int currentID;

        #region Events component
        public static void formAutoBet_Load(object sender, EventArgs e)
        {
            BindingDataToGridView();
        }
        public static void btnSuaDieuKien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNoiDung.Text.ToString()))
                MessageBox.Show("Yêu cầu nhập nội dung");
            else if (string.IsNullOrEmpty(tbTenDieuKien.Text.ToString()))
                MessageBox.Show("Yêu cầu nhập tên điều kiện");
            else UpdateDieuKien();
        }

        public static void dgvDieuKien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get and binding data;
                DataGridViewRow row = dgvDieuKien.Rows[e.RowIndex];
                tbTenDieuKien.Text = row.Cells["TenDieuKien"].Value.ToString();
                tbNoiDung.Text = row.Cells["NoiDung"].Value.ToString();
                currentID = Convert.ToInt32(row.Cells["ID"].Value);
            }
        }

        public static void btnLuuDK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNoiDung.Text.ToString()))
                MessageBox.Show("Yêu cầu nhập nội dung");
            else if (string.IsNullOrEmpty(tbTenDieuKien.Text.ToString()))
                MessageBox.Show("Yêu cầu nhập tên điều kiện");
            else ThemDieuKien();
        }

        public static void btnXoaDK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentID.ToString()) || currentID <= 0)
                MessageBox.Show("Chua tìm được điều kiện");
            else XoaDieuKien();
        }

        #endregion

        private static void UpdateDieuKien()
        {
            var dieuKienMoi = new DieuKien
            {
                ID = currentID,
                NoiDung = tbNoiDung.Text,
                TenDieuKien = tbTenDieuKien.Text
            };
            new DieuKienService().SuaDieuKien(dieuKienMoi);
            BindingDataToGridView();
        }

        private static void ThemDieuKien()
        {
            var dieuKienMoi = new DieuKien
            {
                NoiDung = tbNoiDung.Text,
                TenDieuKien = tbTenDieuKien.Text
            };
            new DieuKienService().ThemDieuKien(dieuKienMoi);
            BindingDataToGridView();
        }
        
        private static void XoaDieuKien()
        {
            new DieuKienService().XoaDieuKien(currentID);
            BindingDataToGridView();
        }

        public static void BindingDataToGridView()
        {
            // Binding data
            dgvDieuKien.DataSource = new DieuKienService().DanhSachDieuKien();

            // Set column header
            dgvDieuKien.Columns[0].Visible = false;
            dgvDieuKien.Columns[1].HeaderText = "Tên điều kiện";
            dgvDieuKien.Columns[2].HeaderText = "Nội dung";

            //Resize column
            dgvDieuKien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDieuKien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
    }
}
