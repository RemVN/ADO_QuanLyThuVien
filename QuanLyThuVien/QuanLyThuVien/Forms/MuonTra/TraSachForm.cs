using QuanLyThuVien.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms.MuonTra
{
    public partial class TraSachForm : Form
    {
        public TraSachForm()
        {
            InitializeComponent();
        }

        public bool traSach()
        {
            Main main = Program.MainInstance;
            int id = Convert.ToInt32(inputMaPhieu.Text);
            if (!main.isSqlObjectExist("select * from PhieuMuon where MaPhieu = @MaPhieu", "@MaPhieu", id)) {
                Messaging.showWarning("Phiếu mượn không tồn tại");
                return false;
            }
            SqlCommand sqlCommand = new SqlCommand("update PhieuMuon set DaTra = 1 where MaPhieu = @MaPhieu", main.sqlConnection);
            sqlCommand.Parameters.AddWithValue("@MaPhieu", id);
            sqlCommand.ExecuteNonQuery();
            return true;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if(inputMaPhieu.Text.Length == 0)
            {
                Messaging.showInputMissingMessage("Mã phiếu mượn");
                return;
            }
            if(traSach())
            {
                this.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
