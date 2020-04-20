using QuanLyThuVien.Config;
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
    public partial class InputStaffForm : InputForm
    {
        static Main main = Program.getMain();

        public InputStaffForm(bool isAdd) : base(isAdd, "", main.StaffForm.staffGrid, true)
        {
            InitializeComponent();
            inputRank.DataSource = Configuration.staffRanks;
            inputStatus.DataSource = Configuration.staffAccountStatus;
        }

        public override void changeControlData()
        {
            base.changeControlData();
            this.buttonAdd.Text = getExecuteButtonName();
            if (!isAdd)
            {
                inputUsername.Text = (string)dataGridViewRow.Cells[1].Value;
                inputPassword.Text = (string)dataGridViewRow.Cells[2].Value;
                inputRank.SelectedIndex = inputRank.FindStringExact((string)dataGridViewRow.Cells[3].Value);
                inputStatus.SelectedIndex = inputStatus.FindStringExact((string)dataGridViewRow.Cells[4].Value);
                inputPerson.changeControlData(dataGridViewRow, 5, id);
            }
        }

        public override string getName()
        {
            return isAdd ? "Thêm nhân viên" : "Sửa nhân viên";
        }

        public void addStaffToSQL()
        {
            int id = inputPerson.addPersonToSql();
            SqlCommand sqlCommand = new SqlCommand("insert into NhanVien(MaSo, TenDangNhap, MatKhau, TrangThai, ChucVu) values (@MaSo, @TenDangNhap, @MatKhau, @TrangThai, @ChucVu)", main.sqlConnection);
            sqlCommand.Parameters.AddWithValue("@MaSo", id);
            this.Invoke(new Action(delegate
            {
                addInputParams(sqlCommand);
            }));
            sqlCommand.ExecuteNonQuery();
        }

        public void editStaffToSQL()
        {
            inputPerson.editPersonToSql(Int32.Parse(id));
            SqlCommand sqlCommand = new SqlCommand("update NhanVien set TenDangNhap = @TenDangNhap, MatKhau = @MatKhau, TrangThai = @TrangThai, ChucVu = @ChucVu where MaSo = @MaSo", main.sqlConnection);
            sqlCommand.Parameters.AddWithValue("@MaSo", id);
            this.Invoke(new Action(delegate
            {
                addInputParams(sqlCommand);
            }));
            sqlCommand.ExecuteNonQuery();
        }

        public void addInputParams(SqlCommand sqlCommand)
        {
            sqlCommand.Parameters.AddWithValue("@TenDangNhap", inputUsername.Text);
            sqlCommand.Parameters.AddWithValue("@MatKhau", inputPassword.Text);
            sqlCommand.Parameters.AddWithValue("@TrangThai", inputStatus.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@ChucVu", inputRank.SelectedValue);
        }

        public bool checkInput()
        {
            if(inputUsername.Text.Length == 0)
            {
                Messaging.showInputMissingMessage("Tên đăng nhập");
                return false;
            }
            if(inputPassword.Text.Length == 0)
            {
                Messaging.showInputMissingMessage("Mật khẩu");
                return false;
            }
            if(inputStatus.SelectedIndex == -1)
            {
                Messaging.showInputMissingMessage("Trạng thái");
                return false;
            }
            if(inputRank.SelectedIndex == -1)
            {
                Messaging.showInputMissingMessage("Chức vụ");
                return false;
            }
            return true;
        }

        public override void refresh()
        {
            main.staffManager.refreshGrid();
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
                    addStaffToSQL();
                else editStaffToSQL();

                refresh();
                closeForm();
            }).Start();
        }
    }
}
