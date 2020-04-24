using QuanLyThuVien.Core;
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
    public partial class InputKhoaForm : InputForm
    {
        static Main main = Program.MainInstance;

        public InputKhoaForm(bool isAdd) : base(isAdd, "getKhoa", Program.MainForm.ReaderForm.khoaGrid, true)
        {
            withSelectorBindingSource(typeof(NameableObject), Program.MainForm.ReaderForm.khoaBindingSource);
            InitializeComponent();
        }

        public override void changeControlData()
        {
            base.changeControlData();

            this.buttonAdd.Text = getExecuteButtonName();
            if (!isAdd)
            {
                this.inputID.Text = id;
                inputKhoa.Text = (string)dataGridViewRow.Cells[1].Value;
            }
        }

        public override string getName()
        {
            return isAdd ? "Thêm khoa" : "Sửa khoa";
        }

        public void addKhoaToSQL()
        {
            SqlCommand sqlCommand = new SqlCommand("insert into Khoa (TenKhoa) values (@TenKhoa)", main.sqlConnection);
            sqlCommand.Parameters.Add(new SqlParameter("@TenKhoa", SqlDbType.NVarChar)).Value = inputKhoa.Text;
            sqlCommand.ExecuteNonQuery();
        }

        public void editKhoaToSQL()
        {
            SqlCommand sqlCommand = new SqlCommand("update Khoa set TenKhoa = @TenKhoa where MaKhoa = @MaKhoa", main.sqlConnection);
            sqlCommand.Parameters.Add(new SqlParameter("@TenKhoa", SqlDbType.NVarChar)).Value = inputKhoa.Text;
            sqlCommand.Parameters.AddWithValue("@MaKhoa", id);
            sqlCommand.ExecuteNonQuery();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (inputKhoa.Text.Length == 0)
            {
                showInputMissingMessage("Vị trí");
                return;
            }
            new Thread(() =>
            {
                if (isAdd)
                    addKhoaToSQL();
                else editKhoaToSQL();
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
