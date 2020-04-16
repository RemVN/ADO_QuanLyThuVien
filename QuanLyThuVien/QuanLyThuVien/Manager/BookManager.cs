using QuanLyThuVien.BookDetails;
using QuanLyThuVien.Core;
using QuanLyThuVien.Forms;
using QuanLyThuVien.Searching;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
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

        public object[] getBookSearchParm()
        {
            BookForm bookForm = main.BookForm;
            object[] arr = new object[10];
            arr[0] = getValueOfTextBox(bookForm.searchBookID);
            arr[1] = getValueOfTextBox(bookForm.searchBookName);
            arr[2] = getValueOfComboBox(bookForm.searchBookStatus);
            arr[3] = bookForm.searchBookYear.Value;
            arr[4] = bookForm.searchBookPrice.Value;
            arr[5] = getValueOfComboBox(bookForm.searchBookType);
            arr[6] = getValueOfComboBox(bookForm.searchBookLocation);
            arr[7] = getValueOfComboBox(bookForm.searchBookNXB);
            arr[8] = getValueOfComboBox(bookForm.searchBookAuthor);
            arr[9] = 100;
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
                .withParam("@ViTri").withParam("@NXB").withParam("@TacGia");
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
            int limit = 1000;
            authorList.AddRange(SqlObjectLoader.getSqlObjectsFromDataTable(typeof(BookAuthor), getDataTableWithOffsetAndLimit("getTacGia", 0, limit)));
            nxbList.AddRange(SqlObjectLoader.getSqlObjectsFromDataTable(typeof(BookNXB), getDataTableWithOffsetAndLimit("getNXB", 0, limit)));
            locationList.AddRange(SqlObjectLoader.getSqlObjectsFromDataTable(typeof(BookLocation), getDataTableWithOffsetAndLimit("getVitri", 0, limit)));
            typeList.AddRange(SqlObjectLoader.getSqlObjectsFromDataTable(typeof(BookType), getDataTableWithOffsetAndLimit("getLoaiSach", 0, limit)));
        }

        public void initSelector()
        {
            loadSelector();
            setBindingSource(main.BookForm.bookAuthorBindingSource, authorList);
            setBindingSource(main.BookForm.bookNXBBindingSource, nxbList);
            setBindingSource(main.BookForm.bookLocationBindingSource, locationList);
            setBindingSource(main.BookForm.bookTypeBindingSource, typeList);
        }

        public void setBindingSource(BindingSource bindingSource, object obj)
        {
            bindingSource.DataSource = obj;
            bindingSource.ResetBindings(true);
        }

        public override void defaultLoad()
        {
            setDataToGrid(getBooksWithOffsetAndLimit(currentOffset, 40));
        }

        public DataTable getBooksWithOffsetAndLimit(int offset, int limit)
        {
            return getDataTableWithOffsetAndLimit("getSach", currentOffset, 50);
        }

    }
}
