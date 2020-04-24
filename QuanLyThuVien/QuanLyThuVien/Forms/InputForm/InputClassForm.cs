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
    public partial class InputClassForm : InputForm
    {
        static Main main = Program.MainInstance;

        public InputClassForm(bool isAdd) : base(isAdd, "getLop", Program.MainForm.ReaderForm.classGrid, true)
        {
            withSelectorBindingSource(typeof(NameableObject), Program.MainForm.ReaderForm.classBindingSource);
            InitializeComponent();
        }

        public override void changeControlData()
        {
            base.changeControlData();

            this.buttonAdd.Text = getExecuteButtonName();
            if (!isAdd)
            {
                this.inputID.Text = id;
                inputClass.Text = (string)dataGridViewRow.Cells[1].Value;
            }
        }

        public override string getName()
        {
            return isAdd ? "Thêm lớp" : "Sửa lớp";
        }

        public void addLopToSQL()
        {
            SqlCommand sqlCommand = new SqlCommand("insert into Lop (TenLop) values (@TenLop)", main.sqlConnection);
            sqlCommand.Parameters.Add(new SqlParameter("@TenLop", SqlDbType.NVarChar)).Value = inputClass.Text;
            sqlCommand.ExecuteNonQuery();
        }

        public void editLopToSQL()
        {
            SqlCommand sqlCommand = new SqlCommand("update Lop set TenLop = @TenLop where MaLop = @MaLop", main.sqlConnection);
            sqlCommand.Parameters.Add(new SqlParameter("@TenLop", SqlDbType.NVarChar)).Value = inputClass.Text;
            sqlCommand.Parameters.AddWithValue("@MaLop", id);
            sqlCommand.ExecuteNonQuery();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (inputClass.Text.Length == 0)
            {
                showInputMissingMessage("Tên lớp");
                return;
            }
            new Thread(() =>
            {
                if (isAdd)
                    addLopToSQL();
                else editLopToSQL();
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
