using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class MainForm : Form
    {
        static Main main;

        public MainForm()
        {
            InitializeComponent();
            button1.ContextMenuStrip = testMenuStrip;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            main = Program.getMain();
            main.init();
            this.formPanel.Controls.Add(main.BookForm);
            this.formPanel.Controls.Add(main.StaffForm);
            //main.BookForm.Show();
            main.StaffForm.Show();
        }

        private void imageButton_hover(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BackColor = Color.LightGray;
        }

        private void imageButton_leave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BackColor = Color.White;
        }

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Button button = (Button)sender;
                button.ContextMenuStrip.Show(button, new Point(e.X, e.Y));
            }
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
