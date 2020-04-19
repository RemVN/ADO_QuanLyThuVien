using QuanLyThuVien.Config;
using QuanLyThuVien.Core;
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
    public partial class BookForm : Form
    {

        public BookForm()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.TopMost = true;
            this.searchBookStatus.DataSource = Configuration.statusList;
            this.searchMuonTra.DataSource = Configuration.muonTraStatusBookSide;
        }

        public void clearSearchInput()
        {
            searchBookID.Text = "";
            searchBookName.Text = "";
            searchBookStatus.SelectedIndex = -1;
            searchBookYear.Value = 0;
            searchBookPrice.Value = 0;
            searchBookType.SelectedIndex = -1;
            searchBookLocation.SelectedIndex = -1;
            searchBookNXB.SelectedIndex = -1;
            searchBookAuthor.SelectedIndex = -1;
            searchMuonTra.SelectedIndex = -1;
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet4.ViTri' table. You can move, or remove it, as needed.
            this.viTriTableAdapter.Fill(this.viTriDataSet.ViTri);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet3.NXB' table. You can move, or remove it, as needed.
            this.nXBTableAdapter.Fill(this.nxbDataSet.NXB);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet2.LoaiSach' table. You can move, or remove it, as needed.
            this.loaiSachTableAdapter.Fill(this.loaiSachDataSet.LoaiSach);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.TacGia' table. You can move, or remove it, as needed.
            this.tacGiaTableAdapter.Fill(this.tacGiaDataSet.TacGia);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CaNhan' table. You can move, or remove it, as needed.
            Program.getMain().bookManager.resetGrid();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            Program.getMain().bookManager.searchBook();
        }

        private void ButtonAddTacGia_Click(object sender, EventArgs e)
        {
            new InputAuthorForm(true).ShowDialog();
        }

        private void ButtonAddBookType_Click(object sender, EventArgs e)
        {
            new InputBookTypeForm(true).ShowDialog();
        }

        private void ButtonAddNXB_Click(object sender, EventArgs e)
        {
            new InputNXBForm(true).ShowDialog();
        }

        private void ButtonAddLocation_Click(object sender, EventArgs e)
        {
            new InputLocationForm(true).ShowDialog();
        }

        private void ButtonAddBook_Click(object sender, EventArgs e)
        {
            new InputBookForm(true).ShowDialog();
        }

        private void TacGiaGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                int rowClick = tacGiaGrid.HitTest(e.X, e.Y).RowIndex;
                if (rowClick == -1) return;
                DataGridViewRow row = tacGiaGrid.Rows[rowClick];
                string id = ((int) row.Cells[0].Value).ToString();
                EContextMenu eContextMenu = new EContextMenu(this, new Action(delegate
                {
                    InputAuthorForm form = new InputAuthorForm(false);
                    form.withID(id);
                    form.withDataRow(row);
                    form.renameControl();
                    form.ShowDialog();
                }));
                eContextMenu.menuStrip.Show(tacGiaGrid ,new Point(e.X, e.Y));
            }
        }

        private void BookTypeGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowClick = bookTypeGrid.HitTest(e.X, e.Y).RowIndex;
                if (rowClick == -1) return;
                DataGridViewRow row = bookTypeGrid.Rows[rowClick];
                string id = ((int)row.Cells[0].Value).ToString();
                EContextMenu eContextMenu = new EContextMenu(this, new Action(delegate
                {
                    InputBookTypeForm form = new InputBookTypeForm(false);
                    form.withID(id);
                    form.withDataRow(row);
                    form.renameControl();
                    form.ShowDialog();
                }));
                eContextMenu.menuStrip.Show(bookTypeGrid, new Point(e.X, e.Y));
            }
        }

        private void NxbGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowClick = nxbGrid.HitTest(e.X, e.Y).RowIndex;
                if (rowClick == -1) return;
                DataGridViewRow row = nxbGrid.Rows[rowClick];
                string id = ((int)row.Cells[0].Value).ToString();
                EContextMenu eContextMenu = new EContextMenu(this, new Action(delegate
                {
                    InputNXBForm form = new InputNXBForm(false);
                    form.withID(id);
                    form.withDataRow(row);
                    form.renameControl();
                    form.ShowDialog();
                }));
                eContextMenu.menuStrip.Show(nxbGrid, new Point(e.X, e.Y));
            }
        }

        private void LocationGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowClick = locationGrid.HitTest(e.X, e.Y).RowIndex;
                if (rowClick == -1) return;
                DataGridViewRow row = locationGrid.Rows[rowClick];
                string id = ((int)row.Cells[0].Value).ToString();
                EContextMenu eContextMenu = new EContextMenu(this, new Action(delegate
                {
                    InputLocationForm form = new InputLocationForm(false);
                    form.withID(id);
                    form.withDataRow(row);
                    form.renameControl();
                    form.ShowDialog();
                }));
                eContextMenu.menuStrip.Show(locationGrid, new Point(e.X, e.Y));
            }
        }

        private void BookGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowClick = bookGrid.HitTest(e.X, e.Y).RowIndex;
                if (rowClick == -1) return;
                DataGridViewRow row = bookGrid.Rows[rowClick];
                string id = ((int)row.Cells[0].Value).ToString();
                EContextMenu eContextMenu = new EContextMenu(this, new Action(delegate
                {
                    InputBookForm form = new InputBookForm(false);
                    form.withID(id);
                    form.withDataRow(row);
                    form.renameControl();
                    form.ShowDialog();
                }));
                eContextMenu.menuStrip.Show(bookGrid, new Point(e.X, e.Y));
            }
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            Program.getMain().bookManager.refreshGrid();
        }

        private void ButtonClearSearch_Click(object sender, EventArgs e)
        {
            clearSearchInput();
        }
    }
}
