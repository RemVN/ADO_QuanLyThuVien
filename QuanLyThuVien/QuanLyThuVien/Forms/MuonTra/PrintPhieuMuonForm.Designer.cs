namespace QuanLyThuVien.Forms.MuonTra
{
    partial class PrintPhieuMuonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BookPhieuMuonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.report = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.BookPhieuMuonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BookPhieuMuonBindingSource
            // 
            this.BookPhieuMuonBindingSource.DataSource = typeof(QuanLyThuVien.BookDetails.BookPhieuMuon);
            // 
            // report
            // 
            this.report.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "BookPhieuMuonDS";
            reportDataSource1.Value = this.BookPhieuMuonBindingSource;
            this.report.LocalReport.DataSources.Add(reportDataSource1);
            this.report.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.Forms.MuonTra.BookPhieuMuonRP.rdlc";
            this.report.Location = new System.Drawing.Point(0, 0);
            this.report.Name = "report";
            this.report.ServerReport.BearerToken = null;
            this.report.Size = new System.Drawing.Size(697, 450);
            this.report.TabIndex = 0;
            this.report.Load += new System.EventHandler(this.Report_Load);
            // 
            // PrintPhieuMuonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.report);
            this.Name = "PrintPhieuMuonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In phiếu mượn";
            this.Load += new System.EventHandler(this.PrintPhieuMuonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookPhieuMuonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer report;
        private System.Windows.Forms.BindingSource BookPhieuMuonBindingSource;
    }
}