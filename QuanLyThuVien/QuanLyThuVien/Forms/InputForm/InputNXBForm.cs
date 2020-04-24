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
    public partial class InputNXBForm : InputForm
    {
        Main main = Program.getMain();

        public InputNXBForm(bool isAdd) : base(isAdd, "getAllNXB", Program.MainForm.BookForm.nxbGrid, true)
        {
            withSelectorBindingSource(typeof(BookNXB), Program.MainForm.BookForm.bookNXBBindingSource);
            InitializeComponent();
        }

        public override void changeControlData()
        {
            base.changeControlData();

            this.buttonAdd.Text = getExecuteButtonName();
            if (!isAdd)
            {
                this.textID.Text = id;
                textNXB.Text = (string)dataGridViewRow.Cells[1].Value;
            }
        }

        public override string getName()
        {
            return isAdd ? "Thêm nhà xuất bản" : "Sửa nhà xuất bản";
        }

        public void addBookNXBToSql()
        {
            SqlCommand sqlCommand = new SqlCommand("insert into NXB (TenNXB) values (@TenNXB)", main.sqlConnection);
            sqlCommand.Parameters.Add(new SqlParameter("@TenNXB", SqlDbType.NVarChar)).Value = textNXB.Text;
            sqlCommand.ExecuteNonQuery();
        }

        public void editBookNXBToSql()
        {
            SqlCommand sqlCommand = new SqlCommand("update NXB set TenNXB = @TenNXB where MaNXB = @MaNXB", main.sqlConnection);
            sqlCommand.Parameters.Add(new SqlParameter("@TenNXB", SqlDbType.NVarChar)).Value = textNXB.Text;
            sqlCommand.Parameters.AddWithValue("@MaNXB", id);
            sqlCommand.ExecuteNonQuery();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (textNXB.Text.Length == 0)
            {
                showInputMissingMessage("Tên nhà xuất bản");
                return;
            }
            new Thread(() =>
            {
                if (isAdd)
                    addBookNXBToSql();
                else editBookNXBToSql();
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
