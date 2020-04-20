using QuanLyThuVien.Config;
using QuanLyThuVien.Core;
using QuanLyThuVien.Forms.InputForm;
using QuanLyThuVien.Utils;
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
    public partial class ReaderForm : Form
    {
        public ReaderForm() 
        {
            InitializeComponent();
            this.TopLevel = false;
            this.TopMost = true;
            searchSex.DataSource = Configuration.personSexes;
        }

        public void clearInputSearch()
        {
            InputCleaner.clearInputs(searchID, searchKhoa, searchClass, searchNgayCap, searchHetHan, searchRealname, searchBirthday, searchSex, searchSDT, searchLocation);
        }

        private void ButtonSearchKhoa(object sender, EventArgs e)
        {
            Program.MainInstance.readerManager.searchReader();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            Program.MainInstance.readerManager.refreshGrid();
        }

        private void ButtonClearSearch_Click(object sender, EventArgs e)
        {
            clearInputSearch();
        }

        private void ReaderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet9.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.quanLyThuVienDataSet9.Lop);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet8.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.quanLyThuVienDataSet8.Khoa);

        }

        private void ButtonAddKhoa_Click(object sender, EventArgs e)
        {
            new InputKhoaForm(true).Show();
        }

        private void ButtonAddReader_Click(object sender, EventArgs e)
        {

        }

        private void KhoaGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowClick = khoaGrid.HitTest(e.X, e.Y).RowIndex;
                if (rowClick == -1) return;
                DataGridViewRow row = khoaGrid.Rows[rowClick];
                string id = ((int)row.Cells[0].Value).ToString();
                EContextMenu eContextMenu = new EContextMenu(this, new Action(delegate
                {
                    InputKhoaForm form = new InputKhoaForm(false);
                    form.withID(id);
                    form.withDataRow(row);
                    form.changeControlData();
                    form.ShowDialog();
                }));
                eContextMenu.menuStrip.Show(khoaGrid, new Point(e.X, e.Y));
            }
        }
    }
}
