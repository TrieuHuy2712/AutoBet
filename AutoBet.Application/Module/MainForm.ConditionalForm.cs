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
    public static class InputConditionHandler
    {
        public static TextBox tbConditionContent;
        public static TextBox tbConditionTitle;
        public static Form mainForm;
        public static DataGridView dgvCondition;
        public static int currentID;

        #region Events component
        public static void formAutoBet_Load(object sender, EventArgs e)
        {
            BindingDataToGridView();
        }
        public static void btnConditionUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbConditionContent.Text.ToString()))
                MessageBox.Show("Yêu cầu nhập nội dung");
            else if (string.IsNullOrEmpty(tbConditionTitle.Text.ToString()))
                MessageBox.Show("Yêu cầu nhập tên điều kiện");
            else UpdateCondition();
        }

        public static void dgvCondition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get and binding data;
                DataGridViewRow row = dgvCondition.Rows[e.RowIndex];
                tbConditionTitle.Text = row.Cells["ConditionTitle"].Value.ToString();
                tbConditionContent.Text = row.Cells["ConditionContent"].Value.ToString();
                currentID = Convert.ToInt32(row.Cells["ID"].Value);
            }
        }

        public static void btnConditionSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbConditionContent.Text.ToString()))
                MessageBox.Show("Yêu cầu nhập nội dung");
            else if (string.IsNullOrEmpty(tbConditionTitle.Text.ToString()))
                MessageBox.Show("Yêu cầu nhập tên điều kiện");
            else AddCondition();
        }

        public static void btnConditionDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentID.ToString()) || currentID <= 0)
                MessageBox.Show("Chua tìm được điều kiện");
            else RemoveCondition();
        }

        #endregion

        private static void UpdateCondition()
        {
            var dieuKienMoi = new Condition
            {
                ID = currentID,
                ConditionContent = tbConditionContent.Text,
                ConditionTitle = tbConditionTitle.Text
            };
            new ConditionService().UpdateCondition(dieuKienMoi);
            BindingDataToGridView();
        }

        private static void AddCondition()
        {
            var dieuKienMoi = new Condition
            {
                ConditionContent = tbConditionContent.Text,
                ConditionTitle = tbConditionTitle.Text
            };
            new ConditionService().AddCondition(dieuKienMoi);
            BindingDataToGridView();
        }
        
        private static void RemoveCondition()
        {
            new ConditionService().RemoveCondition(currentID);
            BindingDataToGridView();
        }

        public static void BindingDataToGridView()
        {
            // Binding data
            dgvCondition.DataSource = new ConditionService().GetListCondtion();

            // Set column header
            dgvCondition.Columns[0].Visible = false;
            dgvCondition.Columns[1].HeaderText = "Tên điều kiện";
            dgvCondition.Columns[2].HeaderText = "Nội dung";

            //Resize column
            dgvCondition.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCondition.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
    }
}
