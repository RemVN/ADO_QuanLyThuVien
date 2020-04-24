using QuanLyThuVien.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    static class Program
    {

        static Main main;
        static MainForm mainForm;
        static LoginForm loginForm;

        public static MainForm MainForm { get => mainForm; set => mainForm = value; }
        public static Main MainInstance { get => main; set => main = value; }
        public static LoginForm LoginForm { get => loginForm; set => loginForm = value; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainInstance = new Main();
            LoginForm = new LoginForm();
         
            Application.Run(LoginForm);
        }

        public static void showMainForm()
        {
            MainForm = new MainForm();
            MainForm.Show();
        }

        public static void logout()
        {
            main.Authenticator.logout();
            LoginForm.Show();
            MainForm.Close();
        }

        public static Main getMain()
        {
            return MainInstance;
        }

    }
}
