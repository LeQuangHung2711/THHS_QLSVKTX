using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSVKTX
{
    public partial class frmLogIn : Form
    {
        string strConnection = @"Data Source=.;Initial Catalog=QLSVKTX;Integrated Security=True";
        SqlConnection conn;
        frmMain frM;

        SqlCommand cmd;
        DataConnection dc;

        public frmLogIn()
        {
            dc = new DataConnection();
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            conn= new SqlConnection(strConnection);
            try
            {
                conn.Open();
                string tk = txtUser.Text;
                string mk = txtPass.Text;

                string sql = "SELECT * FROM tblLogIN WHERE TK='" + tk + "'AND MK='" + mk + "'";
                cmd= new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    this.Hide();
                    frM = new frmMain();
                    frM.Show();
                }
                else
                {
                    lbThongBao.Text = "Tài Khoản hoặc mật khẩu không đúng";
                    txtPass.Focus();
                }
            }
            catch(Exception ex)
            {
                lbThongBao.Text = "Lỗi kết nối";
            }
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowPass.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
}
