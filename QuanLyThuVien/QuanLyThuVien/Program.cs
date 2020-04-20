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

        public static MainForm MainForm { get => mainForm; set => mainForm = value; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Console.WriteLine("Thử nghiệm");
            main = new Main();
            MainForm = new MainForm();
            Application.Run(MainForm);
        }

        public static Main getMain()
        {
            return main;
        }

    }
}
