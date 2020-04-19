using QuanLyThuVien.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms
{
    public partial class StaffForm : Form
    {

        public StaffForm()
        {
            this.TopLevel = false;
            this.TopMost = true;
            InitializeComponent();
            initSelector();
        }

        public void initSelector()
        {
            searchBirthday.Value = null;
            searchSex.DataSource = Configuration.personSexes;
            searchRank.DataSource = Configuration.staffRanks;
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            Program.getMain().staffManager.resetGrid();
        }
    }
}
