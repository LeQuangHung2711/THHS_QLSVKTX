namespace QLSVKTX
{
    partial class frmPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhong));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoLuongToiDa = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtIDNha = new System.Windows.Forms.TextBox();
            this.txtIDPhong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewPhong = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRepair = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.IDPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDDayNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoLuongToiDa);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtIDNha);
            this.groupBox1.Controls.Add(this.txtIDPhong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtSoLuongToiDa
            // 
            this.txtSoLuongToiDa.Location = new System.Drawing.Point(565, 106);
            this.txtSoLuongToiDa.Name = "txtSoLuongToiDa";
            this.txtSoLuongToiDa.Size = new System.Drawing.Size(205, 31);
            this.txtSoLuongToiDa.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(565, 45);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(205, 31);
            this.txtSoLuong.TabIndex = 6;
            // 
            // txtIDNha
            // 
            this.txtIDNha.Location = new System.Drawing.Point(159, 109);
            this.txtIDNha.Name = "txtIDNha";
            this.txtIDNha.Size = new System.Drawing.Size(205, 31);
            this.txtIDNha.TabIndex = 5;
            // 
            // txtIDPhong
            // 
            this.txtIDPhong.Location = new System.Drawing.Point(159, 42);
            this.txtIDPhong.Name = "txtIDPhong";
            this.txtIDPhong.Size = new System.Drawing.Size(205, 31);
            this.txtIDPhong.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng tối đa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số dãy nhà";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phòng";
            // 
            // dataGridViewPhong
            // 
            this.dataGridViewPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPhong,
            this.IDDayNha,
            this.SoLuong,
            this.SoLuongToiDa});
            this.dataGridViewPhong.Location = new System.Drawing.Point(12, 279);
            this.dataGridViewPhong.Name = "dataGridViewPhong";
            this.dataGridViewPhong.RowHeadersWidth = 62;
            this.dataGridViewPhong.RowTemplate.Height = 33;
            this.dataGridViewPhong.Size = new System.Drawing.Size(776, 193);
            this.dataGridViewPhong.TabIndex = 1;
            this.dataGridViewPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhong_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::QLSVKTX.Properties.Resources.them;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(18, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 46);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRepair
            // 
            this.btnRepair.Image = global::QLSVKTX.Properties.Resources.fix1;
            this.btnRepair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepair.Location = new System.Drawing.Point(220, 212);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(149, 46);
            this.btnRepair.TabIndex = 9;
            this.btnRepair.Text = "Sửa";
            this.btnRepair.UseVisualStyleBackColor = true;
            this.btnRepair.Click += new System.EventHandler(this.btnRepair_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::QLSVKTX.Properties.Resources.xoa;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(424, 212);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 46);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::QLSVKTX.Properties.Resources.thoat;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(633, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 46);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // IDPhong
            // 
            this.IDPhong.DataPropertyName = "IDPhong";
            this.IDPhong.HeaderText = "Số phòng";
            this.IDPhong.MinimumWidth = 8;
            this.IDPhong.Name = "IDPhong";
            this.IDPhong.Width = 160;
            // 
            // IDDayNha
            // 
            this.IDDayNha.DataPropertyName = "IDDayNha";
            this.IDDayNha.HeaderText = "Dãy nhà";
            this.IDDayNha.MinimumWidth = 8;
            this.IDDayNha.Name = "IDDayNha";
            this.IDDayNha.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng sinh viên";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 200;
            // 
            // SoLuongToiDa
            // 
            this.SoLuongToiDa.DataPropertyName = "SoLuongToiDa";
            this.SoLuongToiDa.HeaderText = "Số lượng tối đa";
            this.SoLuongToiDa.MinimumWidth = 8;
            this.SoLuongToiDa.Name = "SoLuongToiDa";
            this.SoLuongToiDa.Width = 200;
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRepair);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewPhong);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPhong";
            this.Text = "Quản lý phòng";
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSoLuongToiDa;
        private TextBox txtSoLuong;
        private TextBox txtIDNha;
        private TextBox txtIDPhong;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridViewPhong;
        private Button btnAdd;
        private Button btnRepair;
        private Button btnDelete;
        private Button btnExit;
        private DataGridViewTextBoxColumn IDPhong;
        private DataGridViewTextBoxColumn IDDayNha;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn SoLuongToiDa;
    }
}