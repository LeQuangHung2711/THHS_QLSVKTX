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
    public partial class frmQLSV : Form
    {
        frmMain frM;
        qlktxBLL bllKTX;
        public frmQLSV()
        {
            InitializeComponent();
            bllKTX = new qlktxBLL();
        }

        public void ShowAllSinhVien()
        {
            DataTable dt = bllKTX.getAllSinhVien();
            dataGridViewSinhVien.DataSource = dt;
        }

        private void frmQLSV_Load(object sender, EventArgs e)
        {
            ShowAllSinhVien();
        }

        private void txtNumRoom_TextChanged(object sender, EventArgs e)
        {

        }

        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtMSSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã số sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMSSV.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhone.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(cbbSex.Text))
            {
                MessageBox.Show("Bạn chưa chọn giới tính của sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbSex.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNumRoom.Text))
            {
                MessageBox.Show("Bạn chưa nhập số phòng sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumRoom.Focus();
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(CheckData())
            {
                tblSinhVien sv = new tblSinhVien();
                sv.MSSV = txtMSSV.Text;
                sv.TenSV = txtName.Text;
                sv.SDT= txtPhone.Text;
                sv.GioiTinh = cbbSex.Text;
                sv.IDPhong = txtNumRoom.Text;
                sv.NgayVao = txtDayIn.Text;
                
                if (bllKTX.InsertSinhVien(sv))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                    ShowAllSinhVien();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
               
            }
        }

        private void dataGridViewSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                txtMSSV.Text = dataGridViewSinhVien.Rows[index].Cells["MSSV"].Value.ToString();
                txtName.Text = dataGridViewSinhVien.Rows[index].Cells["TenSV"].Value.ToString();
                txtPhone.Text = dataGridViewSinhVien.Rows[index].Cells["SDT"].Value.ToString();
                cbbSex.Text = dataGridViewSinhVien.Rows[index].Cells["GioiTinh"].Value.ToString();
                txtNumRoom.Text = dataGridViewSinhVien.Rows[index].Cells["IDPhong"].Value.ToString();
                txtDayIn.Text = dataGridViewSinhVien.Rows[index].Cells["NgayVao"].Value.ToString();
            }
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                tblSinhVien sv = new tblSinhVien();
                sv.MSSV = txtMSSV.Text;
                sv.TenSV = txtName.Text;
                sv.SDT = txtPhone.Text;
                sv.GioiTinh = cbbSex.Text;
                sv.IDPhong = txtNumRoom.Text;
                sv.NgayVao = txtDayIn.Text;

                if (bllKTX.UpdateSinhVien(sv))
                {
                    ShowAllSinhVien();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tblSinhVien sv = new tblSinhVien();
                sv.MSSV = txtMSSV.Text;
                if (bllKTX.DeleteSinhVien(sv))
                {
                    ShowAllSinhVien();
                }
                else
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
    }
}
