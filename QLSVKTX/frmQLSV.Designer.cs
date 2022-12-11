namespace QLSVKTX
{
    partial class frmQLSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLSV));
            this.dataGridViewSinhVien = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDayIn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumRoom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbSex = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRepair = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSinhVien
            // 
            this.dataGridViewSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.TenSv,
            this.SDT,
            this.GioiTinh,
            this.IDPhong,
            this.NgayVao});
            this.dataGridViewSinhVien.Location = new System.Drawing.Point(12, 456);
            this.dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            this.dataGridViewSinhVien.RowHeadersWidth = 62;
            this.dataGridViewSinhVien.RowTemplate.Height = 33;
            this.dataGridViewSinhVien.Size = new System.Drawing.Size(1038, 308);
            this.dataGridViewSinhVien.TabIndex = 10;
            this.dataGridViewSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSinhVien_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDayIn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNumRoom);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(573, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 235);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phòng";
            // 
            // txtDayIn
            // 
            this.txtDayIn.Location = new System.Drawing.Point(178, 135);
            this.txtDayIn.Name = "txtDayIn";
            this.txtDayIn.Size = new System.Drawing.Size(250, 31);
            this.txtDayIn.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 3;
            // 
            // txtNumRoom
            // 
            this.txtNumRoom.Location = new System.Drawing.Point(178, 56);
            this.txtNumRoom.Name = "txtNumRoom";
            this.txtNumRoom.Size = new System.Drawing.Size(250, 31);
            this.txtNumRoom.TabIndex = 6;
            this.txtNumRoom.TextChanged += new System.EventHandler(this.txtNumRoom_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày vào";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số phòng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbSex);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 235);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // cbbSex
            // 
            this.cbbSex.FormattingEnabled = true;
            this.cbbSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbbSex.Location = new System.Drawing.Point(193, 170);
            this.cbbSex.Name = "cbbSex";
            this.cbbSex.Size = new System.Drawing.Size(249, 33);
            this.cbbSex.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(27, 168);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 25);
            this.label19.TabIndex = 8;
            this.label19.Text = "Giới tính";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(193, 130);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(249, 31);
            this.txtPhone.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(193, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(249, 31);
            this.txtName.TabIndex = 5;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(193, 43);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(249, 31);
            this.txtMSSV.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "SĐT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnRepair);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Location = new System.Drawing.Point(21, 297);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1013, 119);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::QLSVKTX.Properties.Resources.thoat;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(831, 46);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(176, 51);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRepair
            // 
            this.btnRepair.Image = global::QLSVKTX.Properties.Resources.fix1;
            this.btnRepair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepair.Location = new System.Drawing.Point(299, 46);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(176, 51);
            this.btnRepair.TabIndex = 8;
            this.btnRepair.Text = "Sửa";
            this.btnRepair.UseVisualStyleBackColor = true;
            this.btnRepair.Click += new System.EventHandler(this.btnRepair_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::QLSVKTX.Properties.Resources.xoa;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(552, 46);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 51);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::QLSVKTX.Properties.Resources.them;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(27, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 51);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MSSV
            // 
            this.MSSV.DataPropertyName = "MSSV";
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.MinimumWidth = 8;
            this.MSSV.Name = "MSSV";
            this.MSSV.Width = 150;
            // 
            // TenSv
            // 
            this.TenSv.DataPropertyName = "TenSV";
            this.TenSv.HeaderText = "Họ và tên";
            this.TenSv.MinimumWidth = 8;
            this.TenSv.Name = "TenSv";
            this.TenSv.Width = 170;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.MinimumWidth = 8;
            this.SDT.Name = "SDT";
            this.SDT.Width = 150;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 8;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 150;
            // 
            // IDPhong
            // 
            this.IDPhong.DataPropertyName = "IDPhong";
            this.IDPhong.HeaderText = "Số Phòng";
            this.IDPhong.MinimumWidth = 8;
            this.IDPhong.Name = "IDPhong";
            this.IDPhong.Width = 150;
            // 
            // NgayVao
            // 
            this.NgayVao.DataPropertyName = "NgayVao";
            this.NgayVao.HeaderText = "Ngày vào";
            this.NgayVao.MinimumWidth = 8;
            this.NgayVao.Name = "NgayVao";
            this.NgayVao.Width = 200;
            // 
            // frmQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1073, 776);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridViewSinhVien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLSV";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.frmQLSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewSinhVien;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox txtNumRoom;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private TextBox txtPhone;
        private TextBox txtName;
        private TextBox txtMSSV;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private GroupBox groupBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private GroupBox groupBox5;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label10;
        private Label label11;
        private TextBox textBox2;
        private Label label12;
        private Label label13;
        private Label label14;
        private GroupBox groupBox6;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private GroupBox groupBox3;
        private Button btnExit;
        private Button btnRepair;
        private Button btnDelete;
        private Button btnAdd;
        private ComboBox cbbSex;
        private Label label19;
        private TextBox txtDayIn;
        private DataGridViewTextBoxColumn MSSV;
        private DataGridViewTextBoxColumn TenSv;
        private DataGridViewTextBoxColumn SDT;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn IDPhong;
        private DataGridViewTextBoxColumn NgayVao;
    }
}