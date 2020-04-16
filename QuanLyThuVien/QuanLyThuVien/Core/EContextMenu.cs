using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien.Core
{
    public partial class EContextMenu : UserControl
    {
        Action action;
        Control control;

        public ContextMenuStrip menuStrip;
        private ToolStripMenuItem sửaToolStripMenuItem;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private QuanLyThuVienDataSet4TableAdapters.TableAdapterManager tableAdapterManager1;

        public EContextMenu()
        {
            InitializeComponent();
        }

        public EContextMenu(Control control, Action action)
        {
            this.control = control;
            this.action = action;
            InitializeComponent();
        }

        public void invokeAction()
        {
            control.Invoke(action);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableAdapterManager1 = new QuanLyThuVien.QuanLyThuVienDataSet4TableAdapters.TableAdapterManager();
            this.menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QuanLyThuVien.QuanLyThuVienDataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.ViTriTableAdapter = null;
            // 
            // contextMenuStrip1
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaToolStripMenuItem});
            this.menuStrip.Name = "contextMenuStrip1";
            this.menuStrip.Size = new System.Drawing.Size(181, 48);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sửaToolStripMenuItem.Text = "Sửa";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.SửaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "EContextMenu";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(27, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // EContextMenu
            // 
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "EContextMenu";
            this.Size = new System.Drawing.Size(85, 34);
            this.Click += new System.EventHandler(this.EContextMenu_Click);
            this.menuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.ComponentModel.IContainer components;

        private void EContextMenu_Click(object sender, EventArgs e)
        {

        }

        private void SửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            invokeAction();
        }
    }
}
