using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyThuVien.Utils;
using System.Data.SqlClient;
using QuanLyThuVien.Config;
using QuanLyThuVien.CustomControl;

namespace QuanLyThuVien.Forms.InputForm
{
    public partial class InputPersonForm : UserControl
    {

        static Main main = Program.getMain();

        public InputPersonForm()
        {
            InitializeComponent();
            inputSex.DataSource = Configuration.personSexes;
        }

        public void changeControlData(DataGridViewRow row, int offsetArray, string id)
        {
            inputID.Text = id;
            inputRealname.Text = (string) row.Cells[offsetArray++].Value;
            inputBirthday.Value = (DateTime) row.Cells[offsetArray++].Value;
            inputBirthday.setCustomFormat(false);
            inputSex.SelectedIndex = inputSex.FindStringExact((string)row.Cells[offsetArray++].Value);
            inputSDT.Text = (string)row.Cells[offsetArray++].Value;
            inputLocation.Text = (string)row.Cells[offsetArray++].Value;
        }

        public int addPersonToSql()
        {
            SqlCommand sqlCommand = new SqlCommand("insert into CaNhan (HoTen, NgaySinh, GioiTinh, SDT, DiaChi) output INSERTED.MaSo values (@HoTen, @NgaySinh, @GioiTinh, @SDT, @DiaChi)", main.sqlConnection);
            this.Invoke(new Action(delegate
            {
                addInputParams(sqlCommand);
            }));
            int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            return id;
        }

        public void addInputParams(SqlCommand sqlCommand)
        {
            sqlCommand.Parameters.AddWithValue("@HoTen", inputRealname.Text);
            sqlCommand.Parameters.AddWithValue("@NgaySinh", inputBirthday.Value);
            sqlCommand.Parameters.AddWithValue("@GioiTinh", inputSex.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@SDT", inputSDT.Text);
            sqlCommand.Parameters.AddWithValue("@DiaChi", inputLocation.Text);
        }

        public void editPersonToSql(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("update CaNhan set HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, SDT = @SDT, DiaChi = @DiaChi where MaSo = @MaSo", main.sqlConnection);
            sqlCommand.Parameters.AddWithValue("@MaSo", id);
            this.Invoke(new Action(delegate
            {
                addInputParams(sqlCommand);
            }));
            sqlCommand.ExecuteNonQuery();
        }

        public bool checkInput()
        {
            if(inputRealname.Text.Length == 0)
            {
                Messaging.showInputMissingMessage("Họ tên");
                return false;
            }
            if(inputBirthday.getDateTimeSQL() == DBNull.Value)
            {
                Messaging.showInputMissingMessage("Ngày sinh");
                return false;
            }
            if(inputSex.SelectedIndex == -1)
            {
                Messaging.showInputMissingMessage("Giới tính");
                return false;
            }
            if(inputSDT.Text.Length == 0)
            {
                Messaging.showInputMissingMessage("Số điện thoại");
                return false;
            }
            if(inputLocation.Text.Length == 0)
            {
                Messaging.showInputMissingMessage("Địa chỉ");
                return false;
            }
            return true;
        }

        private void InputBirthday_ValueChanged(object sender, EventArgs e)
        {
            ((EDateTimePicker)sender).setCustomFormat(false);
        }

        private void InputBirthday_KeyDown(object sender, KeyEventArgs e)
        {
            ((EDateTimePicker)sender).onKeyDown(sender, e);
        }
    }
}
