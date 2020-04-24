using QuanLyThuVien.Utils;
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
    public partial class LoginForm : Form
    {
        static Main main = Program.MainInstance;

        public LoginForm()
        {
            InitializeComponent();
        }

        public bool checkInput()
        {
            if(inputUsername.Text.Length == 0)
            {
                Messaging.showInputMissingMessage("Tên đăng nhập");
                return false;
            }
            if (inputPassword.Text.Length == 0)
            {
                Messaging.showInputMissingMessage("Mật khẩu");
                return false;
            }
            return true;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (!checkInput()) return;
            if (!main.Authenticator.login(inputUsername.Text, inputPassword.Text))
            {
                Messaging.showWarning("Tài khoản hoặc mật khẩu không chính xác");
                return;
            }
            Program.showMainForm();
            this.Hide();
        }
    }
}
