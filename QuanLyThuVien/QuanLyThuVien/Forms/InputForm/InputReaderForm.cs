using QuanLyThuVien.CustomControl;
using QuanLyThuVien.Utils;
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
    public partial class InputReaderForm : InputForm
    {
        static Main main = Program.MainInstance;

        public InputReaderForm(bool isAdd) : base(isAdd, "", Program.MainForm.ReaderForm.readerGrid, true)
        {
            InitializeComponent();
            inputKhoa.DataSource = Program.MainForm.ReaderForm.khoaBindingSource;
            inputClass.DataSource = Program.MainForm.ReaderForm.classBindingSource;
        }

        public override void changeControlData()
        {
            base.changeControlData();
            this.buttonAdd.Text = getExecuteButtonName();
            if (!isAdd)
            {
                inputKhoa.SelectedIndex = inputKhoa.FindStringExact((string)dataGridViewRow.Cells[1].Value);
                inputClass.SelectedIndex = inputClass.FindStringExact((string)dataGridViewRow.Cells[2].Value);
                DateTime ngayCap = (DateTime)dataGridViewRow.Cells[3].Value;
                DateTime hetHan = (DateTime)dataGridViewRow.Cells[4].Value;
                int totalDays = (hetHan - ngayCap).Days;
                inputNgayCap.Value = ngayCap;
                inputNgayCap.setCustomFormat(false);
                inputHetHan.Value = totalDays;
                inputPerson.changeControlData(dataGridViewRow, 5, id);
            }
        }

        public DateTime getNgayHetHan()
        {
            return inputNgayCap.Value.AddDays((int) inputHetHan.Value);
        }

        public override string getName()
        {
            return isAdd ? "Thêm độc giả" : "Sửa độc giả";
        }

        public void addReaderToSQL()
        {
            int id = inputPerson.addPersonToSql();
            SqlCommand sqlCommand = new SqlCommand("insert into SinhVien(MaSo, MaKhoa, MaLop, NgayCap, NgayHetHan) values (@MaSo, @MaKhoa, @MaLop, @NgayCap, @NgayHetHan)", main.sqlConnection);
            sqlCommand.Parameters.AddWithValue("@MaSo", id);
            this.Invoke(new Action(delegate
            {
                addInputParams(sqlCommand);
            }));
            sqlCommand.ExecuteNonQuery();
        }

        public void editReaderToSQL()
        {
            inputPerson.editPersonToSql(Int32.Parse(id));
            SqlCommand sqlCommand = new SqlCommand("update SinhVien set MaKhoa = @MaKhoa, MaLop = @MaLop, NgayCap = @NgayCap, NgayHetHan = @NgayHetHan where MaSo = @MaSo", main.sqlConnection);
            sqlCommand.Parameters.AddWithValue("@MaSo", id);
            this.Invoke(new Action(delegate
            {
                addInputParams(sqlCommand);
            }));
            sqlCommand.ExecuteNonQuery();
        }

        public void addInputParams(SqlCommand sqlCommand)
        {
            sqlCommand.Parameters.AddWithValue("@MaKhoa", inputKhoa.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@MaLop", inputClass.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@NgayCap", inputNgayCap.Value);
            sqlCommand.Parameters.AddWithValue("@NgayHetHan", getNgayHetHan());
        }

        public bool checkInput()
        {
            if(inputKhoa.SelectedIndex == -1)
            {
                Messaging.showInputMissingMessage("Khoa");
                return false;
            }
            if(inputClass.SelectedIndex == -1)
            {
                Messaging.showInputMissingMessage("Lớp");
                return false;
            }
            if(inputNgayCap.getDateTimeSQL() == DBNull.Value)
            {
                Messaging.showInputMissingMessage("Ngày cấp");
                return true;
            }

            return true;
        }

        public override void refresh()
        {
            main.readerManager.refreshGrid();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!inputPerson.checkInput()) return;
            if (!checkInput()) return;
            new Thread(() =>
            {
                if (isAdd)
                    addReaderToSQL();
                else editReaderToSQL();

                refresh();
                closeForm();
            }).Start();
        }

        private void InputNgayCap_ValueChanged(object sender, EventArgs e)
        {
            ((EDateTimePicker)sender).setCustomFormat(false);
        }

        private void InputNgayCap_KeyDown(object sender, KeyEventArgs e)
        {
            ((EDateTimePicker)sender).onKeyDown(sender, e);
        }
    }
}
