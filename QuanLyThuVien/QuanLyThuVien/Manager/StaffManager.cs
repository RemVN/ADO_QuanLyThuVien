using QuanLyThuVien.Forms;
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
            arr[4] = staffForm.searchBirthday.Value;
            return arr;
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
