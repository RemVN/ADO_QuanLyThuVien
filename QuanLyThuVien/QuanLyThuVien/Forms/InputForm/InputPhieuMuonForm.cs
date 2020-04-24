using QuanLyThuVien.BookDetails;
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

        IDList<BookPhieuMuon> oldBooks = new IDList<BookPhieuMuon>();
        IDList<BookPhieuMuon> newBooks = new IDList<BookPhieuMuon>();
        BindingSource bookBinding = new BindingSource();

        public InputPhieuMuonForm(bool isAdd) : base(isAdd, "", Program.MainForm.PhieuMuonForm.phieuMuonGrid, true)
        {
            InitializeComponent();
            bookBinding.DataSource = newBooks;
            inputBooks.DataSource = bookBinding;
        }


        public override void changeControlData()
        {
            base.changeControlData();
            this.buttonAdd.Text = getExecuteButtonName();
            if (!isAdd)
            {
                oldBooks.AddRange(main.phieuMuonManager.getBookPhieuMuon(int.Parse(id)));
                this.inputID.Text = id;
                newBooks.AddRange(oldBooks);
                bookBinding.ResetBindings(true);
                DataTable dataTable = main.getSqlObject("sp_get_PhieuMuon_raw", "@MaPhieu", int.Parse(id));
                DataRow row = dataTable.Rows[0];
                inputReader.Text = Convert.ToString(row["MaSV"]);
                inputNgayMuon.Value = (DateTime) row["NgayMuon"];
                DateTime ngayHenTra = (DateTime)row["NgayHenTra"];
                int totalDays = (ngayHenTra - inputNgayMuon.Value).Days;
                inputSoNgay.Value = totalDays;
            }
        }

        public bool isOldBook(int bookID)
        {
            return oldBooks.getByID(bookID) != null;
        }

        public override string getName()
        {
            return isAdd ? "Tạo phiếu mượn" : "Sửa phiếu mượn";
        }

        public void insertCTPM(int id)
        {
            foreach (NameableObject book in inputBooks.Items)
            {
                insertBook(id, book.id);
            }
        }

        public void insertBook(int phieuMuonID, int bookID)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into ChiTietPhieuMuon (MaPhieu, MaSach) values (@MaPhieu, @MaSach)", main.sqlConnection);
            sqlCommand.Parameters.AddWithValue("@MaPhieu", phieuMuonID);
            sqlCommand.Parameters.AddWithValue("@MaSach", bookID);
            sqlCommand.ExecuteNonQuery();
        }

        public void addPhieuMuonToSQL()
        {
            SqlCommand sqlCommand = new SqlCommand("insert into PhieuMuon (MaSV, MaNV, NgayMuon, NgayHenTra) output INSERTED.MaPhieu values (@MaSV, @MaNV, @NgayMuon, @NgayHenTra)", main.sqlConnection);
            addPhieuMuonParams(sqlCommand, true);
            int id = (int) sqlCommand.ExecuteScalar();
            insertCTPM(id);
        }

        public void addPhieuMuonParams(SqlCommand sqlCommand, bool nhanVien)
        {
            sqlCommand.Parameters.AddWithValue("@MaSV", inputReader.Text);
            if(nhanVien)
            sqlCommand.Parameters.AddWithValue("@MaNV", main.Authenticator.Id);
            sqlCommand.Parameters.AddWithValue("@NgayMuon", inputNgayMuon.getDateTimeSQL());
            sqlCommand.Parameters.AddWithValue("@NgayHenTra", inputNgayMuon.Value.AddDays(Convert.ToDouble(inputSoNgay.Value)));
        }

        public void deleteBooksOfPhieuMuon()
        {
            SqlCommand sqlCommand = new SqlCommand(@"delete from ChiTietPhieuMuon where MaPhieu = @MaPhieu", main.sqlConnection);
            sqlCommand.Parameters.AddWithValue("@MaPhieu", id);
            sqlCommand.ExecuteNonQuery();
        }

        public void editPhieuMuonToSQL()
        {
            deleteBooksOfPhieuMuon();
            insertCTPM(int.Parse(id));
            SqlCommand sqlCommand = new SqlCommand(@"update PhieuMuon set MaSV = @MaSV, NgayMuon = @NgayMuon, NgayHenTra = @NgayHenTra where MaPhieu = @MaPhieu", main.sqlConnection);
            sqlCommand.Parameters.AddWithValue("@MaPhieu", id);
            addPhieuMuonParams(sqlCommand, false);
            sqlCommand.ExecuteNonQuery();
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
            if(!main.isSqlObjectExist(@"select * from SinhVien where MaSo = @MaSo", "@MaSo", Convert.ToInt32(inputReader.Text)))
            {
                Messaging.showWarning(String.Format("Sinh có mã số {0} không tồn tại", inputReader.Text));
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
                return false;
            }
            return true;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!checkInput()) return;
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
            if (newBooks.getByID(id) != null)
            {
                Messaging.showWarning("Bạn đã thêm sách này");
                return;
            }
            if (!isAdd)
            {
                if(!isOldBook(id))
                {
                    if (!main.bookManager.isBookAvailable(id))
                    {
                        Messaging.showWarning("Sách không khả dụng");
                        return;
                    }
                }
            }
            else
            {
                if (!main.bookManager.isBookAvailable(id))
                {
                    Messaging.showWarning("Sách không khả dụng");
                    return;
                }
            }
            BookPhieuMuon book = main.bookManager.getBookByID(id);
            newBooks.Add(book);
            bookBinding.ResetBindings(true);
        }

        private void InputBooks_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if (inputBooks.SelectedIndex == -1) return;
                newBooks.RemoveAt(inputBooks.SelectedIndex);
                bookBinding.ResetBindings(true);
            }
        }
    }
}
