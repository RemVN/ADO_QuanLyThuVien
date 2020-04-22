using QuanLyThuVien.Forms.InputForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms
{
    public partial class PhieuMuonForm : Form
    {
        public PhieuMuonForm()
        {
            this.TopLevel = false;
            this.TopMost = true;
            InitializeComponent();
        }

        private void MuonTraForm_Load(object sender, EventArgs e)
        {
            Program.MainInstance.phieuMuonManager.resetGrid();
        }

        private void ButtonAddPhieuMuon_Click(object sender, EventArgs e)
        {
            new InputPhieuMuonForm(true).Show();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            Program.MainInstance.phieuMuonManager.refreshGrid();
        }
    }
}
