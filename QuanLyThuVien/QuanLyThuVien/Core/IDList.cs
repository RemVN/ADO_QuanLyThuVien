using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyThuVien.BookDetails;

namespace QuanLyThuVien.Core
{
    public class IDList<T> : List<T> where T : IDObject
    {

        public bool isExist(int id)
        {
            return getByID(id) != null;
        }

        public T getByID(int id)
        {
            foreach(T obj in this)
            {
                if (obj.Id == id) return obj;
            }
            return null;
        }

    }
}
