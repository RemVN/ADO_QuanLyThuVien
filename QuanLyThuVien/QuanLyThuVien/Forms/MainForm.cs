using QuanLyThuVien.Core;
using QuanLyThuVien.Forms;
using QuanLyThuVien.Utils;
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

        BookForm bookForm;
        StaffForm staffForm;
        ReaderForm readerForm;
        PhieuMuonForm phieuMuonForm;

        List<Form> forms = new List<Form>();
        Form currentForm;
        Button currentFormButton;

        public List<Form> Forms { get => forms; set => forms = value; }
        public Form CurrentForm { get => currentForm; set => currentForm = value; }
        public Button CurrentFormButton { get => currentFormButton; set => currentFormButton = value; }

        public MainForm()
        {
            this.BookForm = new BookForm();
            this.StaffForm = new StaffForm();
            this.ReaderForm = new ReaderForm();
            this.PhieuMuonForm = new PhieuMuonForm();
            InitializeComponent();
        }

        public BookForm BookForm { get => bookForm; set => bookForm = value; }
        public StaffForm StaffForm { get => staffForm; set => staffForm = value; }
        public ReaderForm ReaderForm { get => readerForm; set => readerForm = value; }
        public PhieuMuonForm PhieuMuonForm { get => phieuMuonForm; set => phieuMuonForm = value; }

        private void MainForm_Load(object sender, EventArgs e)
        {
            main = Program.getMain();
            main.init();
            Forms.Add(BookForm);
            Forms.Add(StaffForm);
            Forms.Add(ReaderForm);
            Forms.Add(PhieuMuonForm);
            foreach (Form form in Forms) {
                formPanel.Controls.Add(form);
            }
            showForm(BookForm, buttonBookForm);
            initLoginInfo();
        }

        public void initLoginInfo()
        {
            Authenticator auth = main.Authenticator;
            labelName.Text = String.Format(labelName.Text, auth.DisplayName, auth.Id);
            labelRank.Text = String.Format(labelRank.Text, auth.RankDisplayName);
            labelLoginTime.Text = String.Format(labelLoginTime.Text, auth.LoginTime.ToString("dd/MM/yyyy hh:mm"));
            if(!auth.isAdmin())
            {
            }
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

        private void ButtonBookForm_Click(object sender, EventArgs e)
        {
            showForm(BookForm, (Button) sender);
        }

        private void ButtonStaffForm_Click(object sender, EventArgs e)
        {
            if(!Program.MainInstance.Authenticator.isAdmin())
            {
                Messaging.showMissingPerm();
                return;
            }
            showForm(StaffForm, (Button) sender);
        }

        private void ButtonReaderForm_Click(object sender, EventArgs e)
        {
            showForm(ReaderForm, (Button)sender);
        }

        private void ButtonMuonTraForm_Click(object sender, EventArgs e)
        {
            showForm(PhieuMuonForm, (Button)sender);
        }

        private void ButtonLogout_Click_1(object sender, EventArgs e)
        {
            Program.logout();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(main.Authenticator.Auth == true)
            {
                Application.Exit();
            }
        }
    }
}
