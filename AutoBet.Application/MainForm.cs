using AutoBet.Application.Module;
using AutoBet.Data;
using AutoBet.Service.DieuKienService;
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
            Initialize_DieuKienInputs();
        }

        void Initialize_DieuKienInputs()
        {
            InputDieuKienHandler.mainForm = this;
            InputDieuKienHandler.tbNoiDung = tbNoiDung;
            InputDieuKienHandler.tbTenDieuKien = tbTenDieuKien;
            InputDieuKienHandler.dgvDieuKien = dgvDieuKien;
            // Form
            this.Load += InputDieuKienHandler.formAutoBet_Load;

            // Data grid view
            dgvDieuKien.Font = new Font("Tahoma", 8);
            dgvDieuKien.CellClick += InputDieuKienHandler.dgvDieuKien_CellContentClick;

            // Another button
            btnSuaDieuKien.Click += InputDieuKienHandler.btnSuaDieuKien_Click;
            btnLuuDK.Click += InputDieuKienHandler.btnLuuDK_Click;
            btnXoaDK.Click += InputDieuKienHandler.btnXoaDK_Click;

        }
    }
}
