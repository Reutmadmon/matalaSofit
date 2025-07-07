using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matalaSofit.start
{
    public partial class signInEmp : Form
    {
        public signInEmp()
        {
            InitializeComponent();
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            password.Left = (panel1.ClientSize.Width - password.Width) / 2;
            id.Left = (panel1.ClientSize.Width - id.Width) / 2;
            logIn.Left = (panel1.ClientSize.Width - logIn.Width) / 2;
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            back.Left = (this.ClientSize.Width - back.Width) - 20;
        }

        private void signIn_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            password.Left = (panel1.ClientSize.Width - password.Width) / 2;
            id.Left = (panel1.ClientSize.Width - id.Width) / 2;
            logIn.Left = (panel1.ClientSize.Width - logIn.Width) / 2;
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            back.Left = (this.ClientSize.Width - back.Width) - 20;
        }
        private void signIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private bool isPassword = true;
        private bool isId = true;

        private void password_Enter(object sender, EventArgs e)
        {
            if (isPassword)
            {
                password.Text = "";
                password.ForeColor = Color.Black;
                password.UseSystemPasswordChar = true;
                isPassword = false;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(password.Text))
            {
                password.Text = "password";
                password.ForeColor = Color.Gray;
                password.UseSystemPasswordChar = false;
                isPassword = true;
            }
        }

        private void id_Enter(object sender, EventArgs e)
        {
            if (isId)
            {
                id.Text = "";
                id.ForeColor = Color.Black;
                isId = false;
            }
        }

        private void id_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id.Text))
            {
                id.Text = "id";
                id.ForeColor = Color.Gray;
                isId = true;
            }
        }

        private void signInEmp_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            loginPage loginPage = new loginPage();
            loginPage.ClientSize = this.ClientSize;
            loginPage.Show();
            this.Hide();
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines("../../../Files/myfile.txt");
                bool isFound = false;
                foreach (string line in lines)
                {
                    if (line.Equals(id.Text + ":" + password.Text+":E"))
                    {
                        isFound = true;
                        homePageE homePageE = new homePageE();
                        homePageE.ClientSize = this.ClientSize;
                        homePageE.Show();
                        this.Hide();
                    }


                }
                if (!isFound)
                    isNotFL.Visible = true;
            }
            catch (Exception ex)
            {

            }

            
        }
    }
}
