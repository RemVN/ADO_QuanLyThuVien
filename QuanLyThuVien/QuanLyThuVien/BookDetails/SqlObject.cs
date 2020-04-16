using QuanLyThuVien.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyThuVien.BookDetails
{
    public interface SqlObject 
    {

        void loadFormDataRow(DataRow dataRow);

    }
}
