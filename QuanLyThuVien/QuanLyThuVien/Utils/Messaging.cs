using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien.Utils
{
    class Messaging
    {

        public static  void showInputMissingMessage(string inputName)
        {
            MessageBox.Show(String.Format("Bạn chưa nhập {0}", inputName), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
