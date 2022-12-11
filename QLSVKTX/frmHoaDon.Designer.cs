namespace QLSVKTX
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNgayLapPhieu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoNuoc = new System.Windows.Forms.TextBox();
            this.txtSoDien = new System.Windows.Forms.TextBox();
            this.txtIDPhong = new System.Windows.Forms.TextBox();
            this.txtIDHoaDon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewHoaDon = new System.Windows.Forms.DataGridView();
            this.IDHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRepair = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNgayLapPhieu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSoNuoc);
            this.groupBox1.Controls.Add(this.txtSoDien);
            this.groupBox1.Controls.Add(this.txtIDPhong);
            this.groupBox1.Controls.Add(this.txtIDHoaDon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý hóa đơn";
            // 
            // txtNgayLapPhieu
            // 
            this.txtNgayLapPhieu.Location = new System.Drawing.Point(164, 155);
            this.txtNgayLapPhieu.Name = "txtNgayLapPhieu";
            this.txtNgayLapPhieu.Size = new System.Drawing.Size(191, 31);
            this.txtNgayLapPhieu.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày lập phiếu";
            // 
            // txtSoNuoc
            // 
            this.txtSoNuoc.Location = new System.Drawing.Point(542, 106);
            this.txtSoNuoc.Name = "txtSoNuoc";
            this.txtSoNuoc.Size = new System.Drawing.Size(191, 31);
            this.txtSoNuoc.TabIndex = 7;
            // 
            // txtSoDien
            // 
            this.txtSoDien.Location = new System.Drawing.Point(542, 44);
            this.txtSoDien.Name = "txtSoDien";
            this.txtSoDien.Size = new System.Drawing.Size(191, 31);
            this.txtSoDien.TabIndex = 6;
            // 
            // txtIDPhong
            // 
            this.txtIDPhong.Location = new System.Drawing.Point(164, 103);
            this.txtIDPhong.Name = "txtIDPhong";
            this.txtIDPhong.Size = new System.Drawing.Size(191, 31);
            this.txtIDPhong.TabIndex = 5;
            // 
            // txtIDHoaDon
            // 
            this.txtIDHoaDon.Location = new System.Drawing.Point(164, 41);
            this.txtIDHoaDon.Name = "txtIDHoaDon";
            this.txtIDHoaDon.Size = new System.Drawing.Size(191, 31);
            this.txtIDHoaDon.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số nước";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện (kg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số hóa đơn";
            // 
            // dataGridViewHoaDon
            // 
            this.dataGridViewHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDHoaDon,
            this.IDPhong,
            this.SoDien,
            this.SoNuoc,
            this.NgayLapPhieu});
            this.dataGridViewHoaDon.Location = new System.Drawing.Point(12, 297);
            this.dataGridViewHoaDon.Name = "dataGridViewHoaDon";
            this.dataGridViewHoaDon.RowHeadersWidth = 62;
            this.dataGridViewHoaDon.RowTemplate.Height = 33;
            this.dataGridViewHoaDon.Size = new System.Drawing.Size(776, 206);
            this.dataGridViewHoaDon.TabIndex = 1;
            this.dataGridViewHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHoaDon_CellClick);
            // 
            // IDHoaDon
            // 
            this.IDHoaDon.DataPropertyName = "IDHoaDon";
            this.IDHoaDon.HeaderText = "Số hóa đơn";
            this.IDHoaDon.MinimumWidth = 8;
            this.IDHoaDon.Name = "IDHoaDon";
            this.IDHoaDon.Width = 150;
            // 
            // IDPhong
            // 
            this.IDPhong.DataPropertyName = "IDPhong";
            this.IDPhong.HeaderText = "Số phòng";
            this.IDPhong.MinimumWidth = 8;
            this.IDPhong.Name = "IDPhong";
            this.IDPhong.Width = 150;
            // 
            // SoDien
            // 
            this.SoDien.DataPropertyName = "SoDien";
            this.SoDien.HeaderText = "Số điện";
            this.SoDien.MinimumWidth = 8;
            this.SoDien.Name = "SoDien";
            this.SoDien.Width = 150;
            // 
            // SoNuoc
            // 
            this.SoNuoc.DataPropertyName = "SoNuoc";
            this.SoNuoc.HeaderText = "Số nước";
            this.SoNuoc.MinimumWidth = 8;
            this.SoNuoc.Name = "SoNuoc";
            this.SoNuoc.Width = 150;
            // 
            // NgayLapPhieu
            // 
            this.NgayLapPhieu.DataPropertyName = "NgayLapPhieu";
            this.NgayLapPhieu.HeaderText = "Ngày lập phiếu";
            this.NgayLapPhieu.MinimumWidth = 8;
            this.NgayLapPhieu.Name = "NgayLapPhieu";
            this.NgayLapPhieu.Width = 150;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::QLSVKTX.Properties.Resources.them;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(28, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 50);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRepair
            // 
            this.btnRepair.Image = global::QLSVKTX.Properties.Resources.fix1;
            this.btnRepair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepair.Location = new System.Drawing.Point(235, 228);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(141, 50);
            this.btnRepair.TabIndex = 3;
            this.btnRepair.Text = "Sửa";
            this.btnRepair.UseVisualStyleBackColor = true;
            this.btnRepair.Click += new System.EventHandler(this.btnRepair_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::QLSVKTX.Properties.Resources.xoa;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(440, 228);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 50);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::QLSVKTX.Properties.Resources.thoat;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(633, 228);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRepair);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewHoaDon);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHoaDon";
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtNgayLapPhieu;
        private Label label5;
        private TextBox txtSoNuoc;
        private TextBox txtSoDien;
        private TextBox txtIDPhong;
        private TextBox txtIDHoaDon;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridViewHoaDon;
        private DataGridViewTextBoxColumn IDHoaDon;
        private DataGridViewTextBoxColumn IDPhong;
        private DataGridViewTextBoxColumn SoDien;
        private DataGridViewTextBoxColumn SoNuoc;
        private DataGridViewTextBoxColumn NgayLapPhieu;
        private Button btnAdd;
        private Button btnRepair;
        private Button btnDelete;
        private Button btnExit;
    }
}