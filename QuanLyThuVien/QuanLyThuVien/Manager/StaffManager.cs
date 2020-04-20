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
    public class StaffManager : GridManager
    {

        public StaffManager() : base(main.StaffForm.staffGrid)
        {

        }

        public object[] getStaffSearchParam()
        {
            StaffForm staffForm = main.StaffForm;
            object[] arr = new object[10];
            arr[0] = getValueOfTextBox(staffForm.searchID);
            arr[1] = getValueOfTextBox(staffForm.searchUsername);
            arr[2] = getValueOfComboBox(staffForm.searchRank);
            arr[3] = getValueOfComboBox(staffForm.searchStatus);
            arr[4] = getValueOfTextBox(staffForm.searchRealname);
            arr[5] = staffForm.searchBirthday.getDateTimeSQL();
            arr[6] = getValueOfComboBox(staffForm.searchSex);
            arr[7] = getValueOfTextBox(staffForm.searchSDT);
            arr[8] = getValueOfTextBox(staffForm.searchLocation);
            arr[9] = 100;
            return arr;
        }

        public DataTable searchDataTableNhanVien(object[] param)
        {
            SearchQuery searchQuery = new SearchQuery("searchNhanVien", param)
                .withParam("@MaSo").withParam("@TenDangNhap")
                .withParam("@ChucVu").withParam("@TrangThai")
                .withParam("@HoTen").withParam("@NgaySinh")
                .withParam("@GioiTinh").withParam("@SDT")
                .withParam("@DiaChi");
            return searchQuery.search();
        }

        public void searchNhanVien()
        {
            setDataToGrid(searchDataTableNhanVien(getStaffSearchParam()));
        }

        public override void defaultLoad()
        {
            new Thread(() =>
            {
                DataTable dataTable = getDataTableWithOffsetAndLimit("getNhanVien", currentOffset, 40);
                main.BookForm.Invoke(new Action(delegate
                {
                    setDataToGrid(dataTable);
                }));
            }).Start();
        }
    }
}
