using AutoBet.Application.Module;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutoBet.Application
{
    public partial class formAutoBet : Form
    {
        public formAutoBet()
        {
            InitializeComponent();
            Initialize_ConfigurationInputs();
            Initialize_ConditionInputs();
            Initialize_GeneralInputs();
        }

        void Initialize_ConditionInputs()
        {
            InputConditionHandler.mainForm = this;
            InputConditionHandler.tbConditionContent = tbConditionDetail;
            InputConditionHandler.tbConditionTitle = tbConditionName;
            InputConditionHandler.dgvCondition = dgvCondition;
            // Form
            this.Load += InputConditionHandler.formAutoBet_Load;

            // Data grid view
            dgvCondition.Font = new Font("Tahoma", 8);
            dgvCondition.CellClick += InputConditionHandler.dgvCondition_CellContentClick;

            // Another button
            btnConditionUpdate.Click += InputConditionHandler.btnConditionUpdate_Click;
            btnConditionSave.Click += InputConditionHandler.btnConditionSave_Click;
            btnConditionDelete.Click += InputConditionHandler.btnConditionDelete_Click;

        }

        void Initialize_ConfigurationInputs()
        {
            InputConfigurationHandler.mainForm = this;
            InputConfigurationHandler.cbProvider = cbProvider;
            InputConfigurationHandler.pbCapture = pbCapture;
            InputConfigurationHandler.tbFolderPath = tbFolderPath;
            InputConfigurationHandler.cbChipType = cbChipType;
            InputConfigurationHandler.tbTableName = tbTableName;
            InputConfigurationHandler.gridChipData = dgChipData;
            //Form
            Load += InputConfigurationHandler.formAutoBet_Load;
            this.KeyDown += InputConfigurationHandler.formAutoBet_KeyDown;
            this.btnConfigurationRecord.Click += InputConfigurationHandler.btnRecord_Click;
            this.btnConfigurationSave.Click += InputConfigurationHandler.btnConfigurationSave_Click;
            this.btnConfigurationUpdate.Click += InputConfigurationHandler.btnConfigurationUpdate_Click;
            this.btnConfigurationSearch.Click += InputConfigurationHandler.btnConfigurationSearch_;
            this.dgChipData.CellClick += InputConfigurationHandler.gridChipData_CellContentClick;
            btnConfigurationRemove.Click += InputConfigurationHandler.btnConfigurationDelete;
            this.btnConfigurationCheck.Click += InputConfigurationHandler.btnCheck;
        }

        void Initialize_GeneralInputs()
        {
            InputGeneralHandler.mainForm = this;
            InputGeneralHandler.cbTable = cbBan;
            InputGeneralHandler.cbProvider = cbNhaCungCap;
            InputGeneralHandler.cbCondition = cbDieuKien;
            InputGeneralHandler.stopLose = txNgungKhiThang;
            InputGeneralHandler.stopWin = tbNgungKhiThua;
            InputGeneralHandler.rtbLogResult = richTextBox1;
            InputGeneralHandler.tpTongQuat = tPTongQuat;

            Load += InputGeneralHandler.formAutoBet_Load;
            cbNhaCungCap.SelectedIndexChanged += InputGeneralHandler.cbProvider_SelectedIndexChanged;
            cbDieuKien.SelectedIndexChanged += InputGeneralHandler.cbCondition_SelectedIndexChanged;
            cbBan.SelectedIndexChanged += InputGeneralHandler.cbTable_SelectedIndexChanged;
            btnBetAuto.Click += InputGeneralHandler.btnBetAuto_Click;
            tbMenu.Selected += InputGeneralHandler.tbMenu_Selected;
            btnExit.Click += InputGeneralHandler.btnExit_Click;
        }
    }
}
