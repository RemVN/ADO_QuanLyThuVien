using QuanLyThuVien.Config;
using QuanLyThuVien.Core;
using QuanLyThuVien.CustomControl;
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
    public partial class StaffForm : Form
    {

        public StaffForm()
        {
            this.TopLevel = false;
            this.TopMost = true;
            InitializeComponent();
            initSelector();
        }

        public void initSelector()
        {
            searchSex.DataSource = Configuration.personSexes;
            searchRank.DataSource = Configuration.staffRanks;
            searchStatus.DataSource = Configuration.staffAccountStatus;
        }

        public void clearSearchInput()
        {
            searchID.Text = "";
            searchUsername.Text = "";
            searchRank.SelectedIndex = -1;
            searchStatus.SelectedIndex = -1;
            searchRealname.Text = "";
            searchBirthday.setCustomFormat(true);
            searchSex.SelectedIndex = -1;
            searchLocation.Text = "";
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            Program.getMain().staffManager.resetGrid();
        }

        private void SearchBirthday_ValueChanged(object sender, EventArgs e)
        {
            ((EDateTimePicker) sender).setCustomFormat(false);
        }

        private void SearchBirthday_KeyDown(object sender, KeyEventArgs e)
        {
            ((EDateTimePicker)sender).onKeyDown(sender, e);
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            Program.getMain().staffManager.searchNhanVien();
        }

        private void ButtonClearSearch_Click(object sender, EventArgs e)
        {
            clearSearchInput();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            Program.getMain().staffManager.refreshGrid();
        }

        private void ButtonAddStaff_Click(object sender, EventArgs e)
        {
            new InputStaffForm(true).ShowDialog();
        }

        private void StaffGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowClick = staffGrid.HitTest(e.X, e.Y).RowIndex;
                if (rowClick == -1) return;
                DataGridViewRow row = staffGrid.Rows[rowClick];
                string id = ((int)row.Cells[0].Value).ToString();
                EContextMenu eContextMenu = new EContextMenu(this, new Action(delegate
                {
                    InputStaffForm form = new InputStaffForm(false);
                    form.withID(id);
                    form.withDataRow(row);
                    form.changeControlData();
                    form.ShowDialog();
                }));
                eContextMenu.menuStrip.Show(staffGrid, new Point(e.X, e.Y));
            }
        }
    }
}
