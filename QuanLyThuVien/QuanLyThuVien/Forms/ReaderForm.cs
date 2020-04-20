using QuanLyThuVien.Config;
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

        private void ButtonAddBook_Click(object sender, EventArgs e)
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
    }
}
