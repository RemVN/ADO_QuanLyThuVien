using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace QuanLyThuVien.Searching
{
    class SearchQuery
    {
        static Main main = Program.getMain();

        object[] param;
        int count = 0;
        SqlCommand sqlCommand;
        public SearchQuery(string procedureName, object[] param)
        {
            sqlCommand = new SqlCommand(procedureName, main.sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            this.param = param;
        }

        public SearchQuery withParam(string paramName)
        {
            sqlCommand.Parameters.AddWithValue(paramName, param[count]);
            Console.WriteLine(paramName + " " + param[count]);
            //sqlCommand.Parameters.Add(new SqlParameter(paramName, param[count]));
            count++;
            return this;
        }

        public DataTable search()
        {
            sqlCommand.Parameters.Add(new SqlParameter("@limit", param[count]));
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            return table;
        }

    }
}
