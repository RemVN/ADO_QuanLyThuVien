using QuanLyThuVien.Core;
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
    public partial class InputPhieuMuonForm : InputForm
    {
        static Main main = Program.MainInstance;

        List<NameableObject> oldBooks = new List<NameableObject>();
        List<NameableObject> newBooks = new List<NameableObject>();
        BindingSource bookBinding = new BindingSource();

        public InputPhieuMuonForm(bool isAdd) : base(isAdd, "", main.PhieuMuonForm.phieuMuonGrid, true)
        {
            InitializeComponent();
            initEvents();
            bookBinding.DataSource = newBooks;
            inputBooks.DataSource = bookBinding;
        }


        public override void changeControlData()
        {
            base.changeControlData();
            this.buttonAdd.Text = getExecuteButtonName();
            if (!isAdd)
            {
                oldBooks = main.phieuMuonManager.getBookPhieuMuon(int.Parse(id));
                this.inputID.Text = id;
                newBooks.AddRange(oldBooks);
                bookBinding.ResetBindings(true);
            }
        }

        public override string getName()
        {
            return isAdd ? "Tạo phiếu mượn" : "Sửa phiếu mượn";
        }

        public void insertChiTietPhieuMuon(int phieuMuonID, int bookID)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into ChiTietPhieuMuon (MaPhieu, MaSach) values (@MaPhieu, @MaSach)", main.sqlConnection);
            sqlCommand.Parameters.AddWithValue("@MaPhieu", phieuMuonID);
            sqlCommand.Parameters.AddWithValue("@MaSach", bookID);
            sqlCommand.ExecuteNonQuery();
        }

        public void addPhieuMuonToSQL()
        {
            SqlCommand sqlCommand = new SqlCommand("insert into PhieuMuon (MaSV, MaNV, NgayMuon, NgayHenTra) output INSERTED.MaPhieu values (@MaSV, @MaNV, @NgayMuon, @NgayHenTra)", main.sqlConnection);
            addPhieuMuonParams(sqlCommand);
            int id = (int) sqlCommand.ExecuteScalar();
            foreach(NameableObject book in inputBooks.Items)
            {
                insertChiTietPhieuMuon(id, book.id);
            }
        }

        public void addPhieuMuonParams(SqlCommand sqlCommand)
        {
            sqlCommand.Parameters.AddWithValue("@MaSV", inputReader.Text);
            sqlCommand.Parameters.AddWithValue("@MaNV", 1);
            sqlCommand.Parameters.AddWithValue("@NgayMuon", inputNgayMuon.getDateTimeSQL());
            sqlCommand.Parameters.AddWithValue("@NgayHenTra", inputNgayMuon.Value.AddDays(Convert.ToDouble(inputSoNgay.Value)));
        }

        public void editPhieuMuonToSQL()
        {

        }

        public override void refresh()
        {
            main.phieuMuonManager.refreshGrid();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool checkInput()
        {
            if(inputReader.Text.Length == 0)
            {
                Messaging.showInputMissingMessage("Mã sinh viên mượn");
                return false;
            }
            if(inputNgayMuon.getDateTimeSQL() == DBNull.Value)
            {
                Messaging.showInputMissingMessage("Ngày mượn");
                return false;
            }
            if(inputBooks.Items.Count == 0)
            {
                Messaging.showWarning("Phải mượn ít nhất một quyển sách");
                return true;
            }
            return true;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                if (isAdd)
                    addPhieuMuonToSQL();
                else editPhieuMuonToSQL();

                refresh();
                closeForm();
            }).Start();
        }

        private void InputNgayMuon_ValueChanged(object sender, EventArgs e)
        {
            ((EDateTimePicker)sender).setCustomFormat(false);
        }

        private void InputNgayMuon_KeyDown(object sender, KeyEventArgs e)
        {
            ((EDateTimePicker)sender).onKeyDown(sender, e);
        }

        private void ButtonAddBook_Click(object sender, EventArgs e)
        {
            if(inputAddBook.Text.Length == 0)
            {
                Messaging.showInputMissingMessage("Mã sách");
                return;
            }
            int id = Convert.ToInt32(inputAddBook.Text);
            if (!main.bookManager.isBookExist(id)) {
                Messaging.showWarning("Sách không tồn tại");
                return;
            }
            if(!main.bookManager.isBookAvailable(id))
            {
                Messaging.showWarning("Sách không khả dụng");
                return;
            }
            NameableObject book = main.bookManager.getBookByID(id);
            newBooks.Add(book);
            bookBinding.ResetBindings(true);
        }
    }
}
