using QuanLyThuVien.BookDetails;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms.InputForm
{
    public partial class InputLocationForm : InputForm
    {
        Main main = Program.getMain();

        public InputLocationForm(bool isAdd) : base(isAdd, "getAllViTri", Program.MainForm.BookForm.locationGrid, true)
        {
            withSelectorBindingSource(typeof(BookLocation), Program.MainForm.BookForm.bookLocationBindingSource);
            InitializeComponent();
        }

        public override void changeControlData()
        {
            base.changeControlData();

            this.buttonAdd.Text = getExecuteButtonName();
            if (!isAdd)
            {
                this.textID.Text = id;
                textLocation.Text = (string)dataGridViewRow.Cells[1].Value;
            }
        }

        public override string getName()
        {
            return isAdd ? "Thêm vị trí" : "Sửa vị trí";
        }

        public void addLocationToSql()
        {
            SqlCommand sqlCommand = new SqlCommand("insert into ViTri (TenViTri) values (@TenViTri)", main.sqlConnection);
            sqlCommand.Parameters.Add(new SqlParameter("@TenViTri", SqlDbType.NVarChar)).Value = textLocation.Text;
            sqlCommand.ExecuteNonQuery();
        }

        public void editLocationToSql()
        {
            SqlCommand sqlCommand = new SqlCommand("update ViTri set TenViTri = @TenViTri where MaViTri = @MaViTri", main.sqlConnection);
            sqlCommand.Parameters.Add(new SqlParameter("@TenViTri", SqlDbType.NVarChar)).Value = textLocation.Text;
            sqlCommand.Parameters.AddWithValue("@MaViTri", id);
            sqlCommand.ExecuteNonQuery();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (textLocation.Text.Length == 0)
            {
                showInputMissingMessage("Vị trí");
                return;
            }
            new Thread(() =>
            {
                if (isAdd)
                    addLocationToSql();
                else editLocationToSql();
                refresh();
                closeForm();
            }).Start();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
