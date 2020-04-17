using QuanLyThuVien.BookDetails;
using QuanLyThuVien.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms.InputForm
{
    public partial class InputBookForm : InputForm
    {
        Main main = Program.getMain();

        public InputBookForm(bool isAdd) : base(isAdd, "", Program.getMain().BookForm.tacGiaGrid, true)
        {
            InitializeComponent();
            comboStatus.DataSource = Configuration.statusList;
            comboAuthor.DataSource = main.BookForm.bookAuthorBindingSource;
            comboNXB.DataSource = main.BookForm.bookNXBBindingSource;
            comboType.DataSource = main.BookForm.bookTypeBindingSource;
            comboLocation.DataSource = main.BookForm.bookLocationBindingSource;
        }

        public override void renameControl()
        {
            base.renameControl();
            this.buttonAdd.Text = getExecuteButtonName();
            if (!isAdd)
            {
                this.textID.Text = id;
                this.textName.Text = (string)dataGridViewRow.Cells[1].Value;
                this.comboStatus.SelectedIndex = comboStatus.FindStringExact((string)dataGridViewRow.Cells[2].Value);
                this.numYear.Value = (int)dataGridViewRow.Cells[3].Value;
                this.numPrice.Value = new decimal((double)dataGridViewRow.Cells[4].Value);
                this.comboType.SelectedIndex = comboType.FindStringExact((string)dataGridViewRow.Cells[5].Value);
                this.comboLocation.SelectedIndex = comboLocation.FindStringExact((string)dataGridViewRow.Cells[6].Value);
                this.comboNXB.SelectedIndex = comboNXB.FindStringExact((string)dataGridViewRow.Cells[7].Value);
                this.comboAuthor.SelectedIndex = comboAuthor.FindStringExact((string)dataGridViewRow.Cells[8].Value);
            }
        }

        public override string getName()
        {
            return isAdd ? "Thêm sách" : "Sửa sách";
        }

        public void editAuthorToSQL()
        {
            SqlCommand sqlCommand = new SqlCommand("update Sach set MaLoaiSach = @MaLoaiSach, MaViTri = @MaViTri, @MaNXB = MaNXB, MaTG = @MaTG, TenSach = @TenSach, TinhTrang = @TinhTrang, NamXB = @NamXB, GiaSach = @GiaSach where MaSach = @MaSach", main.sqlConnection);
            this.Invoke(new Action(delegate
            {
                sqlCommand.Parameters.AddWithValue("@MaSach", id);
                sqlCommand.Parameters.AddWithValue("@MaLoaiSach", comboType.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@MaViTri", comboLocation.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@MaNXB", comboNXB.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@MaTG", comboAuthor.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@TenSach", textName.Text);
                sqlCommand.Parameters.AddWithValue("@NamXB", (int)numYear.Value);
                sqlCommand.Parameters.AddWithValue("@GiaSach", (float)numPrice.Value);
                sqlCommand.Parameters.AddWithValue("@TinhTrang", comboStatus.SelectedValue);
            }));
            sqlCommand.ExecuteNonQuery();
        }

        public void addAuthorToSQL()
        {
            SqlCommand sqlCommand = new SqlCommand("insert into TacGia (TenTacGia, SDT) values (@TenTG, @SDT)", main.sqlConnection);
            sqlCommand.ExecuteNonQuery();
        }

        public override void refresh()
        {
            main.bookManager.defaultLoad();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (textName.Text.Length == 0)
            {
                showInputMissingMessage("Tên sách");
                return;
            }
            new Thread(() =>
            {
                if (isAdd)
                    addAuthorToSQL();
                else editAuthorToSQL();

                refresh();
                closeForm();
            }).Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InputBookForm_Load(object sender, EventArgs e)
        {

        }
    }
}
