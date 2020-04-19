namespace QuanLyThuVien.Forms
{
    partial class StaffForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.staffGrid = new System.Windows.Forms.DataGridView();
            this.maSoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDangNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet6 = new QuanLyThuVien.QuanLyThuVienDataSet6();
            this.buttonClearSearch = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.searchID = new System.Windows.Forms.TextBox();
            this.searchUsername = new System.Windows.Forms.TextBox();
            this.searchPassword = new System.Windows.Forms.TextBox();
            this.searchRank = new System.Windows.Forms.ComboBox();
            this.sqlCodeObjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.searchBirthday = new System.Windows.Forms.DateTimePicker();
            this.getNhanVienTableAdapter = new QuanLyThuVien.QuanLyThuVienDataSet6TableAdapters.getNhanVienTableAdapter();
            this.searchRealname = new System.Windows.Forms.TextBox();
            this.searchSex = new System.Windows.Forms.ComboBox();
            this.sqlCodeObjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchSDT = new System.Windows.Forms.TextBox();
            this.searchLocation = new System.Windows.Forms.TextBox();
            this.searchStatus = new System.Windows.Forms.ComboBox();
            this.sqlCodeObjectBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.staffGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet6)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqlCodeObjectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlCodeObjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlCodeObjectBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // staffGrid
            // 
            this.staffGrid.AllowUserToAddRows = false;
            this.staffGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.staffGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.staffGrid.AutoGenerateColumns = false;
            this.staffGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.staffGrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.staffGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSoDataGridViewTextBoxColumn,
            this.tenDangNhapDataGridViewTextBoxColumn,
            this.matKhauDataGridViewTextBoxColumn,
            this.chucVuDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn});
            this.staffGrid.DataSource = this.getNhanVienBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.staffGrid.Location = new System.Drawing.Point(12, 69);
            this.staffGrid.Name = "staffGrid";
            this.staffGrid.ReadOnly = true;
            this.staffGrid.RowHeadersVisible = false;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.staffGrid.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.staffGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffGrid.Size = new System.Drawing.Size(1015, 599);
            this.staffGrid.TabIndex = 1;
            // 
            // maSoDataGridViewTextBoxColumn
            // 
            this.maSoDataGridViewTextBoxColumn.DataPropertyName = "MaSo";
            this.maSoDataGridViewTextBoxColumn.HeaderText = "Mã số";
            this.maSoDataGridViewTextBoxColumn.Name = "maSoDataGridViewTextBoxColumn";
            this.maSoDataGridViewTextBoxColumn.ReadOnly = true;
            this.maSoDataGridViewTextBoxColumn.Width = 70;
            // 
            // tenDangNhapDataGridViewTextBoxColumn
            // 
            this.tenDangNhapDataGridViewTextBoxColumn.DataPropertyName = "TenDangNhap";
            this.tenDangNhapDataGridViewTextBoxColumn.HeaderText = "Tên đăng nhập";
            this.tenDangNhapDataGridViewTextBoxColumn.Name = "tenDangNhapDataGridViewTextBoxColumn";
            this.tenDangNhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            this.matKhauDataGridViewTextBoxColumn.DataPropertyName = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.HeaderText = "Mật khẩu";
            this.matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            this.matKhauDataGridViewTextBoxColumn.ReadOnly = true;
            this.matKhauDataGridViewTextBoxColumn.Width = 60;
            // 
            // chucVuDataGridViewTextBoxColumn
            // 
            this.chucVuDataGridViewTextBoxColumn.DataPropertyName = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.HeaderText = "Chức vụ";
            this.chucVuDataGridViewTextBoxColumn.Name = "chucVuDataGridViewTextBoxColumn";
            this.chucVuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            this.trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.HeaderText = "Trạng thái";
            this.trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            this.trangThaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoTenDataGridViewTextBoxColumn.Width = 120;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngaySinhDataGridViewTextBoxColumn.Width = 120;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.gioiTinhDataGridViewTextBoxColumn.Width = 70;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getNhanVienBindingSource
            // 
            this.getNhanVienBindingSource.DataMember = "getNhanVien";
            this.getNhanVienBindingSource.DataSource = this.quanLyThuVienDataSet6;
            // 
            // quanLyThuVienDataSet6
            // 
            this.quanLyThuVienDataSet6.DataSetName = "QuanLyThuVienDataSet6";
            this.quanLyThuVienDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.buttonClearSearch.Location = new System.Drawing.Point(766, 2);
            this.buttonClearSearch.Name = "buttonClearSearch";
            this.buttonClearSearch.Size = new System.Drawing.Size(160, 31);
            this.buttonClearSearch.TabIndex = 44;
            this.buttonClearSearch.Text = "Xoá khung tìm kiếm";
            this.buttonClearSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClearSearch.UseVisualStyleBackColor = false;
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
            this.buttonRefresh.Location = new System.Drawing.Point(160, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(85, 30);
            this.buttonRefresh.TabIndex = 43;
            this.buttonRefresh.Text = "Tải lại";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRefresh.UseVisualStyleBackColor = false;
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
            this.buttonSearch.Location = new System.Drawing.Point(932, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(95, 31);
            this.buttonSearch.TabIndex = 42;
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
            this.buttonAddBook.Location = new System.Drawing.Point(12, 2);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(142, 30);
            this.buttonAddBook.TabIndex = 41;
            this.buttonAddBook.Text = "Thêm nhân viên";
            this.buttonAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddBook.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1045, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 656);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lối tắt";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(18, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 30);
            this.button2.TabIndex = 43;
            this.button2.Text = "Mở khoá tài khoản";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(18, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 30);
            this.button1.TabIndex = 42;
            this.button1.Text = "Khoá tài khoản";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // searchID
            // 
            this.searchID.BackColor = System.Drawing.Color.White;
            this.searchID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchID.ForeColor = System.Drawing.Color.Black;
            this.searchID.Location = new System.Drawing.Point(12, 43);
            this.searchID.Name = "searchID";
            this.searchID.Size = new System.Drawing.Size(69, 20);
            this.searchID.TabIndex = 49;
            // 
            // searchUsername
            // 
            this.searchUsername.BackColor = System.Drawing.Color.White;
            this.searchUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchUsername.ForeColor = System.Drawing.Color.Black;
            this.searchUsername.Location = new System.Drawing.Point(87, 43);
            this.searchUsername.Name = "searchUsername";
            this.searchUsername.Size = new System.Drawing.Size(99, 20);
            this.searchUsername.TabIndex = 50;
            // 
            // searchPassword
            // 
            this.searchPassword.BackColor = System.Drawing.Color.LightGray;
            this.searchPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPassword.Enabled = false;
            this.searchPassword.ForeColor = System.Drawing.Color.Black;
            this.searchPassword.Location = new System.Drawing.Point(192, 43);
            this.searchPassword.Name = "searchPassword";
            this.searchPassword.Size = new System.Drawing.Size(53, 20);
            this.searchPassword.TabIndex = 51;
            // 
            // searchRank
            // 
            this.searchRank.DataSource = this.sqlCodeObjectBindingSource1;
            this.searchRank.DisplayMember = "DisplayName";
            this.searchRank.FormattingEnabled = true;
            this.searchRank.Location = new System.Drawing.Point(251, 43);
            this.searchRank.Name = "searchRank";
            this.searchRank.Size = new System.Drawing.Size(94, 21);
            this.searchRank.TabIndex = 52;
            this.searchRank.ValueMember = "SqlCode";
            // 
            // sqlCodeObjectBindingSource1
            // 
            this.sqlCodeObjectBindingSource1.DataSource = typeof(QuanLyThuVien.Core.SqlCodeObject);
            // 
            // searchBirthday
            // 
            this.searchBirthday.Location = new System.Drawing.Point(563, 43);
            this.searchBirthday.Name = "searchBirthday";
            this.searchBirthday.Size = new System.Drawing.Size(111, 20);
            this.searchBirthday.TabIndex = 54;
            // 
            // getNhanVienTableAdapter
            // 
            this.getNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // searchRealname
            // 
            this.searchRealname.BackColor = System.Drawing.Color.White;
            this.searchRealname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchRealname.ForeColor = System.Drawing.Color.Black;
            this.searchRealname.Location = new System.Drawing.Point(451, 43);
            this.searchRealname.Name = "searchRealname";
            this.searchRealname.Size = new System.Drawing.Size(106, 20);
            this.searchRealname.TabIndex = 55;
            // 
            // searchSex
            // 
            this.searchSex.DataSource = this.sqlCodeObjectBindingSource;
            this.searchSex.DisplayMember = "DisplayName";
            this.searchSex.FormattingEnabled = true;
            this.searchSex.Location = new System.Drawing.Point(680, 43);
            this.searchSex.Name = "searchSex";
            this.searchSex.Size = new System.Drawing.Size(74, 21);
            this.searchSex.TabIndex = 56;
            this.searchSex.ValueMember = "SqlCode";
            // 
            // sqlCodeObjectBindingSource
            // 
            this.sqlCodeObjectBindingSource.DataSource = typeof(QuanLyThuVien.Core.SqlCodeObject);
            // 
            // searchSDT
            // 
            this.searchSDT.BackColor = System.Drawing.Color.White;
            this.searchSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchSDT.ForeColor = System.Drawing.Color.Black;
            this.searchSDT.Location = new System.Drawing.Point(760, 43);
            this.searchSDT.Name = "searchSDT";
            this.searchSDT.Size = new System.Drawing.Size(94, 20);
            this.searchSDT.TabIndex = 57;
            // 
            // searchLocation
            // 
            this.searchLocation.BackColor = System.Drawing.Color.White;
            this.searchLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchLocation.ForeColor = System.Drawing.Color.Black;
            this.searchLocation.Location = new System.Drawing.Point(860, 43);
            this.searchLocation.Name = "searchLocation";
            this.searchLocation.Size = new System.Drawing.Size(167, 20);
            this.searchLocation.TabIndex = 58;
            // 
            // searchStatus
            // 
            this.searchStatus.DataSource = this.sqlCodeObjectBindingSource2;
            this.searchStatus.DisplayMember = "DisplayName";
            this.searchStatus.FormattingEnabled = true;
            this.searchStatus.Location = new System.Drawing.Point(351, 43);
            this.searchStatus.Name = "searchStatus";
            this.searchStatus.Size = new System.Drawing.Size(94, 21);
            this.searchStatus.TabIndex = 59;
            this.searchStatus.ValueMember = "SqlCode";
            // 
            // sqlCodeObjectBindingSource2
            // 
            this.sqlCodeObjectBindingSource2.DataSource = typeof(QuanLyThuVien.Core.SqlCodeObject);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1267, 680);
            this.Controls.Add(this.searchStatus);
            this.Controls.Add(this.searchLocation);
            this.Controls.Add(this.searchSDT);
            this.Controls.Add(this.searchSex);
            this.Controls.Add(this.searchRealname);
            this.Controls.Add(this.searchBirthday);
            this.Controls.Add(this.searchRank);
            this.Controls.Add(this.searchPassword);
            this.Controls.Add(this.searchUsername);
            this.Controls.Add(this.searchID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClearSearch);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.staffGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sqlCodeObjectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlCodeObjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlCodeObjectBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView staffGrid;
        private System.Windows.Forms.Button buttonClearSearch;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox searchID;
        public System.Windows.Forms.TextBox searchUsername;
        public System.Windows.Forms.TextBox searchPassword;
        private System.Windows.Forms.BindingSource getNhanVienBindingSource;
        private QuanLyThuVienDataSet6 quanLyThuVienDataSet6;
        private QuanLyThuVienDataSet6TableAdapters.getNhanVienTableAdapter getNhanVienTableAdapter;
        public System.Windows.Forms.TextBox searchRealname;
        private System.Windows.Forms.ComboBox searchSex;
        public System.Windows.Forms.TextBox searchSDT;
        public System.Windows.Forms.TextBox searchLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDangNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sqlCodeObjectBindingSource;
        private System.Windows.Forms.BindingSource sqlCodeObjectBindingSource1;
        public System.Windows.Forms.ComboBox searchRank;
        public System.Windows.Forms.ComboBox searchStatus;
        private System.Windows.Forms.BindingSource sqlCodeObjectBindingSource2;
        public System.Windows.Forms.DateTimePicker searchBirthday;
    }
}