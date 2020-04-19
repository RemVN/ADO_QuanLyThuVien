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

        public SqlConnection sqlConnection;

        public BookManager bookManager;
        public StaffManager staffManager;

        public Main()
        {
            this.BookForm = new BookForm();
            this.StaffForm = new StaffForm();
            initSqlConnection();
        }

        public BookForm BookForm { get => bookForm; set => bookForm = value; }
        public StaffForm StaffForm { get => staffForm; set => staffForm = value; }

        public void init()
        {
            this.bookManager = new BookManager();
            this.staffManager = new StaffManager();
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
