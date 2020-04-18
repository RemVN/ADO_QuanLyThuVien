using QuanLyThuVien.MuonTra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyThuVien.Config
{
    class Configuration
    {

        public static List<string> statusList = new List<string>() {"Mới", "Cũ", "Mất"};
        public static List<MuonTraStatus> muonTraStatusBookSide = new List<MuonTraStatus>()
        {
            new MuonTraStatus(0, "Đang mượn"),
            new MuonTraStatus(1, "Khả dụng")
        };
    }
}
