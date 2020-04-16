using QuanLyThuVien.BookDetails;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyThuVien.Core
{
    public class NameableObject : IDObject, SqlObject
    {

        private string name;

        public NameableObject()
        {
        }

        public static string getStringFromSqlObject(object obj)
        {
            return obj is DBNull ? "" : (string)obj;
        }

        public virtual void loadFormDataRow(DataRow dataRow)
        {
            this.Id = (int)dataRow.ItemArray[0];
            this.Name = getStringFromSqlObject(dataRow.ItemArray[1]);
        }

        public string Name { get => name; set => name = value; }
    }
}
