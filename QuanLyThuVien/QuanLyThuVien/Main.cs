using QuanLyThuVien.Forms;
using QuanLyThuVien.Manager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public class Main
    {

        BookForm bookForm;
        StaffForm staffForm;
        ReaderForm readerForm;
        PhieuMuonForm phieuMuonForm;

        public SqlConnection sqlConnection;

        public BookManager bookManager;
        public StaffManager staffManager;
        public ReaderManager readerManager;
        public PhieuMuonManager phieuMuonManager;

        public Main()
        {
            this.BookForm = new BookForm();
            this.StaffForm = new StaffForm();
            this.ReaderForm = new ReaderForm();
            this.PhieuMuonForm = new PhieuMuonForm();
            initSqlConnection();
        }

        public BookForm BookForm { get => bookForm; set => bookForm = value; }
        public StaffForm StaffForm { get => staffForm; set => staffForm = value; }
        public ReaderForm ReaderForm { get => readerForm; set => readerForm = value; }
        public PhieuMuonForm PhieuMuonForm { get => phieuMuonForm; set => phieuMuonForm = value; }

        public void init()
        {
            this.bookManager = new BookManager();
            this.staffManager = new StaffManager();
            this.readerManager = new ReaderManager();
            this.phieuMuonManager = new PhieuMuonManager();
            //test2();
        }

        public void initSqlConnection()
        {
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
            stringBuilder["Server"] = "REMVN-DESKTOP";
            stringBuilder["Database"] = "QuanLyThuVien";
            stringBuilder["User Id"] = "sa";
            stringBuilder["Password"] = "123456";
            sqlConnection = new SqlConnection(stringBuilder.ToString());
            sqlConnection.Open();
        }

        public bool isSqlObjectExist(string command, string paramName, int id)
        {
            SqlCommand sqlCommand = new SqlCommand(@command, sqlConnection);
            sqlCommand.Parameters.AddWithValue(paramName, id);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            return table.Rows.Count > 0;
        }

        public void test2()
        {
            SqlCommand sqlCommand = new SqlCommand("getSinhVien", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@offset", SqlDbType.Int));
            sqlCommand.Parameters.Add(new SqlParameter("@limit", SqlDbType.Int));
            sqlCommand.Parameters["@offset"].Value = 0;
            sqlCommand.Parameters["@limit"].Value = 10;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable sinhVien = new DataTable();
            sqlDataAdapter.Fill(sinhVien);
            bookForm.bookGrid.DataSource = sinhVien;
            foreach (DataRow row in sinhVien.Rows)
            {
                //foreach (var item in row.ItemArray)
                //{
                //    Console.WriteLine(item);
                //}
            }
        }

        public void test()
        {
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
            stringBuilder["Server"] = "REMVN-DESKTOP";
            stringBuilder["Database"] = "QuanLyThuVien";
            stringBuilder["User Id"] = "sa";
            stringBuilder["Password"] = "123456";
            stringBuilder["MultipleActiveResultSets"] = "True";
            SqlConnection sqlConnection = new SqlConnection(stringBuilder.ToString());
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(@"select * from CaNhan where MaSo = @MaSo", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@MaSo", 1);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                MessageBox.Show(sqlDataReader[1].ToString());
                Console.WriteLine();
            }
        }

    }
}
