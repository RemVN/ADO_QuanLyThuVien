using QuanLyThuVien.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms.MuonTra
{
    public partial class InputPrintPhieuMuon : Form
    {
        public InputPrintPhieuMuon()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if(inputMaPhieu.Text.Length == 0)
            {
                Messaging.showInputMissingMessage("Mã phiếu");
                return;
            }
            int id = Convert.ToInt32(inputMaPhieu.Text);
            if (!Program.MainInstance.isSqlObjectExist("select * from PhieuMuon where MaPhieu = @MaPhieu", "@MaPhieu", id))
            {
                Messaging.showWarning("Phiếu mượn không tồn tại");
                return;
            }
            Program.MainInstance.phieuMuonManager.printPhieuMuon(id);
            this.Close();
        }
    }
}
