using QuanLyThuVien.CustomControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien.Utils
{
    class InputCleaner
    {

        public static void clearInputs(params Control[] controls)
        {
            foreach(Control control in controls)
            {
                clearInput(control);
            }
        }

        public static void clearInput(Control control)
        {
            if(control is TextBox)
            {
                ((TextBox)control).Text = "";
            }
            if(control is EDateTimePicker)
            {
                ((EDateTimePicker)control).setCustomFormat(true);
            }
            if(control is ComboBox)
            {
                ((ComboBox)control).SelectedIndex = -1;
            }
        }

    }
}
