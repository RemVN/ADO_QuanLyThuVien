﻿using QuanLyThuVien.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyThuVien.BookDetails
{
    public class BookNXB : NameableObject
    {
        public BookNXB()
        {
             
        }

        public override void loadFormDataRow(DataRow dataRow)
        {
            this.Id = (int)dataRow.ItemArray[0];
            this.Name = getStringFromSqlObject(dataRow.ItemArray[1]);
        }

    }
}
