using QuanLyThuVien.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyThuVien.BookDetails
{
    class SqlObjectLoader
    {

        public static IDList<NameableObject> getSqlObjectsFromDataTable(Type clazz, DataTable dataTable)
        {
            IDList<NameableObject> list = new IDList<NameableObject>();
            foreach (DataRow row in dataTable.Rows)
            {
                NameableObject sqlObject = (NameableObject)Activator.CreateInstance(clazz);
                sqlObject.loadFormDataRow(row);
                list.Add(sqlObject);
            }
            return list;
        }

    }
}
