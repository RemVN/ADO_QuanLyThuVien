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
        public PhieuMuonManager() : base(main.PhieuMuonForm.phieuMuonGrid)
        {

        }

        public List<NameableObject> getBookPhieuMuon(int phieuMuonID)
        {
            List<NameableObject> list = new List<NameableObject>();
            SqlCommand sqlCommand = new SqlCommand("sp_get_SachPhieuMuon", main.sqlConnection);
            sqlCommand.Parameters.AddWithValue("@MaPhieu", phieuMuonID);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            foreach(DataRow row in table.Rows)
            {
                list.Add(new NameableObject(int.Parse(row["MaSach"].ToString()), (string)row["TenSach"]));
            }
            return list;
        }

        public override void defaultLoad()
        {
            new Thread(() =>
            {
                DataTable dataTable = getDataTableWithOffsetAndLimit("sp_get_PhieuMuon", currentOffset, 40);
                main.PhieuMuonForm.Invoke(new Action(delegate
                {
                    setDataToGrid(dataTable);
                }));
            }).Start();
        }

    }
}
