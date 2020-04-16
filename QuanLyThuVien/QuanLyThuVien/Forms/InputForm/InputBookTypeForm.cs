using QuanLyThuVien.BookDetails;
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
    public partial class InputBookTypeForm : InputForm 
    {

        Main main = Program.getMain();

        public InputBookTypeForm(bool isAdd) : base(isAdd, "getAllLoaiSach", Program.getMain().BookForm.bookTypeGrid, true)
        {
            withSelectorBindingSource(typeof(BookType), Program.getMain().BookForm.bookTypeBindingSource);
            InitializeComponent();
        }

        public override void renameControl()
        {
            base.renameControl();

            this.buttonAdd.Text = getExecuteButtonName();
            if(!isAdd)
            {
                this.textID.Text = id;
                textLoaiSach.Text = (string)dataGridViewRow.Cells[1].Value;
            }
        }

        public override string getName()
        {
            return isAdd ? "Thêm loại sách" : "Sửa loại sách";
        }

        public void addBookTypeToSQL()
        {
            SqlCommand sqlCommand = new SqlCommand("insert into LoaiSach (TenLoaiSach) values (@TenLoaiSach)", main.sqlConnection);
            sqlCommand.Parameters.Add(new SqlParameter("@TenLoaiSach", SqlDbType.NVarChar)).Value = textLoaiSach.Text;
            sqlCommand.ExecuteNonQuery();
        }

        public void editBookTypeToSQL()
        {
            SqlCommand sqlCommand = new SqlCommand("update LoaiSach set TenLoaiSach = @TenLoaiSach where MaLoaiSach = @MaLoaiSach", main.sqlConnection);
            sqlCommand.Parameters.Add(new SqlParameter("@TenLoaiSach", SqlDbType.NVarChar)).Value = textLoaiSach.Text;
            sqlCommand.Parameters.AddWithValue("@MaLoaiSach", id);
            sqlCommand.ExecuteNonQuery();
        }

        private void AddBookTypeForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (textLoaiSach.Text.Length == 0)
            {
                showInputMissingMessage("Tên loại sách");
                return;
            }
            new Thread(() =>
            {
                if (isAdd)
                    addBookTypeToSQL();
                else editBookTypeToSQL();
                refresh();
                closeForm();
            }).Start();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
