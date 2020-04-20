namespace QuanLyThuVien.Forms
{
    partial class ReaderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.locationGrid = new System.Windows.Forms.DataGridView();
            this.khoaGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet8 = new QuanLyThuVien.QuanLyThuVienDataSet8();
            this.buttonAddKhoa = new System.Windows.Forms.Button();
            this.buttonClearSearch = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.readerGrid = new System.Windows.Forms.DataGridView();
            this.maSoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHetHanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchSinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet7 = new QuanLyThuVien.QuanLyThuVienDataSet7();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.searchSinhVienTableAdapter = new QuanLyThuVien.QuanLyThuVienDataSet7TableAdapters.searchSinhVienTableAdapter();
            this.searchBirthday = new QuanLyThuVien.CustomControl.EDateTimePicker();
            this.searchLocation = new System.Windows.Forms.TextBox();
            this.searchSDT = new System.Windows.Forms.TextBox();
            this.searchSex = new System.Windows.Forms.ComboBox();
            this.searchRealname = new System.Windows.Forms.TextBox();
            this.searchID = new System.Windows.Forms.TextBox();
            this.searchKhoa = new System.Windows.Forms.ComboBox();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchClass = new System.Windows.Forms.ComboBox();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchNgayCap = new QuanLyThuVien.CustomControl.EDateTimePicker();
            this.searchHetHan = new QuanLyThuVien.CustomControl.EDateTimePicker();
            this.khoaTableAdapter = new QuanLyThuVien.QuanLyThuVienDataSet8TableAdapters.KhoaTableAdapter();
            this.maKhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhoaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddClass = new System.Windows.Forms.Button();
            this.quanLyThuVienDataSet9 = new QuanLyThuVien.QuanLyThuVienDataSet9();
            this.classGridBindingSouce = new System.Windows.Forms.BindingSource(this.components);
            this.lopTableAdapter = new QuanLyThuVien.QuanLyThuVienDataSet9TableAdapters.LopTableAdapter();
            this.maLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLopDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchSinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet7)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classGridBindingSouce)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.locationGrid);
            this.tabPage4.Controls.Add(this.buttonAddKhoa);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.ImageIndex = 3;
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(388, 628);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Khoa";
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
            this.maKhoaDataGridViewTextBoxColumn,
            this.tenKhoaDataGridViewTextBoxColumn1});
            this.locationGrid.DataSource = this.khoaGridBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.locationGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.locationGrid.Location = new System.Drawing.Point(6, 52);
            this.locationGrid.Name = "locationGrid";
            this.locationGrid.ReadOnly = true;
            this.locationGrid.RowHeadersVisible = false;
            this.locationGrid.Size = new System.Drawing.Size(373, 570);
            this.locationGrid.TabIndex = 26;
            // 
            // khoaGridBindingSource
            // 
            this.khoaGridBindingSource.DataMember = "Khoa";
            this.khoaGridBindingSource.DataSource = this.quanLyThuVienDataSet8;
            // 
            // quanLyThuVienDataSet8
            // 
            this.quanLyThuVienDataSet8.DataSetName = "QuanLyThuVienDataSet8";
            this.quanLyThuVienDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonAddKhoa
            // 
            this.buttonAddKhoa.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddKhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddKhoa.FlatAppearance.BorderSize = 0;
            this.buttonAddKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddKhoa.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddKhoa.Image")));
            this.buttonAddKhoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddKhoa.Location = new System.Drawing.Point(6, 8);
            this.buttonAddKhoa.Name = "buttonAddKhoa";
            this.buttonAddKhoa.Size = new System.Drawing.Size(134, 30);
            this.buttonAddKhoa.TabIndex = 25;
            this.buttonAddKhoa.Text = "Thêm khoa";
            this.buttonAddKhoa.UseVisualStyleBackColor = false;
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
            this.buttonClearSearch.Location = new System.Drawing.Point(581, 0);
            this.buttonClearSearch.Name = "buttonClearSearch";
            this.buttonClearSearch.Size = new System.Drawing.Size(160, 31);
            this.buttonClearSearch.TabIndex = 56;
            this.buttonClearSearch.Text = "Xoá khung tìm kiếm";
            this.buttonClearSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClearSearch.UseVisualStyleBackColor = false;
            this.buttonClearSearch.Click += new System.EventHandler(this.ButtonClearSearch_Click);
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
            this.buttonRefresh.Location = new System.Drawing.Point(153, 0);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(85, 30);
            this.buttonRefresh.TabIndex = 47;
            this.buttonRefresh.Text = "Tải lại";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
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
            this.buttonSearch.Location = new System.Drawing.Point(747, 0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(95, 31);
            this.buttonSearch.TabIndex = 46;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearch.UseVisualStyleBackColor = false;
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
            this.buttonAddBook.Location = new System.Drawing.Point(12, 0);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(135, 30);
            this.buttonAddBook.TabIndex = 43;
            this.buttonAddBook.Text = "Thêm độc giả";
            this.buttonAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddBook.UseVisualStyleBackColor = false;
            this.buttonAddBook.Click += new System.EventHandler(this.ButtonAddBook_Click);
            // 
            // readerGrid
            // 
            this.readerGrid.AllowUserToAddRows = false;
            this.readerGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.readerGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.readerGrid.AutoGenerateColumns = false;
            this.readerGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.readerGrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.readerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSoDataGridViewTextBoxColumn,
            this.tenKhoaDataGridViewTextBoxColumn,
            this.tenLopDataGridViewTextBoxColumn,
            this.ngayCapDataGridViewTextBoxColumn,
            this.ngayHetHanDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn});
            this.readerGrid.DataSource = this.searchSinhVienBindingSource;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.readerGrid.DefaultCellStyle = dataGridViewCellStyle13;
            this.readerGrid.Location = new System.Drawing.Point(12, 76);
            this.readerGrid.Name = "readerGrid";
            this.readerGrid.ReadOnly = true;
            this.readerGrid.RowHeadersVisible = false;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.readerGrid.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.readerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.readerGrid.Size = new System.Drawing.Size(830, 599);
            this.readerGrid.TabIndex = 41;
            // 
            // maSoDataGridViewTextBoxColumn
            // 
            this.maSoDataGridViewTextBoxColumn.DataPropertyName = "MaSo";
            this.maSoDataGridViewTextBoxColumn.HeaderText = "Mã số";
            this.maSoDataGridViewTextBoxColumn.Name = "maSoDataGridViewTextBoxColumn";
            this.maSoDataGridViewTextBoxColumn.ReadOnly = true;
            this.maSoDataGridViewTextBoxColumn.Width = 50;
            // 
            // tenKhoaDataGridViewTextBoxColumn
            // 
            this.tenKhoaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenKhoaDataGridViewTextBoxColumn.DataPropertyName = "TenKhoa";
            this.tenKhoaDataGridViewTextBoxColumn.HeaderText = "Tên khoa";
            this.tenKhoaDataGridViewTextBoxColumn.Name = "tenKhoaDataGridViewTextBoxColumn";
            this.tenKhoaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenLopDataGridViewTextBoxColumn
            // 
            this.tenLopDataGridViewTextBoxColumn.DataPropertyName = "TenLop";
            this.tenLopDataGridViewTextBoxColumn.HeaderText = "Tên lớp";
            this.tenLopDataGridViewTextBoxColumn.Name = "tenLopDataGridViewTextBoxColumn";
            this.tenLopDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenLopDataGridViewTextBoxColumn.Width = 70;
            // 
            // ngayCapDataGridViewTextBoxColumn
            // 
            this.ngayCapDataGridViewTextBoxColumn.DataPropertyName = "NgayCap";
            this.ngayCapDataGridViewTextBoxColumn.HeaderText = "Ngày cấp";
            this.ngayCapDataGridViewTextBoxColumn.Name = "ngayCapDataGridViewTextBoxColumn";
            this.ngayCapDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayCapDataGridViewTextBoxColumn.Width = 80;
            // 
            // ngayHetHanDataGridViewTextBoxColumn
            // 
            this.ngayHetHanDataGridViewTextBoxColumn.DataPropertyName = "NgayHetHan";
            this.ngayHetHanDataGridViewTextBoxColumn.HeaderText = "Ngày hết hạn";
            this.ngayHetHanDataGridViewTextBoxColumn.Name = "ngayHetHanDataGridViewTextBoxColumn";
            this.ngayHetHanDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayHetHanDataGridViewTextBoxColumn.Width = 80;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngaySinhDataGridViewTextBoxColumn.Width = 80;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới tinh";
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.gioiTinhDataGridViewTextBoxColumn.Width = 80;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDTDataGridViewTextBoxColumn.Width = 80;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            this.diaChiDataGridViewTextBoxColumn.Width = 130;
            // 
            // searchSinhVienBindingSource
            // 
            this.searchSinhVienBindingSource.DataMember = "searchSinhVien";
            this.searchSinhVienBindingSource.DataSource = this.quanLyThuVienDataSet7;
            // 
            // quanLyThuVienDataSet7
            // 
            this.quanLyThuVienDataSet7.DataSetName = "QuanLyThuVienDataSet7";
            this.quanLyThuVienDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(859, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(396, 657);
            this.tabControl1.TabIndex = 42;
            // 
            // searchSinhVienTableAdapter
            // 
            this.searchSinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // searchBirthday
            // 
            this.searchBirthday.CustomFormat = " ";
            this.searchBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.searchBirthday.Location = new System.Drawing.Point(468, 49);
            this.searchBirthday.MaxDate = new System.DateTime(2020, 4, 20, 11, 12, 25, 906);
            this.searchBirthday.MaxIsToday = true;
            this.searchBirthday.Name = "searchBirthday";
            this.searchBirthday.Size = new System.Drawing.Size(75, 20);
            this.searchBirthday.TabIndex = 65;
            this.searchBirthday.Value = new System.DateTime(2020, 4, 19, 20, 6, 53, 921);
            // 
            // searchLocation
            // 
            this.searchLocation.BackColor = System.Drawing.Color.White;
            this.searchLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchLocation.ForeColor = System.Drawing.Color.Black;
            this.searchLocation.Location = new System.Drawing.Point(710, 49);
            this.searchLocation.Name = "searchLocation";
            this.searchLocation.Size = new System.Drawing.Size(132, 20);
            this.searchLocation.TabIndex = 64;
            // 
            // searchSDT
            // 
            this.searchSDT.BackColor = System.Drawing.Color.White;
            this.searchSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchSDT.ForeColor = System.Drawing.Color.Black;
            this.searchSDT.Location = new System.Drawing.Point(629, 49);
            this.searchSDT.Name = "searchSDT";
            this.searchSDT.Size = new System.Drawing.Size(75, 20);
            this.searchSDT.TabIndex = 63;
            // 
            // searchSex
            // 
            this.searchSex.DisplayMember = "DisplayName";
            this.searchSex.FormattingEnabled = true;
            this.searchSex.Location = new System.Drawing.Point(549, 49);
            this.searchSex.Name = "searchSex";
            this.searchSex.Size = new System.Drawing.Size(74, 21);
            this.searchSex.TabIndex = 62;
            this.searchSex.ValueMember = "SqlCode";
            // 
            // searchRealname
            // 
            this.searchRealname.BackColor = System.Drawing.Color.White;
            this.searchRealname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchRealname.ForeColor = System.Drawing.Color.Black;
            this.searchRealname.Location = new System.Drawing.Point(376, 49);
            this.searchRealname.Name = "searchRealname";
            this.searchRealname.Size = new System.Drawing.Size(86, 20);
            this.searchRealname.TabIndex = 61;
            // 
            // searchID
            // 
            this.searchID.BackColor = System.Drawing.Color.White;
            this.searchID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchID.ForeColor = System.Drawing.Color.Black;
            this.searchID.Location = new System.Drawing.Point(12, 49);
            this.searchID.Name = "searchID";
            this.searchID.Size = new System.Drawing.Size(51, 20);
            this.searchID.TabIndex = 66;
            // 
            // searchKhoa
            // 
            this.searchKhoa.DataSource = this.classBindingSource;
            this.searchKhoa.DisplayMember = "Name";
            this.searchKhoa.FormattingEnabled = true;
            this.searchKhoa.Location = new System.Drawing.Point(70, 49);
            this.searchKhoa.Name = "searchKhoa";
            this.searchKhoa.Size = new System.Drawing.Size(67, 21);
            this.searchKhoa.TabIndex = 67;
            this.searchKhoa.ValueMember = "Id";
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataSource = typeof(QuanLyThuVien.Core.NameableObject);
            // 
            // searchClass
            // 
            this.searchClass.DataSource = this.khoaBindingSource;
            this.searchClass.DisplayMember = "Name";
            this.searchClass.FormattingEnabled = true;
            this.searchClass.Location = new System.Drawing.Point(143, 49);
            this.searchClass.Name = "searchClass";
            this.searchClass.Size = new System.Drawing.Size(67, 21);
            this.searchClass.TabIndex = 68;
            this.searchClass.ValueMember = "Id";
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataSource = typeof(QuanLyThuVien.Core.NameableObject);
            // 
            // searchNgayCap
            // 
            this.searchNgayCap.CustomFormat = " ";
            this.searchNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.searchNgayCap.Location = new System.Drawing.Point(216, 49);
            this.searchNgayCap.MaxDate = new System.DateTime(2020, 4, 20, 11, 12, 25, 929);
            this.searchNgayCap.MaxIsToday = true;
            this.searchNgayCap.Name = "searchNgayCap";
            this.searchNgayCap.Size = new System.Drawing.Size(75, 20);
            this.searchNgayCap.TabIndex = 69;
            this.searchNgayCap.Value = new System.DateTime(2020, 4, 19, 20, 6, 53, 921);
            // 
            // searchHetHan
            // 
            this.searchHetHan.CustomFormat = " ";
            this.searchHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.searchHetHan.Location = new System.Drawing.Point(295, 49);
            this.searchHetHan.MaxDate = new System.DateTime(2020, 4, 20, 11, 12, 25, 931);
            this.searchHetHan.MaxIsToday = true;
            this.searchHetHan.Name = "searchHetHan";
            this.searchHetHan.Size = new System.Drawing.Size(75, 20);
            this.searchHetHan.TabIndex = 70;
            this.searchHetHan.Value = new System.DateTime(2020, 4, 19, 20, 6, 53, 921);
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // maKhoaDataGridViewTextBoxColumn
            // 
            this.maKhoaDataGridViewTextBoxColumn.DataPropertyName = "MaKhoa";
            this.maKhoaDataGridViewTextBoxColumn.HeaderText = "Mã";
            this.maKhoaDataGridViewTextBoxColumn.Name = "maKhoaDataGridViewTextBoxColumn";
            this.maKhoaDataGridViewTextBoxColumn.ReadOnly = true;
            this.maKhoaDataGridViewTextBoxColumn.Width = 70;
            // 
            // tenKhoaDataGridViewTextBoxColumn1
            // 
            this.tenKhoaDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenKhoaDataGridViewTextBoxColumn1.DataPropertyName = "TenKhoa";
            this.tenKhoaDataGridViewTextBoxColumn1.HeaderText = "Tên khoa";
            this.tenKhoaDataGridViewTextBoxColumn1.Name = "tenKhoaDataGridViewTextBoxColumn1";
            this.tenKhoaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.buttonAddClass);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(388, 628);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Lớp";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLopDataGridViewTextBoxColumn,
            this.tenLopDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.classGridBindingSouce;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.Location = new System.Drawing.Point(8, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(373, 570);
            this.dataGridView1.TabIndex = 28;
            // 
            // buttonAddClass
            // 
            this.buttonAddClass.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddClass.FlatAppearance.BorderSize = 0;
            this.buttonAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddClass.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddClass.Image")));
            this.buttonAddClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddClass.Location = new System.Drawing.Point(8, 7);
            this.buttonAddClass.Name = "buttonAddClass";
            this.buttonAddClass.Size = new System.Drawing.Size(134, 30);
            this.buttonAddClass.TabIndex = 27;
            this.buttonAddClass.Text = "Thêm lớp";
            this.buttonAddClass.UseVisualStyleBackColor = false;
            // 
            // quanLyThuVienDataSet9
            // 
            this.quanLyThuVienDataSet9.DataSetName = "QuanLyThuVienDataSet9";
            this.quanLyThuVienDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classGridBindingSouce
            // 
            this.classGridBindingSouce.DataMember = "Lop";
            this.classGridBindingSouce.DataSource = this.quanLyThuVienDataSet9;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // maLopDataGridViewTextBoxColumn
            // 
            this.maLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop";
            this.maLopDataGridViewTextBoxColumn.HeaderText = "Mã";
            this.maLopDataGridViewTextBoxColumn.Name = "maLopDataGridViewTextBoxColumn";
            this.maLopDataGridViewTextBoxColumn.ReadOnly = true;
            this.maLopDataGridViewTextBoxColumn.Width = 70;
            // 
            // tenLopDataGridViewTextBoxColumn1
            // 
            this.tenLopDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenLopDataGridViewTextBoxColumn1.DataPropertyName = "TenLop";
            this.tenLopDataGridViewTextBoxColumn1.HeaderText = "Tên lớp";
            this.tenLopDataGridViewTextBoxColumn1.Name = "tenLopDataGridViewTextBoxColumn1";
            this.tenLopDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1267, 680);
            this.Controls.Add(this.searchHetHan);
            this.Controls.Add(this.searchNgayCap);
            this.Controls.Add(this.searchClass);
            this.Controls.Add(this.searchKhoa);
            this.Controls.Add(this.searchID);
            this.Controls.Add(this.searchBirthday);
            this.Controls.Add(this.searchLocation);
            this.Controls.Add(this.searchSDT);
            this.Controls.Add(this.searchSex);
            this.Controls.Add(this.searchRealname);
            this.Controls.Add(this.buttonClearSearch);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.readerGrid);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReaderForm";
            this.Text = "ReaderForm";
            this.Load += new System.EventHandler(this.ReaderForm_Load);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.locationGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchSinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet7)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classGridBindingSouce)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.DataGridView locationGrid;
        private System.Windows.Forms.Button buttonAddKhoa;
        private System.Windows.Forms.Button buttonClearSearch;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonAddBook;
        public System.Windows.Forms.DataGridView readerGrid;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.BindingSource searchSinhVienBindingSource;
        private QuanLyThuVienDataSet7 quanLyThuVienDataSet7;
        private QuanLyThuVienDataSet7TableAdapters.searchSinhVienTableAdapter searchSinhVienTableAdapter;
        public CustomControl.EDateTimePicker searchBirthday;
        public System.Windows.Forms.TextBox searchLocation;
        public System.Windows.Forms.TextBox searchSDT;
        public System.Windows.Forms.ComboBox searchSex;
        public System.Windows.Forms.TextBox searchRealname;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHetHanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        public System.Windows.Forms.TextBox searchID;
        public CustomControl.EDateTimePicker searchNgayCap;
        public CustomControl.EDateTimePicker searchHetHan;
        public System.Windows.Forms.BindingSource khoaBindingSource;
        public System.Windows.Forms.BindingSource classBindingSource;
        public System.Windows.Forms.ComboBox searchKhoa;
        public System.Windows.Forms.ComboBox searchClass;
        private QuanLyThuVienDataSet8 quanLyThuVienDataSet8;
        private QuanLyThuVienDataSet8TableAdapters.KhoaTableAdapter khoaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhoaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddClass;
        private QuanLyThuVienDataSet9 quanLyThuVienDataSet9;
        private QuanLyThuVienDataSet9TableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopDataGridViewTextBoxColumn1;
        public System.Windows.Forms.BindingSource classGridBindingSouce;
        public System.Windows.Forms.BindingSource khoaGridBindingSource;
    }
}