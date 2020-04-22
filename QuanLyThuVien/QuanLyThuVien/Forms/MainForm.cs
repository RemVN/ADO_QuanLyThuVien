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

        List<Form> forms = new List<Form>();
        Form currentForm;
        Button currentFormButton;

        public List<Form> Forms { get => forms; set => forms = value; }
        public Form CurrentForm { get => currentForm; set => currentForm = value; }
        public Button CurrentFormButton { get => currentFormButton; set => currentFormButton = value; }

        public MainForm()
        {
            InitializeComponent();
            button1.ContextMenuStrip = testMenuStrip;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            main = Program.getMain();
            main.init();
            Forms.Add(main.BookForm);
            Forms.Add(main.StaffForm);
            Forms.Add(main.ReaderForm);
            Forms.Add(main.PhieuMuonForm);
            foreach (Form form in Forms) {
                formPanel.Controls.Add(form);
            }
            showForm(main.BookForm, buttonBookForm);
        }

        public void showForm(Form form, Button button)
        {
            if (form == CurrentForm) return;
            if(CurrentForm != null && CurrentFormButton != null)
            {
                CurrentForm.Hide();
                CurrentFormButton.BackColor = Color.White;
            }
            CurrentForm = form;
            CurrentFormButton = button;
            CurrentForm.Show();
            CurrentFormButton.BackColor = Color.FromArgb(147, 168, 253);
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

        private void ButtonBookForm_Click(object sender, EventArgs e)
        {
            showForm(main.BookForm, (Button) sender);
        }

        private void ButtonStaffForm_Click(object sender, EventArgs e)
        {
            showForm(main.StaffForm, (Button) sender);
        }

        private void ButtonReaderForm_Click(object sender, EventArgs e)
        {
            showForm(main.ReaderForm, (Button)sender);
        }

        private void ButtonMuonTraForm_Click(object sender, EventArgs e)
        {
            showForm(main.PhieuMuonForm, (Button)sender);
        }
    }
}
