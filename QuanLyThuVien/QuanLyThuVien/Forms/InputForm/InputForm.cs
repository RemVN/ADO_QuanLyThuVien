using QuanLyThuVien.BookDetails;
using QuanLyThuVien.Core;
using QuanLyThuVien.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms.InputForm
{
    public class InputForm : Form
    {

        public string id;
        public string getTableProcedure;
        public DataGridView gridView;
        public bool refreshGridWhenDone;
        public BindingSource selectorBindingSource;
        public Type selectorClass;
        public bool isAdd = true;
        public DataGridViewRow dataGridViewRow;

        [Obsolete("Designer only", true)]
        public InputForm()
        {

        }

        public InputForm(bool isAdd, string getTableProcedure, DataGridView gridView, bool resetWhenDone)
        {
            this.isAdd = isAdd;
            this.getTableProcedure = getTableProcedure;
            this.gridView = gridView;
            this.refreshGridWhenDone = resetWhenDone;
            initEvents();
        }

        public InputForm withSelectorBindingSource(Type selectorClass, BindingSource bindingSource)
        {
            this.selectorClass = selectorClass;
            this.selectorBindingSource = bindingSource;
            return this;
        }

        public InputForm withID(string id)
        {
            this.id = id;
            return this;
        }

        public InputForm withDataRow(DataGridViewRow dataGridViewRow)
        {
            this.dataGridViewRow = dataGridViewRow;
            return this;
        }

        public string getExecuteButtonName()
        {
            return isAdd ? "Thêm" : "Sửa";
        }

        public virtual string getName()
        {
            return "";
        }

        public virtual void changeControlData()
        {
            Console.WriteLine("name: " + getName());
            this.Text = getName();
        }

        public bool needRefreshSelector()
        {
            return selectorBindingSource != null;
        }

        public void refreshSelector(DataTable dataTable)
        {
            if(needRefreshSelector())
            {
                this.Invoke(new Action(delegate ()
                {
                    selectorBindingSource.DataSource = SqlObjectLoader.getSqlObjectsFromDataTable(selectorClass, dataTable);
                    selectorBindingSource.ResetBindings(true);
                }));
            }
        }

        public DataTable getDataTable()
        {
            SqlCommand sqlCommand = new SqlCommand(getTableProcedure, Program.getMain().sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            return table;
        }

        public void closeForm()
        {
            this.Invoke(new Action(delegate ()
            {
                Close();
            }));
        }

        public virtual void refresh()
        {
            DataTable dataTable = getDataTable();
            refreshSelector(dataTable);
            if (refreshGridWhenDone)
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = getDataTable();
                gridView.Invoke(new Action(delegate ()
                {
                    gridView.DataSource = bindingSource;
                    gridView.Update();
                }));
            }
        }

        public void showInputMissingMessage(string inputName)
        {
            Messaging.showInputMissingMessage(inputName);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // InputForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "InputForm";
            this.ResumeLayout(false);

        }

        public void initEvents()
        {
            this.Load += new System.EventHandler(this.InputForm_Load);
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            changeControlData();
        }
    }
}
