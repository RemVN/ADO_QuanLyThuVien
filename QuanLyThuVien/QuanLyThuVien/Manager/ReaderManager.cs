using QuanLyThuVien.BookDetails;
using QuanLyThuVien.Config;
using QuanLyThuVien.Core;
using QuanLyThuVien.Forms;
using QuanLyThuVien.Searching;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;

namespace QuanLyThuVien.Manager
{
    public class ReaderManager : GridManager
    {

        public ReaderManager() : base(main.ReaderForm.readerGrid)
        {
            
        }

        public object[] getReaderSearchParams()
        {
            ReaderForm readerForm = main.ReaderForm;
            object[] arr = new object[11];
            arr[0] = getValueOfTextBox(readerForm.searchID);
            arr[1] = getValueOfComboBox(readerForm.searchKhoa);
            arr[2] = getValueOfComboBox(readerForm.searchClass);
            arr[3] = readerForm.searchNgayCap.getDateTimeSQL();
            arr[4] = readerForm.searchHetHan.getDateTimeSQL();
            arr[5] = getValueOfTextBox(readerForm.searchRealname);
            arr[6] = readerForm.searchBirthday.getDateTimeSQL();
            arr[7] = getValueOfComboBox(readerForm.searchSex);
            arr[8] = getValueOfTextBox(readerForm.searchSDT);
            arr[9] = getValueOfTextBox(readerForm.searchLocation);
            arr[10] = 100;
            return arr;
        }

        public DataTable searchDataTableReader(object[] param)
        {
            SearchQuery searchQuery = new SearchQuery("searchSinhVien", param)
                .withParam("@MaSo").withParam("@MaKhoa")
                .withParam("@MaLop").withParam("@NgayCap").withParam("@NgayHetHan")
                .withParam("@HoTen").withParam("@NgaySinh")
                .withParam("@GioiTinh").withParam("@SDT")
                .withParam("@DiaChi");
            return searchQuery.search();
        } 

        public void searchReader()
        {
            setDataToGrid(searchDataTableReader(getReaderSearchParams()));
        }

        public void initSelector()
        {
            int limit = Configuration.defaultLimit;
            ReaderForm readerForm = main.ReaderForm;
            setBindingSource(readerForm.khoaBindingSource,
                SqlObjectLoader.getSqlObjectsFromDataTable(
                    typeof(NameableObject),
                    getDataTableWithOffsetAndLimit("getKhoa", 0, limit)));
            setBindingSource(readerForm.classBindingSource,
                SqlObjectLoader.getSqlObjectsFromDataTable(
                    typeof(NameableObject),
                    getDataTableWithOffsetAndLimit("getLop", 0, limit)));
        }

        public override void defaultLoad()
        {
            new Thread(() =>
            {
                DataTable dataTable = getDataTableWithOffsetAndLimit("getSinhVien", currentOffset, 40);
                main.ReaderForm.Invoke(new Action(delegate
                {
                    setDataToGrid(dataTable);
                }));
            }).Start();
        }
    }
}
