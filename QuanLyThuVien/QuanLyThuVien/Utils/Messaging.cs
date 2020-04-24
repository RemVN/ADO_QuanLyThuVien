using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien.Utils
{
    class Messaging
    {

        public static void showMissingPerm()
        {
            showWarning("Bạn không đủ quyền để truy cập chức năng này");
        }

        public static void showWarning(string message)
        {
            MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static  void showInputMissingMessage(string inputName)
        {
            showWarning(String.Format("Bạn chưa nhập {0}", inputName));
        }

    }
}
