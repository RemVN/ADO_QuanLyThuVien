namespace QuanLyThuVien.Forms.InputForm
{
    partial class InputPhieuMuonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputPhieuMuonForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputSoNgay = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputNgayMuon = new QuanLyThuVien.CustomControl.EDateTimePicker();
            this.inputReader = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inputBooks = new System.Windows.Forms.ListBox();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.inputAddBook = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputSoNgay)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.inputSoNgay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inputNgayMuon);
            this.groupBox1.Controls.Add(this.inputReader);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 252);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu mượn";
            // 
            // inputID
            // 
            this.inputID.Enabled = false;
            this.inputID.Location = new System.Drawing.Point(270, 32);
            this.inputID.Name = "inputID";
            this.inputID.Size = new System.Drawing.Size(155, 21);
            this.inputID.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã phiếu";
            // 
            // inputSoNgay
            // 
            this.inputSoNgay.Location = new System.Drawing.Point(270, 201);
            this.inputSoNgay.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.inputSoNgay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputSoNgay.Name = "inputSoNgay";
            this.inputSoNgay.Size = new System.Drawing.Size(155, 21);
            this.inputSoNgay.TabIndex = 7;
            this.inputSoNgay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số ngày mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày mượn";
            // 
            // inputNgayMuon
            // 
            this.inputNgayMuon.CustomFormat = " ";
            this.inputNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputNgayMuon.Location = new System.Drawing.Point(270, 141);
            this.inputNgayMuon.MaxDate = new System.DateTime(2020, 4, 22, 22, 6, 50, 150);
            this.inputNgayMuon.MaxIsToday = true;
            this.inputNgayMuon.Name = "inputNgayMuon";
            this.inputNgayMuon.Size = new System.Drawing.Size(155, 21);
            this.inputNgayMuon.TabIndex = 4;
            this.inputNgayMuon.ValueChanged += new System.EventHandler(this.InputNgayMuon_ValueChanged);
            this.inputNgayMuon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputNgayMuon_KeyDown);
            // 
            // inputReader
            // 
            this.inputReader.Location = new System.Drawing.Point(270, 82);
            this.inputReader.Name = "inputReader";
            this.inputReader.Size = new System.Drawing.Size(155, 21);
            this.inputReader.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã sinh viên mượn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inputBooks);
            this.groupBox2.Controls.Add(this.buttonAddBook);
            this.groupBox2.Controls.Add(this.inputAddBook);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 227);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sách mượn";
            // 
            // inputBooks
            // 
            this.inputBooks.DataSource = this.booksBindingSource;
            this.inputBooks.DisplayMember = "Name";
            this.inputBooks.FormattingEnabled = true;
            this.inputBooks.ItemHeight = 15;
            this.inputBooks.Location = new System.Drawing.Point(128, 83);
            this.inputBooks.Name = "inputBooks";
            this.inputBooks.Size = new System.Drawing.Size(297, 124);
            this.inputBooks.TabIndex = 7;
            this.inputBooks.ValueMember = "Id";
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataSource = typeof(QuanLyThuVien.Core.NameableObject);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(353, 41);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(75, 23);
            this.buttonAddBook.TabIndex = 6;
            this.buttonAddBook.Text = "Thêm";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.ButtonAddBook_Click);
            // 
            // inputAddBook
            // 
            this.inputAddBook.Location = new System.Drawing.Point(190, 42);
            this.inputAddBook.Name = "inputAddBook";
            this.inputAddBook.Size = new System.Drawing.Size(157, 21);
            this.inputAddBook.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã sách";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "tick.png");
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.ImageKey = "tick.png";
            this.buttonAdd.ImageList = this.imageList1;
            this.buttonAdd.Location = new System.Drawing.Point(511, 522);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(60, 23);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "(none)";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(443, 522);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Huỷ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // InputPhieuMuonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(583, 557);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InputPhieuMuonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo phiếu mượn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputSoNgay)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox inputReader;
        private System.Windows.Forms.Label label1;
        private CustomControl.EDateTimePicker inputNgayMuon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown inputSoNgay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.TextBox inputAddBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox inputBooks;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox inputID;
        private System.Windows.Forms.Label label5;
    }
}