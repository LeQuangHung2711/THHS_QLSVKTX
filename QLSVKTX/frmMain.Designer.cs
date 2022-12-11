namespace QLSVKTX
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnQLSV = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPhong = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQLSV
            // 
            this.btnQLSV.Location = new System.Drawing.Point(38, 34);
            this.btnQLSV.Name = "btnQLSV";
            this.btnQLSV.Size = new System.Drawing.Size(179, 49);
            this.btnQLSV.TabIndex = 0;
            this.btnQLSV.Text = "Quản lý sinh viên";
            this.btnQLSV.UseVisualStyleBackColor = true;
            this.btnQLSV.Click += new System.EventHandler(this.btnQLSV_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLSVKTX.Properties.Resources._1024;
            this.pictureBox1.Location = new System.Drawing.Point(1, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1051, 389);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnPhong
            // 
            this.btnPhong.Location = new System.Drawing.Point(305, 34);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(179, 49);
            this.btnPhong.TabIndex = 2;
            this.btnPhong.Text = "Quản lý phòng";
            this.btnPhong.UseVisualStyleBackColor = true;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Location = new System.Drawing.Point(586, 34);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(179, 49);
            this.btnHoaDon.TabIndex = 3;
            this.btnHoaDon.Text = "Quản lý hóa đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(858, 34);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(179, 49);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 511);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.btnPhong);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnQLSV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox gbTTSV;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnQLSV;
        private PictureBox pictureBox1;
        private Button btnPhong;
        private Button btnHoaDon;
        private Button btnExit;
    }
}