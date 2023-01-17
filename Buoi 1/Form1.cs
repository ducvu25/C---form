namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int dem = 0;
        private void btnMenu_Click(object sender, EventArgs e)
        {
            /*dem++;
            if(dem%2 == 0)
                lblTen.Text = "hello world";
            else
                lblTen.Text = "good bye";
            MessageBox.Show("Loi");*/
            /*lblTen.Text = "Xin chào " + txtA.Text;*/
        }

        private void Ten_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                
                double so1 = 0, so2 = 0;
                so1 = double.Parse(txtA.Text);
                so2 = double.Parse(txtB.Text);

                double KQ = so1 + so2;
                lblBieuThuc.Text = txtA.Text + " + " + txtB.Text + " = " + KQ.ToString();
            }
            catch
            {
                
                MessageBox.Show("Lỗi kiểu dữ liệu");
                txtA.Text = "";
                txtA.Focus();
                txtB.Text = "";
            }
            
        }


        private void btnTru_Click(object sender, EventArgs e)
        {
            lblBieuThuc.Text = txtA.Text + " - " + txtB.Text;
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            lblBieuThuc.Text = txtA.Text + " x " + txtB.Text;
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            lblBieuThuc.Text = txtA.Text + " / " + txtB.Text;
        }
        private void lblBieuThuc_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            //fm2.Show();
            fm2.str = txtA.Text;
            fm2.ShowDialog();
        }
    }
}