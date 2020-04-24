using QuanLyThuVien.BookDetails;
using QuanLyThuVien.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;

namespace QuanLyThuVien.Manager
{
    public class PhieuMuonManager : GridManager
    {
        public PhieuMuonManager() : base(Program.MainForm.PhieuMuonForm.phieuMuonGrid)
        {

        }

        public List<BookPhieuMuon> getBookPhieuMuon(int phieuMuonID)
        {
            List<BookPhieuMuon> list = new List<BookPhieuMuon>();
            SqlCommand sqlCommand = new SqlCommand("sp_get_SachPhieuMuon", main.sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MaPhieu", phieuMuonID);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            Console.WriteLine("rows: " + table.Rows.Count);
            foreach(DataRow row in table.Rows)
            {
                list.Add(new BookPhieuMuon(int.Parse(row["MaSach"].ToString()), (string)row["TenSach"]));
            }
            return list;
        }

        public override void defaultLoad()
        {
            new Thread(() =>
            {
                DataTable dataTable = getDataTableWithOffsetAndLimit("sp_get_PhieuMuon", currentOffset, 40);
                Program.MainForm.PhieuMuonForm.Invoke(new Action(delegate
                {
                    setDataToGrid(dataTable);
                }));
            }).Start();
        }

    }
}
