
using AutoBet.Service.DieuKienService;

namespace AutoBet.Application
{
    partial class formAutoBet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAutoBet));
            this.tbMenu = new System.Windows.Forms.TabControl();
            this.tPTongQuat = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTestAuto = new System.Windows.Forms.Button();
            this.btnBetAuto = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tbSession = new System.Windows.Forms.TextBox();
            this.tbNgungKhiThua = new System.Windows.Forms.TextBox();
            this.txNgungKhiThang = new System.Windows.Forms.TextBox();
            this.tbCuocToiThieu = new System.Windows.Forms.TextBox();
            this.cbDieuKien = new System.Windows.Forms.ComboBox();
            this.cbBan = new System.Windows.Forms.ComboBox();
            this.cbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tPThietLap = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.tbFolderPath = new System.Windows.Forms.TextBox();
            this.btnConfigurationCheck = new System.Windows.Forms.Button();
            this.cbChipType = new System.Windows.Forms.ComboBox();
            this.btnConfigurationSearch = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.pbCapture = new System.Windows.Forms.PictureBox();
            this.btnConfigurationRecord = new System.Windows.Forms.Button();
            this.tbTableName = new System.Windows.Forms.TextBox();
            this.cbProvider = new System.Windows.Forms.ComboBox();
            this.btnConfigurationRemove = new System.Windows.Forms.Button();
            this.btnConfigurationSave = new System.Windows.Forms.Button();
            this.btnConfigurationUpdate = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgChipData = new System.Windows.Forms.DataGridView();
            this.tPDieuKien = new System.Windows.Forms.TabPage();
            this.btnConditionDelete = new System.Windows.Forms.Button();
            this.btnConditionSave = new System.Windows.Forms.Button();
            this.btnConditionUpdate = new System.Windows.Forms.Button();
            this.dgvCondition = new System.Windows.Forms.DataGridView();
            this.tbConditionDetail = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbConditionName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.timerConfiguration = new System.Windows.Forms.Timer(this.components);
            this.tbMenu.SuspendLayout();
            this.tPTongQuat.SuspendLayout();
            this.tPThietLap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChipData)).BeginInit();
            this.tPDieuKien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondition)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMenu
            // 
            this.tbMenu.Controls.Add(this.tPTongQuat);
            this.tbMenu.Controls.Add(this.tPThietLap);
            this.tbMenu.Controls.Add(this.tPDieuKien);
            this.tbMenu.Location = new System.Drawing.Point(1, 1);
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.SelectedIndex = 0;
            this.tbMenu.Size = new System.Drawing.Size(951, 547);
            this.tbMenu.TabIndex = 0;
            // 
            // tPTongQuat
            // 
            this.tPTongQuat.Controls.Add(this.label13);
            this.tPTongQuat.Controls.Add(this.label12);
            this.tPTongQuat.Controls.Add(this.label11);
            this.tPTongQuat.Controls.Add(this.btnExit);
            this.tPTongQuat.Controls.Add(this.btnTestAuto);
            this.tPTongQuat.Controls.Add(this.btnBetAuto);
            this.tPTongQuat.Controls.Add(this.label10);
            this.tPTongQuat.Controls.Add(this.richTextBox1);
            this.tPTongQuat.Controls.Add(this.tbSession);
            this.tPTongQuat.Controls.Add(this.tbNgungKhiThua);
            this.tPTongQuat.Controls.Add(this.txNgungKhiThang);
            this.tPTongQuat.Controls.Add(this.tbCuocToiThieu);
            this.tPTongQuat.Controls.Add(this.cbDieuKien);
            this.tPTongQuat.Controls.Add(this.cbBan);
            this.tPTongQuat.Controls.Add(this.cbNhaCungCap);
            this.tPTongQuat.Controls.Add(this.label9);
            this.tPTongQuat.Controls.Add(this.label7);
            this.tPTongQuat.Controls.Add(this.label6);
            this.tPTongQuat.Controls.Add(this.label4);
            this.tPTongQuat.Controls.Add(this.label3);
            this.tPTongQuat.Controls.Add(this.label2);
            this.tPTongQuat.Controls.Add(this.label1);
            this.tPTongQuat.Location = new System.Drawing.Point(4, 25);
            this.tPTongQuat.Name = "tPTongQuat";
            this.tPTongQuat.Padding = new System.Windows.Forms.Padding(3);
            this.tPTongQuat.Size = new System.Drawing.Size(943, 518);
            this.tPTongQuat.TabIndex = 0;
            this.tPTongQuat.Text = "Tổng quát";
            this.tPTongQuat.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(715, 459);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(211, 29);
            this.label13.TabIndex = 25;
            this.label13.Text = "TỔNG CƯỢC: 800";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(504, 459);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 29);
            this.label12.TabIndex = 24;
            this.label12.Text = "WIN / LOSE: 800";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(646, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Đang chờ kết quả";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(344, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 37);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnTestAuto
            // 
            this.btnTestAuto.Location = new System.Drawing.Point(190, 398);
            this.btnTestAuto.Name = "btnTestAuto";
            this.btnTestAuto.Size = new System.Drawing.Size(119, 37);
            this.btnTestAuto.TabIndex = 21;
            this.btnTestAuto.Text = "Test Auto";
            this.btnTestAuto.UseVisualStyleBackColor = true;
            // 
            // btnBetAuto
            // 
            this.btnBetAuto.Location = new System.Drawing.Point(25, 398);
            this.btnBetAuto.Name = "btnBetAuto";
            this.btnBetAuto.Size = new System.Drawing.Size(119, 37);
            this.btnBetAuto.TabIndex = 20;
            this.btnBetAuto.Text = "Bet Auto";
            this.btnBetAuto.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(555, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(320, 29);
            this.label10.TabIndex = 19;
            this.label10.Text = "BÁO CÁO THỜI GIAN THỰC";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(491, 100);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(436, 335);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // tbSession
            // 
            this.tbSession.Location = new System.Drawing.Point(264, 333);
            this.tbSession.Name = "tbSession";
            this.tbSession.Size = new System.Drawing.Size(100, 22);
            this.tbSession.TabIndex = 17;
            // 
            // tbNgungKhiThua
            // 
            this.tbNgungKhiThua.Location = new System.Drawing.Point(264, 275);
            this.tbNgungKhiThua.Name = "tbNgungKhiThua";
            this.tbNgungKhiThua.Size = new System.Drawing.Size(100, 22);
            this.tbNgungKhiThua.TabIndex = 15;
            // 
            // txNgungKhiThang
            // 
            this.txNgungKhiThang.Location = new System.Drawing.Point(264, 225);
            this.txNgungKhiThang.Name = "txNgungKhiThang";
            this.txNgungKhiThang.Size = new System.Drawing.Size(100, 22);
            this.txNgungKhiThang.TabIndex = 14;
            // 
            // tbCuocToiThieu
            // 
            this.tbCuocToiThieu.Location = new System.Drawing.Point(264, 172);
            this.tbCuocToiThieu.Name = "tbCuocToiThieu";
            this.tbCuocToiThieu.Size = new System.Drawing.Size(100, 22);
            this.tbCuocToiThieu.TabIndex = 12;
            // 
            // cbDieuKien
            // 
            this.cbDieuKien.FormattingEnabled = true;
            this.cbDieuKien.Location = new System.Drawing.Point(264, 124);
            this.cbDieuKien.Name = "cbDieuKien";
            this.cbDieuKien.Size = new System.Drawing.Size(199, 24);
            this.cbDieuKien.TabIndex = 11;
            // 
            // cbBan
            // 
            this.cbBan.FormattingEnabled = true;
            this.cbBan.Location = new System.Drawing.Point(264, 75);
            this.cbBan.Name = "cbBan";
            this.cbBan.Size = new System.Drawing.Size(199, 24);
            this.cbBan.TabIndex = 10;
            // 
            // cbNhaCungCap
            // 
            this.cbNhaCungCap.FormattingEnabled = true;
            this.cbNhaCungCap.Location = new System.Drawing.Point(264, 27);
            this.cbNhaCungCap.Name = "cbNhaCungCap";
            this.cbNhaCungCap.Size = new System.Drawing.Size(199, 24);
            this.cbNhaCungCap.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Số ván giữ SESSION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tạm dừng khi thua";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tạm dừng khi thắng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số tiền cược tối thiểu trên bàn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chọn điều kiện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn Bàn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Nhà Cung Cấp";
            // 
            // tPThietLap
            // 
            this.tPThietLap.Controls.Add(this.label17);
            this.tPThietLap.Controls.Add(this.tbFolderPath);
            this.tPThietLap.Controls.Add(this.btnConfigurationCheck);
            this.tPThietLap.Controls.Add(this.cbChipType);
            this.tPThietLap.Controls.Add(this.btnConfigurationSearch);
            this.tPThietLap.Controls.Add(this.label16);
            this.tPThietLap.Controls.Add(this.pbCapture);
            this.tPThietLap.Controls.Add(this.btnConfigurationRecord);
            this.tPThietLap.Controls.Add(this.tbTableName);
            this.tPThietLap.Controls.Add(this.cbProvider);
            this.tPThietLap.Controls.Add(this.btnConfigurationRemove);
            this.tPThietLap.Controls.Add(this.btnConfigurationSave);
            this.tPThietLap.Controls.Add(this.btnConfigurationUpdate);
            this.tPThietLap.Controls.Add(this.label15);
            this.tPThietLap.Controls.Add(this.label14);
            this.tPThietLap.Controls.Add(this.dgChipData);
            this.tPThietLap.Location = new System.Drawing.Point(4, 25);
            this.tPThietLap.Name = "tPThietLap";
            this.tPThietLap.Padding = new System.Windows.Forms.Padding(3);
            this.tPThietLap.Size = new System.Drawing.Size(943, 518);
            this.tPThietLap.TabIndex = 1;
            this.tPThietLap.Text = "Thiết Lập";
            this.tPThietLap.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(548, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 20);
            this.label17.TabIndex = 23;
            this.label17.Text = "Đường dẫn";
            // 
            // tbFolderPath
            // 
            this.tbFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFolderPath.Location = new System.Drawing.Point(652, 25);
            this.tbFolderPath.Multiline = true;
            this.tbFolderPath.Name = "tbFolderPath";
            this.tbFolderPath.Size = new System.Drawing.Size(210, 28);
            this.tbFolderPath.TabIndex = 22;
            // 
            // btnConfigurationCheck
            // 
            this.btnConfigurationCheck.Location = new System.Drawing.Point(751, 193);
            this.btnConfigurationCheck.Name = "btnConfigurationCheck";
            this.btnConfigurationCheck.Size = new System.Drawing.Size(111, 38);
            this.btnConfigurationCheck.TabIndex = 21;
            this.btnConfigurationCheck.Text = "Kiểm tra";
            this.btnConfigurationCheck.UseVisualStyleBackColor = true;
            // 
            // cbChipType
            // 
            this.cbChipType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChipType.FormattingEnabled = true;
            this.cbChipType.Location = new System.Drawing.Point(246, 126);
            this.cbChipType.Name = "cbChipType";
            this.cbChipType.Size = new System.Drawing.Size(255, 26);
            this.cbChipType.TabIndex = 20;
            // 
            // btnConfigurationSearch
            // 
            this.btnConfigurationSearch.Location = new System.Drawing.Point(12, 193);
            this.btnConfigurationSearch.Name = "btnConfigurationSearch";
            this.btnConfigurationSearch.Size = new System.Drawing.Size(110, 39);
            this.btnConfigurationSearch.TabIndex = 19;
            this.btnConfigurationSearch.Text = "Tìm kiếm";
            this.btnConfigurationSearch.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 126);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 20);
            this.label16.TabIndex = 18;
            this.label16.Text = "Lựa chọn hình ảnh";
            // 
            // pbCapture
            // 
            this.pbCapture.Location = new System.Drawing.Point(552, 86);
            this.pbCapture.Name = "pbCapture";
            this.pbCapture.Size = new System.Drawing.Size(143, 146);
            this.pbCapture.TabIndex = 17;
            this.pbCapture.TabStop = false;
            // 
            // btnConfigurationRecord
            // 
            this.btnConfigurationRecord.Location = new System.Drawing.Point(751, 86);
            this.btnConfigurationRecord.Name = "btnConfigurationRecord";
            this.btnConfigurationRecord.Size = new System.Drawing.Size(111, 38);
            this.btnConfigurationRecord.TabIndex = 16;
            this.btnConfigurationRecord.Text = "Ghi hình";
            this.btnConfigurationRecord.UseVisualStyleBackColor = true;
            // 
            // tbTableName
            // 
            this.tbTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTableName.Location = new System.Drawing.Point(246, 76);
            this.tbTableName.Name = "tbTableName";
            this.tbTableName.Size = new System.Drawing.Size(255, 24);
            this.tbTableName.TabIndex = 9;
            // 
            // cbProvider
            // 
            this.cbProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProvider.FormattingEnabled = true;
            this.cbProvider.Location = new System.Drawing.Point(246, 27);
            this.cbProvider.Name = "cbProvider";
            this.cbProvider.Size = new System.Drawing.Size(255, 26);
            this.cbProvider.TabIndex = 8;
            // 
            // btnConfigurationRemove
            // 
            this.btnConfigurationRemove.Location = new System.Drawing.Point(391, 193);
            this.btnConfigurationRemove.Name = "btnConfigurationRemove";
            this.btnConfigurationRemove.Size = new System.Drawing.Size(110, 39);
            this.btnConfigurationRemove.TabIndex = 7;
            this.btnConfigurationRemove.Text = "Xóa";
            this.btnConfigurationRemove.UseVisualStyleBackColor = true;
            // 
            // btnConfigurationSave
            // 
            this.btnConfigurationSave.Location = new System.Drawing.Point(139, 193);
            this.btnConfigurationSave.Name = "btnConfigurationSave";
            this.btnConfigurationSave.Size = new System.Drawing.Size(110, 39);
            this.btnConfigurationSave.TabIndex = 6;
            this.btnConfigurationSave.Text = "Lưu";
            this.btnConfigurationSave.UseVisualStyleBackColor = true;
            // 
            // btnConfigurationUpdate
            // 
            this.btnConfigurationUpdate.Location = new System.Drawing.Point(264, 193);
            this.btnConfigurationUpdate.Name = "btnConfigurationUpdate";
            this.btnConfigurationUpdate.Size = new System.Drawing.Size(110, 39);
            this.btnConfigurationUpdate.TabIndex = 5;
            this.btnConfigurationUpdate.Text = "Sửa";
            this.btnConfigurationUpdate.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Tên Bàn";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(183, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Lựa chọn nhà cung cấp";
            // 
            // dgChipData
            // 
            this.dgChipData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChipData.Location = new System.Drawing.Point(8, 270);
            this.dgChipData.Name = "dgChipData";
            this.dgChipData.RowHeadersWidth = 51;
            this.dgChipData.RowTemplate.Height = 24;
            this.dgChipData.Size = new System.Drawing.Size(929, 242);
            this.dgChipData.TabIndex = 0;
            // 
            // tPDieuKien
            // 
            this.tPDieuKien.Controls.Add(this.btnConditionDelete);
            this.tPDieuKien.Controls.Add(this.btnConditionSave);
            this.tPDieuKien.Controls.Add(this.btnConditionUpdate);
            this.tPDieuKien.Controls.Add(this.dgvCondition);
            this.tPDieuKien.Controls.Add(this.tbConditionDetail);
            this.tPDieuKien.Controls.Add(this.label19);
            this.tPDieuKien.Controls.Add(this.tbConditionName);
            this.tPDieuKien.Controls.Add(this.label18);
            this.tPDieuKien.Location = new System.Drawing.Point(4, 25);
            this.tPDieuKien.Name = "tPDieuKien";
            this.tPDieuKien.Padding = new System.Windows.Forms.Padding(3);
            this.tPDieuKien.Size = new System.Drawing.Size(943, 518);
            this.tPDieuKien.TabIndex = 2;
            this.tPDieuKien.Text = "Điều kiện";
            this.tPDieuKien.UseVisualStyleBackColor = true;
            // 
            // btnConditionDelete
            // 
            this.btnConditionDelete.Location = new System.Drawing.Point(322, 179);
            this.btnConditionDelete.Name = "btnConditionDelete";
            this.btnConditionDelete.Size = new System.Drawing.Size(113, 36);
            this.btnConditionDelete.TabIndex = 7;
            this.btnConditionDelete.Text = "Xóa";
            this.btnConditionDelete.UseVisualStyleBackColor = true;
            // 
            // btnConditionSave
            // 
            this.btnConditionSave.Location = new System.Drawing.Point(174, 179);
            this.btnConditionSave.Name = "btnConditionSave";
            this.btnConditionSave.Size = new System.Drawing.Size(113, 36);
            this.btnConditionSave.TabIndex = 6;
            this.btnConditionSave.Text = "Lưu";
            this.btnConditionSave.UseVisualStyleBackColor = true;
            // 
            // btnConditionUpdate
            // 
            this.btnConditionUpdate.Location = new System.Drawing.Point(30, 179);
            this.btnConditionUpdate.Name = "btnConditionUpdate";
            this.btnConditionUpdate.Size = new System.Drawing.Size(113, 36);
            this.btnConditionUpdate.TabIndex = 5;
            this.btnConditionUpdate.Text = "Sửa";
            this.btnConditionUpdate.UseVisualStyleBackColor = true;
            // 
            // dgvCondition
            // 
            this.dgvCondition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCondition.Location = new System.Drawing.Point(30, 235);
            this.dgvCondition.Name = "dgvCondition";
            this.dgvCondition.RowHeadersWidth = 51;
            this.dgvCondition.RowTemplate.Height = 24;
            this.dgvCondition.Size = new System.Drawing.Size(861, 260);
            this.dgvCondition.TabIndex = 4;
            // 
            // tbConditionDetail
            // 
            this.tbConditionDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConditionDetail.Location = new System.Drawing.Point(30, 133);
            this.tbConditionDetail.Multiline = true;
            this.tbConditionDetail.Name = "tbConditionDetail";
            this.tbConditionDetail.Size = new System.Drawing.Size(861, 27);
            this.tbConditionDetail.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(27, 100);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(146, 20);
            this.label19.TabIndex = 2;
            this.label19.Text = "Nội dung điều kiện";
            // 
            // tbConditionName
            // 
            this.tbConditionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConditionName.Location = new System.Drawing.Point(30, 49);
            this.tbConditionName.Multiline = true;
            this.tbConditionName.Name = "tbConditionName";
            this.tbConditionName.Size = new System.Drawing.Size(226, 27);
            this.tbConditionName.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(26, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "Tên điều kiện";
            // 
            // formAutoBet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 558);
            this.Controls.Add(this.tbMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "formAutoBet";
            this.Text = "AUTO BET";
            this.tbMenu.ResumeLayout(false);
            this.tPTongQuat.ResumeLayout(false);
            this.tPTongQuat.PerformLayout();
            this.tPThietLap.ResumeLayout(false);
            this.tPThietLap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChipData)).EndInit();
            this.tPDieuKien.ResumeLayout(false);
            this.tPDieuKien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbMenu;
        private System.Windows.Forms.TabPage tPTongQuat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tPThietLap;
        private System.Windows.Forms.TabPage tPDieuKien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTestAuto;
        private System.Windows.Forms.Button btnBetAuto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox tbSession;
        private System.Windows.Forms.TextBox tbNgungKhiThua;
        private System.Windows.Forms.TextBox txNgungKhiThang;
        private System.Windows.Forms.TextBox tbCuocToiThieu;
        private System.Windows.Forms.ComboBox cbDieuKien;
        private System.Windows.Forms.ComboBox cbBan;
        private System.Windows.Forms.ComboBox cbNhaCungCap;
        private System.Windows.Forms.Button btnConfigurationRecord;
        private System.Windows.Forms.TextBox tbTableName;
        private System.Windows.Forms.ComboBox cbProvider;
        private System.Windows.Forms.Button btnConfigurationRemove;
        private System.Windows.Forms.Button btnConfigurationSave;
        private System.Windows.Forms.Button btnConfigurationUpdate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgChipData;
        private System.Windows.Forms.Button btnConditionDelete;
        private System.Windows.Forms.Button btnConditionSave;
        private System.Windows.Forms.Button btnConditionUpdate;
        private System.Windows.Forms.DataGridView dgvCondition;
        private System.Windows.Forms.TextBox tbConditionDetail;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbConditionName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnConfigurationCheck;
        private System.Windows.Forms.ComboBox cbChipType;
        private System.Windows.Forms.Button btnConfigurationSearch;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pbCapture;
        private System.Windows.Forms.Timer timerConfiguration;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbFolderPath;
    }
}

