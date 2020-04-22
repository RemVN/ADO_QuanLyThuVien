using QuanLyThuVien.BookDetails;
using QuanLyThuVien.Config;
using QuanLyThuVien.Core;
using QuanLyThuVien.Forms;
using QuanLyThuVien.Searching;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyThuVien.Manager
{
    public class BookManager : GridManager
    {
        public IDList<NameableObject> authorList = new IDList<NameableObject>();
        public IDList<NameableObject> nxbList = new IDList<NameableObject>();
        public IDList<NameableObject> locationList = new IDList<NameableObject>();
        public IDList<NameableObject> typeList = new IDList<NameableObject>();

        public BookManager() : base(main.BookForm.bookGrid)
        {
            initSelector();
        }

        public bool isBookExist(int bookID)
        {
            return main.isSqlObjectExist("select * from Sach where MaSach = @MaSach", "@MaSach", bookID);
        }

        public NameableObject getBookByID(int bookID)
        {
            SqlCommand sqlCommand = new SqlCommand(@"select s.MaSach, s.TenSach from Sach s where s.MaSach = @MaSach", main.sqlConnection);
            sqlCommand.Parameters.AddWithValue("@MaSach", bookID);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            try
            {
                if (!reader.Read())
                    return null;
                return new NameableObject(reader.GetInt32(0), reader.GetString(1));
            } finally
            {
                reader.Close();
            }
        }

        public bool isBookAvailable(int bookID)
        {
            SqlCommand sqlCommand = new SqlCommand("sp_is_sach_available", main.sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MaSach", bookID);
            SqlParameter sqlParameter = new SqlParameter("@result", DbType.Boolean);
            sqlParameter.Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(sqlParameter);
            sqlCommand.ExecuteNonQuery();
            return Convert.ToBoolean(sqlCommand.Parameters["@result"].Value);
        }

        public object[] getBookSearchParm()
        {
            BookForm bookForm = main.BookForm;
            object[] arr = new object[11];
            arr[0] = getValueOfTextBox(bookForm.searchBookID);
            arr[1] = getValueOfTextBox(bookForm.searchBookName);
            arr[2] = getValueOfComboBox(bookForm.searchBookStatus);
            arr[3] = getValueOfNum(bookForm.searchBookYear);
            arr[4] = getValueOfNum(bookForm.searchBookPrice);
            arr[5] = getValueOfComboBox(bookForm.searchBookType);
            arr[6] = getValueOfComboBox(bookForm.searchBookLocation);
            arr[7] = getValueOfComboBox(bookForm.searchBookNXB);
            arr[8] = getValueOfComboBox(bookForm.searchBookAuthor);
            arr[9] = getValueOfComboBox(bookForm.searchMuonTra);
            arr[10] = 100;
            return arr;
        }

        public void searchBook()
        {
            setDataToGrid(searchDataTableBook(getBookSearchParm()));
        }

        public DataTable searchDataTableBook(object[] parms)
        {
            SearchQuery searchQuery = new SearchQuery("searchSach", getBookSearchParm())
                .withParam("@MaSach").withParam("@TenSach").withParam("@TinhTrang")
                .withParam("@NamXB").withParam("@GiaSach").withParam("@LoaiSach")
                .withParam("@ViTri").withParam("@NXB").withParam("@TacGia").withParam("@MuonTra");
            return searchQuery.search();
        }

        public void clearDataSourceSelector()
        {
            authorList.Clear();
            nxbList.Clear();
            locationList.Clear();
            typeList.Clear();
        }

        public void loadSelector()
        {
            clearDataSourceSelector();
            int limit = Configuration.defaultLimit;
            authorList.AddRange(SqlObjectLoader.getSqlObjectsFromDataTable(typeof(BookAuthor), getDataTableWithOffsetAndLimit("getTacGia", 0, limit)));
            nxbList.AddRange(SqlObjectLoader.getSqlObjectsFromDataTable(typeof(BookNXB), getDataTableWithOffsetAndLimit("getNXB", 0, limit)));
            locationList.AddRange(SqlObjectLoader.getSqlObjectsFromDataTable(typeof(BookLocation), getDataTableWithOffsetAndLimit("getVitri", 0, limit)));
            typeList.AddRange(SqlObjectLoader.getSqlObjectsFromDataTable(typeof(BookType), getDataTableWithOffsetAndLimit("getLoaiSach", 0, limit)));
            main.BookForm.clearSearchInput();
        }

        public void initSelector()
        {
            loadSelector();
            setBindingSource(main.BookForm.bookAuthorBindingSource, authorList);
            setBindingSource(main.BookForm.bookNXBBindingSource, nxbList);
            setBindingSource(main.BookForm.bookLocationBindingSource, locationList);
            setBindingSource(main.BookForm.bookTypeBindingSource, typeList);
        }

        public override void defaultLoad()
        {
            new Thread(() =>
            {
                DataTable dataTable = getBooksWithOffsetAndLimit(currentOffset, 40);
                main.BookForm.Invoke(new Action(delegate
                {
                    setDataToGrid(dataTable);
                }));
            }).Start();
        }

        public DataTable getBooksWithOffsetAndLimit(int offset, int limit)
        {
            return getDataTableWithOffsetAndLimit("getSach", currentOffset, 50);
        }

    }
}
