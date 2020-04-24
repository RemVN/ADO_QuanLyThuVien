using QuanLyThuVien.Core;
using QuanLyThuVien.Forms.InputForm;
using QuanLyThuVien.Forms.MuonTra;
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

        private void PhieuMuonGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowClick = phieuMuonGrid.HitTest(e.X, e.Y).RowIndex;
                if (rowClick == -1) return;
                DataGridViewRow row = phieuMuonGrid.Rows[rowClick];
                string id = ((int)row.Cells[0].Value).ToString();
                EContextMenu eContextMenu = new EContextMenu(this, new Action(delegate
                {
                    InputPhieuMuonForm form = new InputPhieuMuonForm(false);
                    form.withID(id);
                    form.withDataRow(row);
                    form.ShowDialog();
                }));
                eContextMenu.menuStrip.Show(phieuMuonGrid, new Point(e.X, e.Y));
            }
        }

        private void ButtonTraSach_Click(object sender, EventArgs e)
        {
            new TraSachForm().ShowDialog();
        }
    }
}
