using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien.Manager
{
    public abstract class GridManager
    {

        public static Main main = Program.getMain();
        public static MainForm mainForm = Program.getMainForm();

        public int currentOffset = 0;
        public DataGridView grid;
        public BindingSource gridBinding = new BindingSource();
        public GridManager(DataGridView grid)
        {
            this.grid = grid;
            this.grid.DataSource = gridBinding;
        }

        public object getValueOfNum(NumericUpDown numericUpDown)
        {
            return numericUpDown.Value == 0 ? DBNull.Value : (object) numericUpDown.Value;
        }

        public object getValueOfComboBox(ComboBox comboBox)
        {
            return comboBox.SelectedValue == null ? DBNull.Value : comboBox.SelectedValue;
        }

        public object getValueOfTextBox(TextBox textBox)
        {
            return textBox.Text.Length == 0 ? DBNull.Value : (object) textBox.Text;
        }

        public void refreshGrid()
        {
            defaultLoad();
        }

        public void resetGrid()
        {
            currentOffset = 0;
            defaultLoad();
        }

        public void setDataToGrid(DataTable dataTable)
        {
            grid.DataSource = dataTable;
            grid.Refresh();
        }

        public abstract void defaultLoad();

        public DataTable getDataTableWithOffsetAndLimit(string procedureName, int offset, int limit)
        {
            SqlCommand sqlCommand = new SqlCommand(procedureName, main.sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@offset", SqlDbType.Int));
            sqlCommand.Parameters.Add(new SqlParameter("@limit", SqlDbType.Int));
            sqlCommand.Parameters["@offset"].Value = offset;
            sqlCommand.Parameters["@limit"].Value = limit;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            return table;
        }
    }
}
