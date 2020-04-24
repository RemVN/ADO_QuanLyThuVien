using QuanLyThuVien.Core;
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

        public SqlConnection sqlConnection;

        public BookManager bookManager;
        public StaffManager staffManager;
        public ReaderManager readerManager;
        public PhieuMuonManager phieuMuonManager;
        Authenticator authenticator;

        public Main()
        {
            this.Authenticator = new Authenticator();
            initSqlConnection();
        }

        public Authenticator Authenticator { get => authenticator; set => authenticator = value; }

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

        public DataTable getSqlObject(string storedProcedure, string idParamName, string id)
        {
            SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue(idParamName, id);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            return table;
        }

        public DataTable getSqlObject(string storedProcedure, string idParamName, int id)
        {
            return getSqlObject(storedProcedure, idParamName, id.ToString());
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
