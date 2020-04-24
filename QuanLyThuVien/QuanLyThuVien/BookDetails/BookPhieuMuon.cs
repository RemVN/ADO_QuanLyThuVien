using QuanLyThuVien.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyThuVien.BookDetails
{
    public class BookPhieuMuon : NameableObject
    {

        public BookPhieuMuon(int id, string name) : base(id, name)
        {

        }

        public string DisplayName { get => String.Format("{0}. {1}", Id, Name); }

    }
}
