using matalaSofit.start;
using Microsoft.VisualBasic.Logging;

namespace matalaSofit
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            label1.Left = (panel1.ClientSize.Width - label1.Width) / 2;
            emplo.Left = (panel1.ClientSize.Width - emplo.Width) / 2;
            cust.Left = (panel1.ClientSize.Width - cust.Width) / 2;
            register.Left = (panel1.ClientSize.Width - register.Width) / 2;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signUp signUp = new signUp();
            signUp.Show();
            signUp.ClientSize = this.ClientSize;
            this.Hide();
        }
        private void loginPage_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            label1.Left = (panel1.ClientSize.Width - label1.Width) / 2;
            emplo.Left = (panel1.ClientSize.Width - emplo.Width) / 2;
            cust.Left = (panel1.ClientSize.Width - cust.Width) / 2;
            register.Left = (panel1.ClientSize.Width - register.Width) / 2;
        }
        private void loginPage_Load(object sender, EventArgs e)
        {

        }
        private void loginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void cust_Click(object sender, EventArgs e)
        {
            signInCus signInCus = new signInCus("login");
            signInCus.Show();
            signInCus.ClientSize = this.ClientSize;
            this.Hide();
        }

        private void emplo_Click(object sender, EventArgs e)
        {
            signInEmp signInEmp = new signInEmp();
            signInEmp.Show();
            signInEmp.ClientSize = this.ClientSize;
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
