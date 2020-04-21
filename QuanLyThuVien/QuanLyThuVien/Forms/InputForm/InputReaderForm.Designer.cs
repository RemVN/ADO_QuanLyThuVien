namespace QuanLyThuVien.Forms.InputForm
{
    partial class InputReaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputReaderForm));
            this.inputPerson = new QuanLyThuVien.Forms.InputForm.InputPersonForm();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputHetHan = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.inputNgayCap = new QuanLyThuVien.CustomControl.EDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.inputClass = new System.Windows.Forms.ComboBox();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.inputKhoa = new System.Windows.Forms.ComboBox();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputHetHan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inputPerson
            // 
            this.inputPerson.BackColor = System.Drawing.Color.White;
            this.inputPerson.Location = new System.Drawing.Point(13, 13);
            this.inputPerson.Name = "inputPerson";
            this.inputPerson.Size = new System.Drawing.Size(500, 270);
            this.inputPerson.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.inputHetHan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.inputNgayCap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inputClass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inputKhoa);
            this.groupBox1.Location = new System.Drawing.Point(13, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin độc giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thời hạn (Ngày)";
            // 
            // inputHetHan
            // 
            this.inputHetHan.Location = new System.Drawing.Point(223, 164);
            this.inputHetHan.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.inputHetHan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputHetHan.Name = "inputHetHan";
            this.inputHetHan.Size = new System.Drawing.Size(182, 20);
            this.inputHetHan.TabIndex = 7;
            this.inputHetHan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày cấp";
            // 
            // inputNgayCap
            // 
            this.inputNgayCap.CustomFormat = " ";
            this.inputNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputNgayCap.Location = new System.Drawing.Point(223, 119);
            this.inputNgayCap.MaxDate = new System.DateTime(2020, 4, 21, 15, 47, 57, 968);
            this.inputNgayCap.MaxIsToday = true;
            this.inputNgayCap.Name = "inputNgayCap";
            this.inputNgayCap.Size = new System.Drawing.Size(182, 20);
            this.inputNgayCap.TabIndex = 5;
            this.inputNgayCap.ValueChanged += new System.EventHandler(this.InputNgayCap_ValueChanged);
            this.inputNgayCap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputNgayCap_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lớp";
            // 
            // inputClass
            // 
            this.inputClass.DataSource = this.classBindingSource;
            this.inputClass.DisplayMember = "Name";
            this.inputClass.FormattingEnabled = true;
            this.inputClass.Location = new System.Drawing.Point(223, 77);
            this.inputClass.Name = "inputClass";
            this.inputClass.Size = new System.Drawing.Size(182, 21);
            this.inputClass.TabIndex = 3;
            this.inputClass.ValueMember = "Id";
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataSource = typeof(QuanLyThuVien.Core.NameableObject);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa";
            // 
            // inputKhoa
            // 
            this.inputKhoa.DataSource = this.khoaBindingSource;
            this.inputKhoa.DisplayMember = "Name";
            this.inputKhoa.FormattingEnabled = true;
            this.inputKhoa.Location = new System.Drawing.Point(223, 37);
            this.inputKhoa.Name = "inputKhoa";
            this.inputKhoa.Size = new System.Drawing.Size(182, 21);
            this.inputKhoa.TabIndex = 1;
            this.inputKhoa.ValueMember = "Id";
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataSource = typeof(QuanLyThuVien.Core.NameableObject);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "tick.png");
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "(none)";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(385, 519);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Huỷ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.ImageKey = "tick.png";
            this.buttonAdd.ImageList = this.imageList1;
            this.buttonAdd.Location = new System.Drawing.Point(453, 519);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(60, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // InputReaderForm
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(525, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inputPerson);
            this.Name = "InputReaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputReaderForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputHetHan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private InputPersonForm inputPerson;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox inputKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox inputClass;
        private System.Windows.Forms.Label label3;
        private CustomControl.EDateTimePicker inputNgayCap;
        private System.Windows.Forms.NumericUpDown inputHetHan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonAdd;
        public System.Windows.Forms.BindingSource classBindingSource;
        public System.Windows.Forms.BindingSource khoaBindingSource;
    }
}