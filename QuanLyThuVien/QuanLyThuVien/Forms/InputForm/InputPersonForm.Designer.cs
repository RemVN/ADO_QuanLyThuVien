namespace QuanLyThuVien.Forms.InputForm
{
    partial class InputPersonForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupPerson = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputSDT = new System.Windows.Forms.TextBox();
            this.inputSex = new System.Windows.Forms.ComboBox();
            this.sqlCodeObjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.inputBirthday = new QuanLyThuVien.CustomControl.EDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputRealname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputID = new System.Windows.Forms.TextBox();
            this.groupPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqlCodeObjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPerson
            // 
            this.groupPerson.Controls.Add(this.label6);
            this.groupPerson.Controls.Add(this.inputLocation);
            this.groupPerson.Controls.Add(this.label5);
            this.groupPerson.Controls.Add(this.inputSDT);
            this.groupPerson.Controls.Add(this.inputSex);
            this.groupPerson.Controls.Add(this.label4);
            this.groupPerson.Controls.Add(this.inputBirthday);
            this.groupPerson.Controls.Add(this.label3);
            this.groupPerson.Controls.Add(this.label2);
            this.groupPerson.Controls.Add(this.inputRealname);
            this.groupPerson.Controls.Add(this.label1);
            this.groupPerson.Controls.Add(this.inputID);
            this.groupPerson.Location = new System.Drawing.Point(3, 3);
            this.groupPerson.Name = "groupPerson";
            this.groupPerson.Size = new System.Drawing.Size(494, 264);
            this.groupPerson.TabIndex = 13;
            this.groupPerson.TabStop = false;
            this.groupPerson.Text = "Thông tin cá nhân";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(92, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Địa chỉ";
            // 
            // inputLocation
            // 
            this.inputLocation.Location = new System.Drawing.Point(222, 221);
            this.inputLocation.Name = "inputLocation";
            this.inputLocation.Size = new System.Drawing.Size(180, 20);
            this.inputLocation.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "SDT";
            // 
            // inputSDT
            // 
            this.inputSDT.Location = new System.Drawing.Point(222, 182);
            this.inputSDT.MaxLength = 15;
            this.inputSDT.Name = "inputSDT";
            this.inputSDT.Size = new System.Drawing.Size(180, 20);
            this.inputSDT.TabIndex = 21;
            // 
            // inputSex
            // 
            this.inputSex.DataSource = this.sqlCodeObjectBindingSource;
            this.inputSex.DisplayMember = "DisplayName";
            this.inputSex.FormattingEnabled = true;
            this.inputSex.Location = new System.Drawing.Point(222, 142);
            this.inputSex.Name = "inputSex";
            this.inputSex.Size = new System.Drawing.Size(180, 21);
            this.inputSex.TabIndex = 20;
            this.inputSex.ValueMember = "SqlCode";
            // 
            // sqlCodeObjectBindingSource
            // 
            this.sqlCodeObjectBindingSource.DataSource = typeof(QuanLyThuVien.Core.SqlCodeObject);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Giới tinh";
            // 
            // inputBirthday
            // 
            this.inputBirthday.CustomFormat = " ";
            this.inputBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputBirthday.Location = new System.Drawing.Point(222, 100);
            this.inputBirthday.MaxDate = new System.DateTime(2020, 4, 19, 23, 26, 22, 882);
            this.inputBirthday.MaxIsToday = true;
            this.inputBirthday.Name = "inputBirthday";
            this.inputBirthday.Size = new System.Drawing.Size(180, 20);
            this.inputBirthday.TabIndex = 18;
            this.inputBirthday.Value = new System.DateTime(2020, 4, 19, 22, 20, 41, 760);
            this.inputBirthday.ValueChanged += new System.EventHandler(this.InputBirthday_ValueChanged);
            this.inputBirthday.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBirthday_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Họ tên";
            // 
            // inputRealname
            // 
            this.inputRealname.Location = new System.Drawing.Point(222, 60);
            this.inputRealname.Name = "inputRealname";
            this.inputRealname.Size = new System.Drawing.Size(180, 20);
            this.inputRealname.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã số";
            // 
            // inputID
            // 
            this.inputID.Enabled = false;
            this.inputID.Location = new System.Drawing.Point(222, 23);
            this.inputID.Name = "inputID";
            this.inputID.Size = new System.Drawing.Size(180, 20);
            this.inputID.TabIndex = 13;
            // 
            // InputPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupPerson);
            this.Name = "InputPersonForm";
            this.Size = new System.Drawing.Size(500, 270);
            this.groupPerson.ResumeLayout(false);
            this.groupPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqlCodeObjectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupPerson;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputSDT;
        private System.Windows.Forms.ComboBox inputSex;
        private System.Windows.Forms.Label label4;
        private CustomControl.EDateTimePicker inputBirthday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputRealname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputID;
        private System.Windows.Forms.BindingSource sqlCodeObjectBindingSource;
    }
}
