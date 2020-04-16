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

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Console.WriteLine("Thử nghiệm");
            main = new Main();
            mainForm = new MainForm();
            Application.Run(mainForm);
        }

        public static MainForm getMainForm()
        {
            return mainForm;
        }

        public static Main getMain()
        {
            return main;
        }

    }
}
