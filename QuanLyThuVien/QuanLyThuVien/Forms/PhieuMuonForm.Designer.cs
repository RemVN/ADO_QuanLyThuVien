namespace QuanLyThuVien.Forms
{
    partial class PhieuMuonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuMuonForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchRank = new System.Windows.Forms.ComboBox();
            this.searchPassword = new System.Windows.Forms.TextBox();
            this.searchUsername = new System.Windows.Forms.TextBox();
            this.searchID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonClearSearch = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.searchSex = new System.Windows.Forms.ComboBox();
            this.searchRealname = new System.Windows.Forms.TextBox();
            this.searchStatus = new System.Windows.Forms.ComboBox();
            this.searchLocation = new System.Windows.Forms.TextBox();
            this.searchSDT = new System.Windows.Forms.TextBox();
            this.buttonAddPhieuMuon = new System.Windows.Forms.Button();
            this.phieuMuonGrid = new System.Windows.Forms.DataGridView();
            this.maPhieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiTaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soSachMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHenTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spgetPhieuMuonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThuVienDataSet10 = new QuanLyThuVien.QuanLyThuVienDataSet10();
            this.sp_get_PhieuMuonTableAdapter = new QuanLyThuVien.QuanLyThuVienDataSet10TableAdapters.sp_get_PhieuMuonTableAdapter();
            this.searchBirthday = new QuanLyThuVien.CustomControl.EDateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieuMuonGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetPhieuMuonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // searchRank
            // 
            this.searchRank.DisplayMember = "SqlCode";
            this.searchRank.FormattingEnabled = true;
            this.searchRank.Location = new System.Drawing.Point(255, 48);
            this.searchRank.Name = "searchRank";
            this.searchRank.Size = new System.Drawing.Size(94, 21);
            this.searchRank.TabIndex = 70;
            this.searchRank.ValueMember = "SqlCode";
            // 
            // searchPassword
            // 
            this.searchPassword.BackColor = System.Drawing.Color.LightGray;
            this.searchPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPassword.Enabled = false;
            this.searchPassword.ForeColor = System.Drawing.Color.Black;
            this.searchPassword.Location = new System.Drawing.Point(196, 48);
            this.searchPassword.Name = "searchPassword";
            this.searchPassword.Size = new System.Drawing.Size(53, 20);
            this.searchPassword.TabIndex = 69;
            // 
            // searchUsername
            // 
            this.searchUsername.BackColor = System.Drawing.Color.White;
            this.searchUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchUsername.ForeColor = System.Drawing.Color.Black;
            this.searchUsername.Location = new System.Drawing.Point(91, 48);
            this.searchUsername.Name = "searchUsername";
            this.searchUsername.Size = new System.Drawing.Size(99, 20);
            this.searchUsername.TabIndex = 68;
            // 
            // searchID
            // 
            this.searchID.BackColor = System.Drawing.Color.White;
            this.searchID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchID.ForeColor = System.Drawing.Color.Black;
            this.searchID.Location = new System.Drawing.Point(16, 48);
            this.searchID.Name = "searchID";
            this.searchID.Size = new System.Drawing.Size(69, 20);
            this.searchID.TabIndex = 67;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1049, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 656);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lối tắt";
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
            this.button1.Text = "In phiếu mượn";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
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
            this.buttonClearSearch.Location = new System.Drawing.Point(770, 0);
            this.buttonClearSearch.Name = "buttonClearSearch";
            this.buttonClearSearch.Size = new System.Drawing.Size(160, 31);
            this.buttonClearSearch.TabIndex = 65;
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
            this.buttonRefresh.Location = new System.Drawing.Point(164, 0);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(85, 30);
            this.buttonRefresh.TabIndex = 64;
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
            this.buttonSearch.Location = new System.Drawing.Point(936, 0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(95, 31);
            this.buttonSearch.TabIndex = 63;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // searchSex
            // 
            this.searchSex.DisplayMember = "SqlCode";
            this.searchSex.FormattingEnabled = true;
            this.searchSex.Location = new System.Drawing.Point(684, 48);
            this.searchSex.Name = "searchSex";
            this.searchSex.Size = new System.Drawing.Size(74, 21);
            this.searchSex.TabIndex = 72;
            this.searchSex.ValueMember = "SqlCode";
            // 
            // searchRealname
            // 
            this.searchRealname.BackColor = System.Drawing.Color.White;
            this.searchRealname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchRealname.ForeColor = System.Drawing.Color.Black;
            this.searchRealname.Location = new System.Drawing.Point(455, 48);
            this.searchRealname.Name = "searchRealname";
            this.searchRealname.Size = new System.Drawing.Size(106, 20);
            this.searchRealname.TabIndex = 71;
            // 
            // searchStatus
            // 
            this.searchStatus.DisplayMember = "SqlCode";
            this.searchStatus.FormattingEnabled = true;
            this.searchStatus.Location = new System.Drawing.Point(355, 48);
            this.searchStatus.Name = "searchStatus";
            this.searchStatus.Size = new System.Drawing.Size(94, 21);
            this.searchStatus.TabIndex = 75;
            this.searchStatus.ValueMember = "SqlCode";
            // 
            // searchLocation
            // 
            this.searchLocation.BackColor = System.Drawing.Color.White;
            this.searchLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchLocation.ForeColor = System.Drawing.Color.Black;
            this.searchLocation.Location = new System.Drawing.Point(864, 48);
            this.searchLocation.Name = "searchLocation";
            this.searchLocation.Size = new System.Drawing.Size(167, 20);
            this.searchLocation.TabIndex = 74;
            // 
            // searchSDT
            // 
            this.searchSDT.BackColor = System.Drawing.Color.White;
            this.searchSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchSDT.ForeColor = System.Drawing.Color.Black;
            this.searchSDT.Location = new System.Drawing.Point(764, 48);
            this.searchSDT.Name = "searchSDT";
            this.searchSDT.Size = new System.Drawing.Size(94, 20);
            this.searchSDT.TabIndex = 73;
            // 
            // buttonAddPhieuMuon
            // 
            this.buttonAddPhieuMuon.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddPhieuMuon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddPhieuMuon.FlatAppearance.BorderSize = 0;
            this.buttonAddPhieuMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPhieuMuon.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddPhieuMuon.Image")));
            this.buttonAddPhieuMuon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddPhieuMuon.Location = new System.Drawing.Point(16, 0);
            this.buttonAddPhieuMuon.Name = "buttonAddPhieuMuon";
            this.buttonAddPhieuMuon.Size = new System.Drawing.Size(142, 30);
            this.buttonAddPhieuMuon.TabIndex = 62;
            this.buttonAddPhieuMuon.Text = "Tạo phiếu mượn";
            this.buttonAddPhieuMuon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddPhieuMuon.UseVisualStyleBackColor = false;
            this.buttonAddPhieuMuon.Click += new System.EventHandler(this.ButtonAddPhieuMuon_Click);
            // 
            // phieuMuonGrid
            // 
            this.phieuMuonGrid.AllowUserToAddRows = false;
            this.phieuMuonGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.phieuMuonGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.phieuMuonGrid.AutoGenerateColumns = false;
            this.phieuMuonGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.phieuMuonGrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.phieuMuonGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phieuMuonGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieuDataGridViewTextBoxColumn,
            this.sinhVienDataGridViewTextBoxColumn,
            this.nguoiTaoDataGridViewTextBoxColumn,
            this.soSachMuonDataGridViewTextBoxColumn,
            this.ngayMuonDataGridViewTextBoxColumn,
            this.ngayHenTraDataGridViewTextBoxColumn,
            this.ngayTraDataGridViewTextBoxColumn,
            this.tinhTrangDataGridViewTextBoxColumn});
            this.phieuMuonGrid.DataSource = this.spgetPhieuMuonBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.phieuMuonGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.phieuMuonGrid.Location = new System.Drawing.Point(16, 74);
            this.phieuMuonGrid.Name = "phieuMuonGrid";
            this.phieuMuonGrid.ReadOnly = true;
            this.phieuMuonGrid.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.phieuMuonGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.phieuMuonGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.phieuMuonGrid.Size = new System.Drawing.Size(1015, 599);
            this.phieuMuonGrid.TabIndex = 61;
            // 
            // maPhieuDataGridViewTextBoxColumn
            // 
            this.maPhieuDataGridViewTextBoxColumn.DataPropertyName = "MaPhieu";
            this.maPhieuDataGridViewTextBoxColumn.HeaderText = "Mã phiếu";
            this.maPhieuDataGridViewTextBoxColumn.Name = "maPhieuDataGridViewTextBoxColumn";
            this.maPhieuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sinhVienDataGridViewTextBoxColumn
            // 
            this.sinhVienDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sinhVienDataGridViewTextBoxColumn.DataPropertyName = "SinhVien";
            this.sinhVienDataGridViewTextBoxColumn.HeaderText = "Sinh viên mượn";
            this.sinhVienDataGridViewTextBoxColumn.Name = "sinhVienDataGridViewTextBoxColumn";
            this.sinhVienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nguoiTaoDataGridViewTextBoxColumn
            // 
            this.nguoiTaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nguoiTaoDataGridViewTextBoxColumn.DataPropertyName = "NguoiTao";
            this.nguoiTaoDataGridViewTextBoxColumn.HeaderText = "Người tạo phiếu";
            this.nguoiTaoDataGridViewTextBoxColumn.Name = "nguoiTaoDataGridViewTextBoxColumn";
            this.nguoiTaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soSachMuonDataGridViewTextBoxColumn
            // 
            this.soSachMuonDataGridViewTextBoxColumn.DataPropertyName = "SoSachMuon";
            this.soSachMuonDataGridViewTextBoxColumn.HeaderText = "Số sách mượn";
            this.soSachMuonDataGridViewTextBoxColumn.Name = "soSachMuonDataGridViewTextBoxColumn";
            this.soSachMuonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayMuonDataGridViewTextBoxColumn
            // 
            this.ngayMuonDataGridViewTextBoxColumn.DataPropertyName = "NgayMuon";
            this.ngayMuonDataGridViewTextBoxColumn.HeaderText = "Ngày mượn";
            this.ngayMuonDataGridViewTextBoxColumn.Name = "ngayMuonDataGridViewTextBoxColumn";
            this.ngayMuonDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayMuonDataGridViewTextBoxColumn.Width = 120;
            // 
            // ngayHenTraDataGridViewTextBoxColumn
            // 
            this.ngayHenTraDataGridViewTextBoxColumn.DataPropertyName = "NgayHenTra";
            this.ngayHenTraDataGridViewTextBoxColumn.HeaderText = "Ngày hẹn trả";
            this.ngayHenTraDataGridViewTextBoxColumn.Name = "ngayHenTraDataGridViewTextBoxColumn";
            this.ngayHenTraDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayHenTraDataGridViewTextBoxColumn.Width = 120;
            // 
            // ngayTraDataGridViewTextBoxColumn
            // 
            this.ngayTraDataGridViewTextBoxColumn.DataPropertyName = "NgayTra";
            this.ngayTraDataGridViewTextBoxColumn.HeaderText = "Ngày trả";
            this.ngayTraDataGridViewTextBoxColumn.Name = "ngayTraDataGridViewTextBoxColumn";
            this.ngayTraDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayTraDataGridViewTextBoxColumn.Width = 120;
            // 
            // tinhTrangDataGridViewTextBoxColumn
            // 
            this.tinhTrangDataGridViewTextBoxColumn.DataPropertyName = "TinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.HeaderText = "Tình trạng";
            this.tinhTrangDataGridViewTextBoxColumn.Name = "tinhTrangDataGridViewTextBoxColumn";
            this.tinhTrangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spgetPhieuMuonBindingSource
            // 
            this.spgetPhieuMuonBindingSource.DataMember = "sp_get_PhieuMuon";
            this.spgetPhieuMuonBindingSource.DataSource = this.quanLyThuVienDataSet10;
            // 
            // quanLyThuVienDataSet10
            // 
            this.quanLyThuVienDataSet10.DataSetName = "QuanLyThuVienDataSet10";
            this.quanLyThuVienDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_get_PhieuMuonTableAdapter
            // 
            this.sp_get_PhieuMuonTableAdapter.ClearBeforeFill = true;
            // 
            // searchBirthday
            // 
            this.searchBirthday.CustomFormat = " ";
            this.searchBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.searchBirthday.Location = new System.Drawing.Point(567, 48);
            this.searchBirthday.MaxDate = new System.DateTime(2020, 4, 22, 21, 19, 31, 204);
            this.searchBirthday.MaxIsToday = true;
            this.searchBirthday.Name = "searchBirthday";
            this.searchBirthday.Size = new System.Drawing.Size(111, 20);
            this.searchBirthday.TabIndex = 76;
            this.searchBirthday.Value = new System.DateTime(2020, 4, 19, 20, 6, 53, 921);
            // 
            // PhieuMuonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1267, 680);
            this.Controls.Add(this.searchRank);
            this.Controls.Add(this.searchPassword);
            this.Controls.Add(this.searchUsername);
            this.Controls.Add(this.searchID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClearSearch);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.searchSex);
            this.Controls.Add(this.searchRealname);
            this.Controls.Add(this.searchStatus);
            this.Controls.Add(this.searchLocation);
            this.Controls.Add(this.searchSDT);
            this.Controls.Add(this.searchBirthday);
            this.Controls.Add(this.buttonAddPhieuMuon);
            this.Controls.Add(this.phieuMuonGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhieuMuonForm";
            this.Text = "MuonTraForm";
            this.Load += new System.EventHandler(this.MuonTraForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phieuMuonGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetPhieuMuonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox searchRank;
        public System.Windows.Forms.TextBox searchPassword;
        public System.Windows.Forms.TextBox searchUsername;
        public System.Windows.Forms.TextBox searchID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonClearSearch;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonSearch;
        public System.Windows.Forms.ComboBox searchSex;
        public System.Windows.Forms.TextBox searchRealname;
        public System.Windows.Forms.ComboBox searchStatus;
        public System.Windows.Forms.TextBox searchLocation;
        public System.Windows.Forms.TextBox searchSDT;
        public CustomControl.EDateTimePicker searchBirthday;
        private System.Windows.Forms.Button buttonAddPhieuMuon;
        public System.Windows.Forms.DataGridView phieuMuonGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinhVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiTaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soSachMuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayMuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHenTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spgetPhieuMuonBindingSource;
        private QuanLyThuVienDataSet10 quanLyThuVienDataSet10;
        private QuanLyThuVienDataSet10TableAdapters.sp_get_PhieuMuonTableAdapter sp_get_PhieuMuonTableAdapter;
    }
}