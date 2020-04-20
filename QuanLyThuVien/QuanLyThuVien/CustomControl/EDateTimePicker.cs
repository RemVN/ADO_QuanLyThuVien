using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace QuanLyThuVien.CustomControl
{
    public partial class EDateTimePicker : DateTimePicker
    {
        private bool maxIsToday;

        public EDateTimePicker()
        {
            this.Format = DateTimePickerFormat.Custom;
            this.CustomFormat = " ";

        }

        [Category("Custom")]
        [Bindable(true)]
        [DefaultValue(false)]
        [Description("Assign today is max date")]
        public bool MaxIsToday
        {
            get
            {
                return maxIsToday;
            }
            set
            {
                maxIsToday = value;
                if (maxIsToday)
                {
                    this.MaxDate = DateTime.Now;
                } else
                {
                    this.MaxDate = DateTime.MaxValue;
                }
            }
        }

        public void setCustomFormat(bool empty)
        {
            if(empty)
            {
                CustomFormat = " ";
            } else
            {
                CustomFormat = "dd/MM/yyyy";
            }
        }

        public void onKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                CustomFormat = " ";
            }
        }

        public object getDateTimeSQL()
        {
            if (CustomFormat == " ") return DBNull.Value;
            else return Value;
        }
    }
}
