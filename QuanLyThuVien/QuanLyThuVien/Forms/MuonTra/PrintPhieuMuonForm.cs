using Microsoft.Reporting.WinForms;
using QuanLyThuVien.BookDetails;
using QuanLyThuVien.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms.MuonTra
{
    public partial class PrintPhieuMuonForm : Form
    {
        public PrintPhieuMuonForm()
        {
            InitializeComponent();
        }

        int readerID;
        string readerName;
        string className;
        List<BookPhieuMuon> books;

        public int ReaderID { get => readerID; set => readerID = value; }
        public string ReaderName { get => readerName; set => readerName = value; }
        public string ClassName { get => className; set => className = value; }
        public List<BookPhieuMuon> Books { get => books; set => books = value; }

        public PrintPhieuMuonForm(int readerID, string readerName, string className, List<BookPhieuMuon> books)
        {
            ReaderID = readerID;
            ReaderName = readerName;
            ClassName = className;
            Books = books;
            InitializeComponent();
        }

        private void PrintPhieuMuonForm_Load(object sender, EventArgs e)
        {

        }

        private void Report_Load(object sender, EventArgs e)
        {
            this.BookPhieuMuonBindingSource.DataSource = Books;
            ReportParameter[] param = new ReportParameter[] {
                new ReportParameter("readerID", ReaderID.ToString()),
                new ReportParameter("readerName", ReaderName),
                new ReportParameter("readerClass", ClassName),
                new ReportParameter("bookAmount", Books.Count.ToString())
            };
            this.report.LocalReport.SetParameters(param);
            this.report.RefreshReport();
        }
    }
}
