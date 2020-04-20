using QuanLyThuVien.Core;
using QuanLyThuVien.MuonTra;
using QuanLyThuVien.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyThuVien.Config
{
    class Configuration
    {
        public static int defaultLimit = 99999;

        public static List<string> statusList = new List<string>() {"Mới", "Cũ", "Mất"};

        public static List<MuonTraStatus> muonTraStatusBookSide = new List<MuonTraStatus>()
        {
            new MuonTraStatus(0, "Đang mượn"),
            new MuonTraStatus(1, "Khả dụng")
        };

        public static List<SqlCodeObject> personSexes = new List<SqlCodeObject>()
        {
            new SqlCodeObject(0, "Nữ"),
            new SqlCodeObject(1, "Nam")
        };

        public static List<SqlCodeObject> staffRanks = new List<SqlCodeObject>()
        {
            new SqlCodeObject(0, "Quản lý"),
            new SqlCodeObject(1, "Thủ thư")
        };

        public static List<SqlCodeObject> staffAccountStatus = new List<SqlCodeObject>()
        {
            new SqlCodeObject(0, "Khoá"),
            new SqlCodeObject(1, "Mở")
        };
    }
}
