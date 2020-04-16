using QuanLyThuVien.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyThuVien.BookDetails
{
    public class BookAuthor : NameableObject
    {
        private string phoneNumber;

        public BookAuthor()
        {

        }

        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public override void loadFormDataRow(DataRow dataRow)
        {
            this.Id = (int)dataRow.ItemArray[0];
            this.Name = getStringFromSqlObject(dataRow.ItemArray[1]);
            this.PhoneNumber = getStringFromSqlObject(dataRow.ItemArray[2]);
        }

    }
}
