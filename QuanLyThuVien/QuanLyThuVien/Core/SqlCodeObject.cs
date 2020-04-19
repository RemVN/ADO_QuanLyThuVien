using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyThuVien.Core
{
    public class SqlCodeObject
    {

        private string displayName;
        private int sqlCode;

        public string DisplayName { get => displayName; set => displayName = value; }
        public int SqlCode { get => sqlCode; set => sqlCode = value; }

        public SqlCodeObject(int sqlCode, string displayName)
        {
            this.SqlCode = sqlCode;
            this.DisplayName = displayName;
        }

    }
}
