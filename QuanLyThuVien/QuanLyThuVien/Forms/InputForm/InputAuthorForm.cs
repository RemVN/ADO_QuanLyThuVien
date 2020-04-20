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
    public partial class InputAuthorForm : InputForm
    {
        Main main = Program.getMain();

        public InputAuthorForm(bool isAdd) : base(isAdd, "getAllTacGia", Program.getMain().BookForm.tacGiaGrid, true)
        {
            withSelectorBindingSource(typeof(BookAuthor), Program.getMain().BookForm.bookAuthorBindingSource);
            InitializeComponent();
        }

        public override void changeControlData()
        {
            base.changeControlData();
            this.buttonAdd.Text = getExecuteButtonName();
            if(!isAdd)
            {
                this.textID.Text = id;
                textTacGia.Text = ((string)dataGridViewRow.Cells[1].Value);
                textSDT.Text = ((string)dataGridViewRow.Cells[2].Value);
            }
        }

        public override string getName()
        {
            return isAdd ? "Thêm tác giả" : "Sửa tác giả";
        }

        public void editAuthorToSQL()
        {
            SqlCommand sqlCommand = new SqlCommand("update TacGia set TenTacGia = @TenTacGia, SDT = @SDT where MaTG = @MaTG", main.sqlConnection);
            sqlCommand.Parameters.AddWithValue("@SDT", textSDT.Text);
            sqlCommand.Parameters.Add(new SqlParameter("@TenTacGia", SqlDbType.NVarChar)).Value = textTacGia.Text;
            sqlCommand.Parameters.AddWithValue("@MaTG", id);
            sqlCommand.ExecuteNonQuery();
        }

        public void addAuthorToSQL()
        {
            SqlCommand sqlCommand = new SqlCommand("insert into TacGia (TenTacGia, SDT) values (@TenTG, @SDT)", main.sqlConnection);
            sqlCommand.Parameters.Add(new SqlParameter("@TenTG", SqlDbType.NVarChar)).Value = textTacGia.Text;
            sqlCommand.Parameters.AddWithValue("@SDT", textSDT.Text);
            sqlCommand.ExecuteNonQuery();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if(textTacGia.Text.Length == 0)
            {
                showInputMissingMessage("Tên tác giả");
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
    }
}
