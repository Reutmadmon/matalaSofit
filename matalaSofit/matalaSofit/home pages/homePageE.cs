using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matalaSofit
{
    public partial class homePageE : Form
    {
        public homePageE()
        {
            InitializeComponent();
            menuPanel.Height = this.ClientSize.Height - 30;
            menuPanel.Left = 0;
            topBarPanel.Width = this.ClientSize.Width;
            topBarPanel.Top = 0;
            mainContentPanel.Height = this.ClientSize.Height - 40;
            mainContentPanel.Width = this.ClientSize.Width - 212;

        }
        private void homePageE_Resize(object sender, EventArgs e)
        {
            topBarPanel.Width = this.ClientSize.Width;
            menuPanel.Height = this.ClientSize.Height - 30;
            mainContentPanel.Height = this.ClientSize.Height - 40;
            mainContentPanel.Width = this.ClientSize.Width - 212;
            logOutButt.Top = menuPanel.Height - 92;
        }
        private void homePageE_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (menuPanel.Visible)
            {
                menuPanel.Visible = false;
                mainContentPanel.Left = 0;
                mainContentPanel.Width = this.ClientSize.Width;
            }
            else
            {
                menuPanel.Visible = true;
                mainContentPanel.Left = 212;
                mainContentPanel.Width = this.ClientSize.Width - 212;
            }

        }

        private void logOutButt_Click(object sender, EventArgs e)
        {
            loginPage loginPage = new loginPage();
            loginPage.ClientSize = this.ClientSize;
            loginPage.Show();
            this.Hide();
        }

        private void mainContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
