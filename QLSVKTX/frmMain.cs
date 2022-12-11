namespace QLSVKTX
{
    public partial class frmMain : Form
    {
        frmLogIn frLI;
        frmQLSV frSV;
        frmPhong frP;
        frmHoaDon frHD;
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frSV = new frmQLSV();
            frSV.Show();
           
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            frP = new frmPhong();
            frP.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frLI= new frmLogIn();
            frLI.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            frHD = new frmHoaDon();
            frHD.Show();
        }
    }
}