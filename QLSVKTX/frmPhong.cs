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
    public partial class frmPhong : Form
    {
        frmMain frM;
        qlktxBLL bllKTX;
        public frmPhong()
        {
            InitializeComponent();
            bllKTX = new qlktxBLL();
        }

        public void ShowAllPhong()
        {
            DataTable dt = bllKTX.getAllPhong();
            dataGridViewPhong.DataSource = dt;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            ShowAllPhong();
        }

        public bool checkData()
        {
            if (string.IsNullOrEmpty(txtIDPhong.Text))
            {
                MessageBox.Show("Bạn chưa nhập số phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDPhong.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtIDNha.Text))
            {
                MessageBox.Show("Bạn chưa nhập tòa nhà.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDNha.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSoLuongToiDa.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng sinh viên tối đa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuongToiDa.Focus();
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                tblPhongKTX p = new tblPhongKTX();
                p.IDPhong = txtIDPhong.Text;
                p.IDDayNha = txtIDNha.Text;
                p.SoLuong = txtSoLuong.Text;
                p.SoLuongToiDa = txtSoLuongToiDa.Text;
                try
                {
                    bllKTX.InsertPhong(p);
                    ShowAllPhong();
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
                tblPhongKTX p = new tblPhongKTX();
                p.IDPhong = txtIDPhong.Text;
                p.IDDayNha = txtIDNha.Text;
                p.SoLuong = txtSoLuong.Text;
                p.SoLuongToiDa = txtSoLuongToiDa.Text;
                try
                {
                    bllKTX.UpdatePhong(p);
                    ShowAllPhong();
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
                tblPhongKTX p = new tblPhongKTX();
                p.IDPhong = txtIDPhong.Text;
                try
                {
                    bllKTX.DeletePhong(p);
                    ShowAllPhong();
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

        private void dataGridViewPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            if (index >= 0)
            {
                txtIDPhong.Text = dataGridViewPhong.Rows[index].Cells["IDPhong"].Value.ToString();
                txtIDNha.Text = dataGridViewPhong.Rows[index].Cells["IDDayNha"].Value.ToString();
                txtSoLuong.Text = dataGridViewPhong.Rows[index].Cells["SoLuong"].Value.ToString();
                txtSoLuongToiDa.Text = dataGridViewPhong.Rows[index].Cells["SoLuongToiDa"].Value.ToString();
                

            }
        }
    }
}
