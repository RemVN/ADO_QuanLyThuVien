namespace QuanLyThuVien.Forms
{
    partial class BookForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bookGrid = new System.Windows.Forms.DataGridView();
            this.maSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namXBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenViTriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNXBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTacGiaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MuonTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sachDataSet = new QuanLyThuVien.QuanLyThuVienDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonAddTacGia = new System.Windows.Forms.Button();
            this.tacGiaGrid = new System.Windows.Forms.DataGridView();
            this.maTGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTacGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tacGiaDataSet = new QuanLyThuVien.QuanLyThuVienDataSet1();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bookTypeGrid = new System.Windows.Forms.DataGridView();
            this.maLoaiSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiSachDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiSachDataSet = new QuanLyThuVien.QuanLyThuVienDataSet2();
            this.buttonAddBookType = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.nxbGrid = new System.Windows.Forms.DataGridView();
            this.maNXBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNXBDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nXBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nxbDataSet = new QuanLyThuVien.QuanLyThuVienDataSet3();
            this.buttonAddNXB = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.locationGrid = new System.Windows.Forms.DataGridView();
            this.maViTriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenViTriDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viTriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viTriDataSet = new QuanLyThuVien.QuanLyThuVienDataSet4();
            this.buttonAddLocation = new System.Windows.Forms.Button();
            this.bookDetailImages = new System.Windows.Forms.ImageList(this.components);
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.searchBookID = new System.Windows.Forms.TextBox();
            this.searchBookName = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.searchBookStatus = new System.Windows.Forms.ComboBox();
            this.searchBookAuthor = new System.Windows.Forms.ComboBox();
            this.bookAuthorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchBookNXB = new System.Windows.Forms.ComboBox();
            this.bookNXBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchBookType = new System.Windows.Forms.ComboBox();
            this.bookTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchBookYear = new System.Windows.Forms.NumericUpDown();
            this.searchBookLocation = new System.Windows.Forms.ComboBox();
            this.bookLocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchBookPrice = new System.Windows.Forms.NumericUpDown();
            this.getSachTableAdapter = new QuanLyThuVien.QuanLyThuVienDataSetTableAdapters.getSachTableAdapter();
            this.tacGiaTableAdapter = new QuanLyThuVien.QuanLyThuVienDataSet1TableAdapters.TacGiaTableAdapter();
            this.loaiSachTableAdapter = new QuanLyThuVien.QuanLyThuVienDataSet2TableAdapters.LoaiSachTableAdapter();
            this.nXBTableAdapter = new QuanLyThuVien.QuanLyThuVienDataSet3TableAdapters.NXBTableAdapter();
            this.viTriTableAdapter = new QuanLyThuVien.QuanLyThuVienDataSet4TableAdapters.ViTriTableAdapter();
            this.searchMuonTra = new System.Windows.Forms.ComboBox();
            this.muonTraStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonClearSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tacGiaGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacGiaDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookTypeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSachDataSet)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nxbGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nXBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nxbDataSet)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viTriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viTriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookAuthorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookNXBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBookYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookLocationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBookPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muonTraStatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bookGrid
            // 
            this.bookGrid.AllowUserToAddRows = false;
            this.bookGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bookGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bookGrid.AutoGenerateColumns = false;
            this.bookGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.bookGrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.bookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSachDataGridViewTextBoxColumn,
            this.tenSachDataGridViewTextBoxColumn,
            this.tinhTrangDataGridViewTextBoxColumn,
            this.namXBDataGridViewTextBoxColumn,
            this.giaSachDataGridViewTextBoxColumn,
            this.tenLoaiSachDataGridViewTextBoxColumn,
            this.tenViTriDataGridViewTextBoxColumn,
            this.tenNXBDataGridViewTextBoxColumn,
            this.tenTacGiaDataGridViewTextBoxColumn1,
            this.MuonTra});
            this.bookGrid.DataSource = this.getSachBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.bookGrid.Location = new System.Drawing.Point(12, 70);
            this.bookGrid.Name = "bookGrid";
            this.bookGrid.ReadOnly = true;
            this.bookGrid.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bookGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bookGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookGrid.Size = new System.Drawing.Size(830, 599);
            this.bookGrid.TabIndex = 0;
            this.bookGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BookGrid_MouseClick);
            // 
            // maSachDataGridViewTextBoxColumn
            // 
            this.maSachDataGridViewTextBoxColumn.DataPropertyName = "MaSach";
            this.maSachDataGridViewTextBoxColumn.HeaderText = "Mã sách";
            this.maSachDataGridViewTextBoxColumn.Name = "maSachDataGridViewTextBoxColumn";
            this.maSachDataGridViewTextBoxColumn.ReadOnly = true;
            this.maSachDataGridViewTextBoxColumn.Width = 40;
            // 
            // tenSachDataGridViewTextBoxColumn
            // 
            this.tenSachDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenSachDataGridViewTextBoxColumn.DataPropertyName = "TenSach";
            this.tenSachDataGridViewTextBoxColumn.HeaderText = "Tên sách";
            this.tenSachDataGridViewTextBoxColumn.Name = "tenSachDataGridViewTextBoxColumn";
            this.tenSachDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tinhTrangDataGridViewTextBoxColumn
            // 
            this.tinhTrangDataGridViewTextBoxColumn.DataPropertyName = "TinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.HeaderText = "Trình trạng";
            this.tinhTrangDataGridViewTextBoxColumn.Name = "tinhTrangDataGridViewTextBoxColumn";
            this.tinhTrangDataGridViewTextBoxColumn.ReadOnly = true;
            this.tinhTrangDataGridViewTextBoxColumn.Width = 50;
            // 
            // namXBDataGridViewTextBoxColumn
            // 
            this.namXBDataGridViewTextBoxColumn.DataPropertyName = "NamXB";
            this.namXBDataGridViewTextBoxColumn.HeaderText = "Năm XB";
            this.namXBDataGridViewTextBoxColumn.Name = "namXBDataGridViewTextBoxColumn";
            this.namXBDataGridViewTextBoxColumn.ReadOnly = true;
            this.namXBDataGridViewTextBoxColumn.Width = 60;
            // 
            // giaSachDataGridViewTextBoxColumn
            // 
            this.giaSachDataGridViewTextBoxColumn.DataPropertyName = "GiaSach";
            this.giaSachDataGridViewTextBoxColumn.HeaderText = "Giá sách";
            this.giaSachDataGridViewTextBoxColumn.Name = "giaSachDataGridViewTextBoxColumn";
            this.giaSachDataGridViewTextBoxColumn.ReadOnly = true;
            this.giaSachDataGridViewTextBoxColumn.Width = 80;
            // 
            // tenLoaiSachDataGridViewTextBoxColumn
            // 
            this.tenLoaiSachDataGridViewTextBoxColumn.DataPropertyName = "TenLoaiSach";
            this.tenLoaiSachDataGridViewTextBoxColumn.HeaderText = "Loại sách";
            this.tenLoaiSachDataGridViewTextBoxColumn.Name = "tenLoaiSachDataGridViewTextBoxColumn";
            this.tenLoaiSachDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenViTriDataGridViewTextBoxColumn
            // 
            this.tenViTriDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenViTriDataGridViewTextBoxColumn.DataPropertyName = "TenViTri";
            this.tenViTriDataGridViewTextBoxColumn.HeaderText = "Vị trí";
            this.tenViTriDataGridViewTextBoxColumn.Name = "tenViTriDataGridViewTextBoxColumn";
            this.tenViTriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenNXBDataGridViewTextBoxColumn
            // 
            this.tenNXBDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenNXBDataGridViewTextBoxColumn.DataPropertyName = "TenNXB";
            this.tenNXBDataGridViewTextBoxColumn.HeaderText = "NXB";
            this.tenNXBDataGridViewTextBoxColumn.Name = "tenNXBDataGridViewTextBoxColumn";
            this.tenNXBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenTacGiaDataGridViewTextBoxColumn1
            // 
            this.tenTacGiaDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenTacGiaDataGridViewTextBoxColumn1.DataPropertyName = "TenTacGia";
            this.tenTacGiaDataGridViewTextBoxColumn1.HeaderText = "Tác giả";
            this.tenTacGiaDataGridViewTextBoxColumn1.Name = "tenTacGiaDataGridViewTextBoxColumn1";
            this.tenTacGiaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // MuonTra
            // 
            this.MuonTra.DataPropertyName = "MuonTra";
            this.MuonTra.HeaderText = "Mượn Trả";
            this.MuonTra.Name = "MuonTra";
            this.MuonTra.ReadOnly = true;
            this.MuonTra.Width = 70;
            // 
            // getSachBindingSource
            // 
            this.getSachBindingSource.DataMember = "getSach";
            this.getSachBindingSource.DataSource = this.sachDataSet;
            // 
            // sachDataSet
            // 
            this.sachDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.sachDataSet.EnforceConstraints = false;
            this.sachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.bookDetailImages;
            this.tabControl1.Location = new System.Drawing.Point(859, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(396, 657);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.buttonAddTacGia);
            this.tabPage1.Controls.Add(this.tacGiaGrid);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(388, 614);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tác giả";
            // 
            // buttonAddTacGia
            // 
            this.buttonAddTacGia.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddTacGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddTacGia.FlatAppearance.BorderSize = 0;
            this.buttonAddTacGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTacGia.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddTacGia.Image")));
            this.buttonAddTacGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddTacGia.Location = new System.Drawing.Point(7, 9);
            this.buttonAddTacGia.Name = "buttonAddTacGia";
            this.buttonAddTacGia.Size = new System.Drawing.Size(121, 30);
            this.buttonAddTacGia.TabIndex = 20;
            this.buttonAddTacGia.Text = "Thêm tác giả";
            this.buttonAddTacGia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddTacGia.UseVisualStyleBackColor = false;
            this.buttonAddTacGia.Click += new System.EventHandler(this.ButtonAddTacGia_Click);
            // 
            // tacGiaGrid
            // 
            this.tacGiaGrid.AllowUserToAddRows = false;
            this.tacGiaGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tacGiaGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tacGiaGrid.AutoGenerateColumns = false;
            this.tacGiaGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.tacGiaGrid.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.NullValue = "không có";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tacGiaGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tacGiaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tacGiaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTGDataGridViewTextBoxColumn,
            this.tenTacGiaDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn1});
            this.tacGiaGrid.DataSource = this.tacGiaBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tacGiaGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.tacGiaGrid.Location = new System.Drawing.Point(7, 52);
            this.tacGiaGrid.Name = "tacGiaGrid";
            this.tacGiaGrid.ReadOnly = true;
            this.tacGiaGrid.RowHeadersVisible = false;
            this.tacGiaGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tacGiaGrid.Size = new System.Drawing.Size(373, 556);
            this.tacGiaGrid.TabIndex = 0;
            this.tacGiaGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TacGiaGrid_MouseClick);
            // 
            // maTGDataGridViewTextBoxColumn
            // 
            this.maTGDataGridViewTextBoxColumn.DataPropertyName = "MaTG";
            this.maTGDataGridViewTextBoxColumn.HeaderText = "Mã";
            this.maTGDataGridViewTextBoxColumn.Name = "maTGDataGridViewTextBoxColumn";
            this.maTGDataGridViewTextBoxColumn.ReadOnly = true;
            this.maTGDataGridViewTextBoxColumn.Width = 50;
            // 
            // tenTacGiaDataGridViewTextBoxColumn
            // 
            this.tenTacGiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenTacGiaDataGridViewTextBoxColumn.DataPropertyName = "TenTacGia";
            this.tenTacGiaDataGridViewTextBoxColumn.HeaderText = "Tên tác giả";
            this.tenTacGiaDataGridViewTextBoxColumn.Name = "tenTacGiaDataGridViewTextBoxColumn";
            this.tenTacGiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sDTDataGridViewTextBoxColumn1
            // 
            this.sDTDataGridViewTextBoxColumn1.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn1.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn1.Name = "sDTDataGridViewTextBoxColumn1";
            this.sDTDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sDTDataGridViewTextBoxColumn1.Width = 150;
            // 
            // tacGiaBindingSource
            // 
            this.tacGiaBindingSource.DataMember = "TacGia";
            this.tacGiaBindingSource.DataSource = this.tacGiaDataSet;
            // 
            // tacGiaDataSet
            // 
            this.tacGiaDataSet.DataSetName = "tacGiaDS";
            this.tacGiaDataSet.EnforceConstraints = false;
            this.tacGiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bookTypeGrid);
            this.tabPage2.Controls.Add(this.buttonAddBookType);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(388, 614);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Loại sách";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bookTypeGrid
            // 
            this.bookTypeGrid.AllowUserToAddRows = false;
            this.bookTypeGrid.AllowUserToDeleteRows = false;
            this.bookTypeGrid.AutoGenerateColumns = false;
            this.bookTypeGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.bookTypeGrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.bookTypeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookTypeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLoaiSachDataGridViewTextBoxColumn,
            this.tenLoaiSachDataGridViewTextBoxColumn1});
            this.bookTypeGrid.DataSource = this.loaiSachBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookTypeGrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.bookTypeGrid.Location = new System.Drawing.Point(6, 52);
            this.bookTypeGrid.Name = "bookTypeGrid";
            this.bookTypeGrid.ReadOnly = true;
            this.bookTypeGrid.RowHeadersVisible = false;
            this.bookTypeGrid.Size = new System.Drawing.Size(373, 556);
            this.bookTypeGrid.TabIndex = 22;
            this.bookTypeGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BookTypeGrid_MouseClick);
            // 
            // maLoaiSachDataGridViewTextBoxColumn
            // 
            this.maLoaiSachDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiSach";
            this.maLoaiSachDataGridViewTextBoxColumn.HeaderText = "Mã";
            this.maLoaiSachDataGridViewTextBoxColumn.Name = "maLoaiSachDataGridViewTextBoxColumn";
            this.maLoaiSachDataGridViewTextBoxColumn.ReadOnly = true;
            this.maLoaiSachDataGridViewTextBoxColumn.Width = 50;
            // 
            // tenLoaiSachDataGridViewTextBoxColumn1
            // 
            this.tenLoaiSachDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenLoaiSachDataGridViewTextBoxColumn1.DataPropertyName = "TenLoaiSach";
            this.tenLoaiSachDataGridViewTextBoxColumn1.HeaderText = "Tên loại sách";
            this.tenLoaiSachDataGridViewTextBoxColumn1.Name = "tenLoaiSachDataGridViewTextBoxColumn1";
            this.tenLoaiSachDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // loaiSachBindingSource
            // 
            this.loaiSachBindingSource.DataMember = "LoaiSach";
            this.loaiSachBindingSource.DataSource = this.loaiSachDataSet;
            // 
            // loaiSachDataSet
            // 
            this.loaiSachDataSet.DataSetName = "QuanLyThuVienDataSet2";
            this.loaiSachDataSet.EnforceConstraints = false;
            this.loaiSachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonAddBookType
            // 
            this.buttonAddBookType.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddBookType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddBookType.FlatAppearance.BorderSize = 0;
            this.buttonAddBookType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBookType.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddBookType.Image")));
            this.buttonAddBookType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddBookType.Location = new System.Drawing.Point(6, 9);
            this.buttonAddBookType.Name = "buttonAddBookType";
            this.buttonAddBookType.Size = new System.Drawing.Size(134, 30);
            this.buttonAddBookType.TabIndex = 21;
            this.buttonAddBookType.Text = "Thêm loại sách";
            this.buttonAddBookType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddBookType.UseVisualStyleBackColor = false;
            this.buttonAddBookType.Click += new System.EventHandler(this.ButtonAddBookType_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.nxbGrid);
            this.tabPage3.Controls.Add(this.buttonAddNXB);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(388, 614);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "NXB";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // nxbGrid
            // 
            this.nxbGrid.AllowUserToAddRows = false;
            this.nxbGrid.AllowUserToDeleteRows = false;
            this.nxbGrid.AutoGenerateColumns = false;
            this.nxbGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.nxbGrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.nxbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nxbGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNXBDataGridViewTextBoxColumn,
            this.tenNXBDataGridViewTextBoxColumn1});
            this.nxbGrid.DataSource = this.nXBBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nxbGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.nxbGrid.Location = new System.Drawing.Point(6, 52);
            this.nxbGrid.Name = "nxbGrid";
            this.nxbGrid.ReadOnly = true;
            this.nxbGrid.RowHeadersVisible = false;
            this.nxbGrid.Size = new System.Drawing.Size(373, 556);
            this.nxbGrid.TabIndex = 24;
            this.nxbGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NxbGrid_MouseClick);
            // 
            // maNXBDataGridViewTextBoxColumn
            // 
            this.maNXBDataGridViewTextBoxColumn.DataPropertyName = "MaNXB";
            this.maNXBDataGridViewTextBoxColumn.HeaderText = "Mã";
            this.maNXBDataGridViewTextBoxColumn.Name = "maNXBDataGridViewTextBoxColumn";
            this.maNXBDataGridViewTextBoxColumn.ReadOnly = true;
            this.maNXBDataGridViewTextBoxColumn.Width = 50;
            // 
            // tenNXBDataGridViewTextBoxColumn1
            // 
            this.tenNXBDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenNXBDataGridViewTextBoxColumn1.DataPropertyName = "TenNXB";
            this.tenNXBDataGridViewTextBoxColumn1.HeaderText = "Tên nhà xuất bản";
            this.tenNXBDataGridViewTextBoxColumn1.Name = "tenNXBDataGridViewTextBoxColumn1";
            this.tenNXBDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nXBBindingSource
            // 
            this.nXBBindingSource.DataMember = "NXB";
            this.nXBBindingSource.DataSource = this.nxbDataSet;
            // 
            // nxbDataSet
            // 
            this.nxbDataSet.DataSetName = "QuanLyThuVienDataSet3";
            this.nxbDataSet.EnforceConstraints = false;
            this.nxbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonAddNXB
            // 
            this.buttonAddNXB.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddNXB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddNXB.FlatAppearance.BorderSize = 0;
            this.buttonAddNXB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNXB.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddNXB.Image")));
            this.buttonAddNXB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddNXB.Location = new System.Drawing.Point(6, 8);
            this.buttonAddNXB.Name = "buttonAddNXB";
            this.buttonAddNXB.Size = new System.Drawing.Size(134, 30);
            this.buttonAddNXB.TabIndex = 23;
            this.buttonAddNXB.Text = "Thêm NXB";
            this.buttonAddNXB.UseVisualStyleBackColor = false;
            this.buttonAddNXB.Click += new System.EventHandler(this.ButtonAddNXB_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.locationGrid);
            this.tabPage4.Controls.Add(this.buttonAddLocation);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.ImageIndex = 3;
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(388, 614);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Vị trí";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // locationGrid
            // 
            this.locationGrid.AllowUserToAddRows = false;
            this.locationGrid.AllowUserToDeleteRows = false;
            this.locationGrid.AutoGenerateColumns = false;
            this.locationGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.locationGrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.locationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locationGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maViTriDataGridViewTextBoxColumn,
            this.tenViTriDataGridViewTextBoxColumn1});
            this.locationGrid.DataSource = this.viTriBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.locationGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.locationGrid.Location = new System.Drawing.Point(6, 52);
            this.locationGrid.Name = "locationGrid";
            this.locationGrid.ReadOnly = true;
            this.locationGrid.RowHeadersVisible = false;
            this.locationGrid.Size = new System.Drawing.Size(373, 556);
            this.locationGrid.TabIndex = 26;
            this.locationGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LocationGrid_MouseClick);
            // 
            // maViTriDataGridViewTextBoxColumn
            // 
            this.maViTriDataGridViewTextBoxColumn.DataPropertyName = "MaViTri";
            this.maViTriDataGridViewTextBoxColumn.HeaderText = "Mã";
            this.maViTriDataGridViewTextBoxColumn.Name = "maViTriDataGridViewTextBoxColumn";
            this.maViTriDataGridViewTextBoxColumn.ReadOnly = true;
            this.maViTriDataGridViewTextBoxColumn.Width = 50;
            // 
            // tenViTriDataGridViewTextBoxColumn1
            // 
            this.tenViTriDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenViTriDataGridViewTextBoxColumn1.DataPropertyName = "TenViTri";
            this.tenViTriDataGridViewTextBoxColumn1.HeaderText = "Tên vị trí";
            this.tenViTriDataGridViewTextBoxColumn1.Name = "tenViTriDataGridViewTextBoxColumn1";
            this.tenViTriDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // viTriBindingSource
            // 
            this.viTriBindingSource.DataMember = "ViTri";
            this.viTriBindingSource.DataSource = this.viTriDataSet;
            // 
            // viTriDataSet
            // 
            this.viTriDataSet.DataSetName = "QuanLyThuVienDataSet4";
            this.viTriDataSet.EnforceConstraints = false;
            this.viTriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonAddLocation
            // 
            this.buttonAddLocation.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddLocation.FlatAppearance.BorderSize = 0;
            this.buttonAddLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddLocation.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddLocation.Image")));
            this.buttonAddLocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddLocation.Location = new System.Drawing.Point(6, 8);
            this.buttonAddLocation.Name = "buttonAddLocation";
            this.buttonAddLocation.Size = new System.Drawing.Size(134, 30);
            this.buttonAddLocation.TabIndex = 25;
            this.buttonAddLocation.Text = "Thêm vị trí";
            this.buttonAddLocation.UseVisualStyleBackColor = false;
            this.buttonAddLocation.Click += new System.EventHandler(this.ButtonAddLocation_Click);
            // 
            // bookDetailImages
            // 
            this.bookDetailImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("bookDetailImages.ImageStream")));
            this.bookDetailImages.TransparentColor = System.Drawing.Color.Transparent;
            this.bookDetailImages.Images.SetKeyName(0, "people.png");
            this.bookDetailImages.Images.SetKeyName(1, "book.png");
            this.bookDetailImages.Images.SetKeyName(2, "jigsaw.png");
            this.bookDetailImages.Images.SetKeyName(3, "pin.png");
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddBook.FlatAppearance.BorderSize = 0;
            this.buttonAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBook.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddBook.Image")));
            this.buttonAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddBook.Location = new System.Drawing.Point(12, -1);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(110, 30);
            this.buttonAddBook.TabIndex = 18;
            this.buttonAddBook.Text = "Thêm sách";
            this.buttonAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddBook.UseVisualStyleBackColor = false;
            this.buttonAddBook.Click += new System.EventHandler(this.ButtonAddBook_Click);
            // 
            // searchBookID
            // 
            this.searchBookID.BackColor = System.Drawing.Color.White;
            this.searchBookID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBookID.ForeColor = System.Drawing.Color.Black;
            this.searchBookID.Location = new System.Drawing.Point(12, 44);
            this.searchBookID.Name = "searchBookID";
            this.searchBookID.Size = new System.Drawing.Size(41, 20);
            this.searchBookID.TabIndex = 20;
            // 
            // searchBookName
            // 
            this.searchBookName.Location = new System.Drawing.Point(59, 44);
            this.searchBookName.Name = "searchBookName";
            this.searchBookName.Size = new System.Drawing.Size(99, 20);
            this.searchBookName.TabIndex = 21;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(747, -1);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(95, 31);
            this.buttonSearch.TabIndex = 29;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.Location = new System.Drawing.Point(128, -1);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(85, 30);
            this.buttonRefresh.TabIndex = 30;
            this.buttonRefresh.Text = "Tải lại";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // searchBookStatus
            // 
            this.searchBookStatus.FormattingEnabled = true;
            this.searchBookStatus.Items.AddRange(new object[] {
            "Mới",
            "Cũ",
            "Mất"});
            this.searchBookStatus.Location = new System.Drawing.Point(164, 44);
            this.searchBookStatus.Name = "searchBookStatus";
            this.searchBookStatus.Size = new System.Drawing.Size(38, 21);
            this.searchBookStatus.TabIndex = 31;
            // 
            // searchBookAuthor
            // 
            this.searchBookAuthor.DataSource = this.bookAuthorBindingSource;
            this.searchBookAuthor.DisplayMember = "Name";
            this.searchBookAuthor.FormattingEnabled = true;
            this.searchBookAuthor.Location = new System.Drawing.Point(669, 45);
            this.searchBookAuthor.Name = "searchBookAuthor";
            this.searchBookAuthor.Size = new System.Drawing.Size(102, 21);
            this.searchBookAuthor.TabIndex = 32;
            this.searchBookAuthor.ValueMember = "Name";
            // 
            // bookAuthorBindingSource
            // 
            this.bookAuthorBindingSource.DataSource = typeof(QuanLyThuVien.BookDetails.BookAuthor);
            // 
            // searchBookNXB
            // 
            this.searchBookNXB.DataSource = this.bookNXBBindingSource;
            this.searchBookNXB.DisplayMember = "Name";
            this.searchBookNXB.FormattingEnabled = true;
            this.searchBookNXB.Location = new System.Drawing.Point(555, 45);
            this.searchBookNXB.Name = "searchBookNXB";
            this.searchBookNXB.Size = new System.Drawing.Size(108, 21);
            this.searchBookNXB.TabIndex = 33;
            this.searchBookNXB.ValueMember = "Name";
            // 
            // bookNXBBindingSource
            // 
            this.bookNXBBindingSource.DataSource = typeof(QuanLyThuVien.BookDetails.BookNXB);
            // 
            // searchBookType
            // 
            this.searchBookType.DataSource = this.bookTypeBindingSource;
            this.searchBookType.DisplayMember = "Name";
            this.searchBookType.FormattingEnabled = true;
            this.searchBookType.Location = new System.Drawing.Point(348, 45);
            this.searchBookType.Name = "searchBookType";
            this.searchBookType.Size = new System.Drawing.Size(102, 21);
            this.searchBookType.TabIndex = 34;
            this.searchBookType.ValueMember = "Name";
            // 
            // bookTypeBindingSource
            // 
            this.bookTypeBindingSource.DataSource = typeof(QuanLyThuVien.BookDetails.BookType);
            // 
            // searchBookYear
            // 
            this.searchBookYear.Location = new System.Drawing.Point(208, 45);
            this.searchBookYear.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.searchBookYear.Name = "searchBookYear";
            this.searchBookYear.Size = new System.Drawing.Size(58, 20);
            this.searchBookYear.TabIndex = 35;
            this.searchBookYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // searchBookLocation
            // 
            this.searchBookLocation.DataSource = this.bookLocationBindingSource;
            this.searchBookLocation.DisplayMember = "Name";
            this.searchBookLocation.FormattingEnabled = true;
            this.searchBookLocation.Location = new System.Drawing.Point(456, 45);
            this.searchBookLocation.Name = "searchBookLocation";
            this.searchBookLocation.Size = new System.Drawing.Size(93, 21);
            this.searchBookLocation.TabIndex = 36;
            this.searchBookLocation.ValueMember = "Name";
            // 
            // bookLocationBindingSource
            // 
            this.bookLocationBindingSource.DataSource = typeof(QuanLyThuVien.BookDetails.BookLocation);
            // 
            // searchBookPrice
            // 
            this.searchBookPrice.Location = new System.Drawing.Point(272, 45);
            this.searchBookPrice.Name = "searchBookPrice";
            this.searchBookPrice.Size = new System.Drawing.Size(70, 20);
            this.searchBookPrice.TabIndex = 37;
            // 
            // getSachTableAdapter
            // 
            this.getSachTableAdapter.ClearBeforeFill = true;
            // 
            // tacGiaTableAdapter
            // 
            this.tacGiaTableAdapter.ClearBeforeFill = true;
            // 
            // loaiSachTableAdapter
            // 
            this.loaiSachTableAdapter.ClearBeforeFill = true;
            // 
            // nXBTableAdapter
            // 
            this.nXBTableAdapter.ClearBeforeFill = true;
            // 
            // viTriTableAdapter
            // 
            this.viTriTableAdapter.ClearBeforeFill = true;
            // 
            // searchMuonTra
            // 
            this.searchMuonTra.DataSource = this.muonTraStatusBindingSource;
            this.searchMuonTra.DisplayMember = "Name";
            this.searchMuonTra.FormattingEnabled = true;
            this.searchMuonTra.Location = new System.Drawing.Point(777, 45);
            this.searchMuonTra.Name = "searchMuonTra";
            this.searchMuonTra.Size = new System.Drawing.Size(65, 21);
            this.searchMuonTra.TabIndex = 39;
            this.searchMuonTra.ValueMember = "Id";
            // 
            // muonTraStatusBindingSource
            // 
            this.muonTraStatusBindingSource.DataSource = typeof(QuanLyThuVien.MuonTra.MuonTraStatus);
            // 
            // buttonClearSearch
            // 
            this.buttonClearSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonClearSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClearSearch.FlatAppearance.BorderSize = 0;
            this.buttonClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonClearSearch.Image")));
            this.buttonClearSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClearSearch.Location = new System.Drawing.Point(581, -1);
            this.buttonClearSearch.Name = "buttonClearSearch";
            this.buttonClearSearch.Size = new System.Drawing.Size(160, 31);
            this.buttonClearSearch.TabIndex = 40;
            this.buttonClearSearch.Text = "Xoá khung tìm kiếm";
            this.buttonClearSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClearSearch.UseVisualStyleBackColor = false;
            this.buttonClearSearch.Click += new System.EventHandler(this.ButtonClearSearch_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1267, 680);
            this.Controls.Add(this.buttonClearSearch);
            this.Controls.Add(this.searchMuonTra);
            this.Controls.Add(this.searchBookPrice);
            this.Controls.Add(this.searchBookLocation);
            this.Controls.Add(this.searchBookYear);
            this.Controls.Add(this.searchBookType);
            this.Controls.Add(this.searchBookNXB);
            this.Controls.Add(this.searchBookAuthor);
            this.Controls.Add(this.searchBookStatus);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.searchBookName);
            this.Controls.Add(this.searchBookID);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bookGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tacGiaGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacGiaDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookTypeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSachDataSet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nxbGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nXBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nxbDataSet)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.locationGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viTriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viTriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookAuthorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookNXBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBookYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookLocationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBookPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muonTraStatusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ImageList bookDetailImages;
        private System.Windows.Forms.Button buttonAddBook;
        public System.Windows.Forms.DataGridView bookGrid;
        private System.Windows.Forms.Button buttonAddTacGia;
        public System.Windows.Forms.DataGridView tacGiaGrid;
        private System.Windows.Forms.Button buttonAddBookType;
        private System.Windows.Forms.Button buttonAddNXB;
        private System.Windows.Forms.Button buttonAddLocation;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRefresh;
        public System.Windows.Forms.BindingSource bookAuthorBindingSource;
        public System.Windows.Forms.TextBox searchBookID;
        public System.Windows.Forms.TextBox searchBookName;
        public System.Windows.Forms.ComboBox searchBookStatus;
        public System.Windows.Forms.NumericUpDown searchBookYear;
        public System.Windows.Forms.NumericUpDown searchBookPrice;
        public System.Windows.Forms.ComboBox searchBookType;
        public System.Windows.Forms.ComboBox searchBookLocation;
        public System.Windows.Forms.ComboBox searchBookNXB;
        public System.Windows.Forms.ComboBox searchBookAuthor;
        public System.Windows.Forms.BindingSource bookNXBBindingSource;
        public System.Windows.Forms.BindingSource bookLocationBindingSource;
        public System.Windows.Forms.BindingSource bookTypeBindingSource;
        private System.Windows.Forms.BindingSource getSachBindingSource;
        private QuanLyThuVienDataSet sachDataSet;
        private QuanLyThuVienDataSetTableAdapters.getSachTableAdapter getSachTableAdapter;
        private QuanLyThuVienDataSet1 tacGiaDataSet;
        private System.Windows.Forms.BindingSource tacGiaBindingSource;
        private QuanLyThuVienDataSet1TableAdapters.TacGiaTableAdapter tacGiaTableAdapter;
        public System.Windows.Forms.DataGridView bookTypeGrid;
        public System.Windows.Forms.DataGridView nxbGrid;
        public System.Windows.Forms.DataGridView locationGrid;
        private QuanLyThuVienDataSet2 loaiSachDataSet;
        private System.Windows.Forms.BindingSource loaiSachBindingSource;
        private QuanLyThuVienDataSet2TableAdapters.LoaiSachTableAdapter loaiSachTableAdapter;
        private QuanLyThuVienDataSet3 nxbDataSet;
        private System.Windows.Forms.BindingSource nXBBindingSource;
        private QuanLyThuVienDataSet3TableAdapters.NXBTableAdapter nXBTableAdapter;
        private QuanLyThuVienDataSet4 viTriDataSet;
        private System.Windows.Forms.BindingSource viTriBindingSource;
        private QuanLyThuVienDataSet4TableAdapters.ViTriTableAdapter viTriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTacGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiSachDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNXBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNXBDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maViTriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenViTriDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namXBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenViTriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNXBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTacGiaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MuonTra;
        public System.Windows.Forms.ComboBox searchMuonTra;
        private System.Windows.Forms.BindingSource muonTraStatusBindingSource;
        private System.Windows.Forms.Button buttonClearSearch;
    }
}