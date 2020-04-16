using QuanLyThuVien.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyThuVien.BookDetails
{
    public class Book : NameableObject
    {
        public int authorID;
        public int locationID;
        public int nxbID;
        public int typeID;

        public string status;
        public string year;
        public double price;

        public Book()
        {

        }

    }
}
