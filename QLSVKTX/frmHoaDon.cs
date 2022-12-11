using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSVKTX
{
    public partial class frmHoaDon : Form
    {
        frmMain frM;
        qlktxBLL bllKTX;
        public frmHoaDon()
        {
            InitializeComponent();
            bllKTX= new qlktxBLL();
        }
        
        public void ShowAllHoaDon()
        {
            DataTable dt = bllKTX.getAllHoaDon();
            dataGridViewHoaDon.DataSource= dt;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            ShowAllHoaDon();
        }

        public bool checkData()
        {
            if(string.IsNullOrEmpty(txtIDHoaDon.Text))
            {
                MessageBox.Show("Bạn chưa nhập số hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDHoaDon.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtIDPhong.Text))
            {
                MessageBox.Show("Bạn chưa nhập số phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDPhong.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSoDien.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoDien.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSoNuoc.Text))
            {
                MessageBox.Show("Bạn chưa nhập số nước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoNuoc.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNgayLapPhieu.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày lập phiếu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNgayLapPhieu.Focus();
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                tblHoaDon hd = new tblHoaDon();
                hd.IDPhong = txtIDPhong.Text;
                hd.IDHoaDon= txtIDHoaDon.Text;
                hd.SoNuoc = txtSoNuoc.Text;
                hd.SoDien = txtSoDien.Text;
                hd.NgayLapPhieu = txtNgayLapPhieu.Text;
                try
                {
                    bllKTX.InsertHoaDon(hd);
                    ShowAllHoaDon();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                tblHoaDon hd = new tblHoaDon();
                hd.IDPhong = txtIDPhong.Text;
                hd.IDHoaDon = txtIDHoaDon.Text;
                hd.SoNuoc = txtSoNuoc.Text;
                hd.SoDien = txtSoDien.Text;
                hd.NgayLapPhieu = txtNgayLapPhieu.Text;
                try
                {
                    bllKTX.UpdateHoaDon(hd);
                    ShowAllHoaDon();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tblHoaDon hd = new tblHoaDon();
                hd.IDHoaDon = txtIDHoaDon.Text;
                try
                {
                    bllKTX.DeleteHoaDon(hd);
                    ShowAllHoaDon();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frM = new frmMain();
            frM.Show();
        }

        private void dataGridViewHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >=0 )
            {
                txtIDHoaDon.Text = dataGridViewHoaDon.Rows[index].Cells["IDHoaDon"].Value.ToString();
                txtIDPhong.Text = dataGridViewHoaDon.Rows[index].Cells["IDPhong"].Value.ToString();
                txtSoDien.Text = dataGridViewHoaDon.Rows[index].Cells["SoDien"].Value.ToString();
                txtSoNuoc.Text = dataGridViewHoaDon.Rows[index].Cells["SoNuoc"].Value.ToString();
                txtNgayLapPhieu.Text = dataGridViewHoaDon.Rows[index].Cells["NgayLapPhieu"].Value.ToString();

            }
        }
    }
}
