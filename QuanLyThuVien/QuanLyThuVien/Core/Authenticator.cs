using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace QuanLyThuVien.Core
{
    public class Authenticator : IDObject
    {
        bool auth = false;
        string userName;
        string displayName;
        string rankDisplayName;
        int rank;
        DateTime loginTime;

        public Authenticator()
        {

        }

        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public int Rank { get => rank; set => rank = value; }
        public bool Auth { get => auth; set => auth = value; }
        public string RankDisplayName { get => rankDisplayName; set => rankDisplayName = value; }
        public DateTime LoginTime { get => loginTime; set => loginTime = value; }

        public bool checkLogin(string userName, string password)
        {
            SqlCommand sqlCommand = new SqlCommand(@"select * from NhanVien where TenDangNhap = @TenDangNhap and MatKhau = @MatKhau", Program.MainInstance.sqlConnection);
            sqlCommand.Parameters.AddWithValue("@TenDangNhap", userName);
            sqlCommand.Parameters.AddWithValue("@MatKhau", sha256(password));
            //sqlCommand.Parameters.AddWithValue("@MatKhau", password);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            bool hasRow = sqlDataReader.HasRows;
            sqlDataReader.Close();
            return hasRow;
        }

        public bool isAdmin()
        {
            return Rank == 0;
        }

        public bool login(string userName, string password)
        {
            if(checkLogin(userName, password))
            {
                UserName = userName;
                DataTable dataTable = Program.MainInstance.getSqlObject("sp_get_NhanVien_by_TenDangNhap", "@TenDangNhap", UserName);
                DataRow row = dataTable.Rows[0];
                DisplayName = (string) row["HoTen"];
                rank = Convert.ToInt32(row["ChucVu"]);
                RankDisplayName = (string)row["ChucVuDisplayName"];
                LoginTime = DateTime.Now;
                Auth = true;
                Id = Convert.ToInt32(row["MaSo"]);
                return true;
            }
            return false;
        }

        public static string sha256(string randomString)
        {
            var crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }
            return hash;
        }

        public void logout()
        {
            Auth = false;
            userName = "";
            displayName = "";
            rank = -1;
            id = -1;
        }
    }
}
