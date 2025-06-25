using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace matalaSofit
{
    public partial class homePageC : Form
    {
        private Button[] buttons;
        public homePageC()
        {
            InitializeComponent();
            buttons = new Button[] { messButt, profButt, searButt, settButt };
            menuPanel.Height = this.ClientSize.Height - 40;
            menuPanel.Left = 0;

            topBarPanel.Width = this.ClientSize.Width;
            topBarPanel.Top = 0;

            mainContentPanel.Size = new Size(this.ClientSize.Width - 212, this.ClientSize.Height - 40);
            logOutButt.Top = menuPanel.Height - 92;
            

            pictureBox1.Left = (topBarPanel.Width - pictureBox1.Width);

            // messages panel
            messPanel.Size = new Size(mainContentPanel.Width - 108, mainContentPanel.Height - 80);
            boxMessPanel.Size = new Size(messPanel.Width / 3, messPanel.Height);
            boxMessPanel.Left = messPanel.Width - boxMessPanel.Width;
            messPanel.Location = new Point((mainContentPanel.Width - messPanel.Width) / 2, (mainContentPanel.Height - messPanel.Height) / 2);

            // search panel
            searchPanel.Size = new Size(mainContentPanel.Width - 108, mainContentPanel.Height - 80);
            searchPanel.Location = new Point((mainContentPanel.Width - searchPanel.Width) / 2, (mainContentPanel.Height - searchPanel.Height) / 2);

            searLinePanel.Width = searchPanel.Width - 25;
            searLinePanel.Location = new Point((searchPanel.Width - searLinePanel.Width) / 2, 10);

            sBookPanel.Width = searchPanel.Width - 25;
            sBookPanel.Height = searchPanel.Height - 51;

            textBox1.Width = searLinePanel.Width - 50;
            textBox1.Left = 0;

            searchB.Left = searchPanel.Width - 70;

            //profile panel
            profPanel.Size = new Size(mainContentPanel.Width - 108, mainContentPanel.Height - 80);
            profPanel.Location = new Point((mainContentPanel.Width - profPanel.Width) / 2, (mainContentPanel.Height - profPanel.Height) / 2);
            historyPanel.Location = new Point(profPanel.Width - historyPanel.Width, profPanel.Height - historyPanel.Height);
            historyLab.Location = new Point(profPanel.Width - historyPanel.Width, profPanel.Height - historyPanel.Height - borrBookLab.Height);
            historyLab.Width = historyPanel.Width;
            borrBookPanel.Location = new Point(0, profPanel.Height - borrBookPanel.Height);
            borrBookLab.Width = borrBookPanel.Width;

         
        }
        private bool isVisible = true;
        private void homePageC_Resize(object sender, EventArgs e)
        {
            topBarPanel.Width = this.ClientSize.Width;
            menuPanel.Height = this.ClientSize.Height - 40;
            mainContentPanel.Size = new Size(this.ClientSize.Width - 212, this.ClientSize.Height - 40);

            if (isVisible)
            {
                messPanel.Size = new Size(mainContentPanel.Width - 108, mainContentPanel.Height - 80);
                searchPanel.Size = new Size(mainContentPanel.Width - 108, mainContentPanel.Height - 80);
                profPanel.Size = new Size(mainContentPanel.Width - 108, mainContentPanel.Height - 80);

            }
            else
            {

                mainContentPanel.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - 40);
                messPanel.Size = new Size(mainContentPanel.Width - 320, mainContentPanel.Height - 80);
                searchPanel.Size = new Size(mainContentPanel.Width - 302, mainContentPanel.Height - 80);
                profPanel.Size = new Size(mainContentPanel.Width - 302, mainContentPanel.Height - 80);


            }
            messPanel.Location = new Point((mainContentPanel.Width - messPanel.Width) / 2, (mainContentPanel.Height - messPanel.Height) / 2);
            searchPanel.Location = new Point((mainContentPanel.Width - searchPanel.Width) / 2, (mainContentPanel.Height - searchPanel.Height) / 2);

            // messages Panel
            boxMessPanel.Size = new Size(messPanel.Width / 3, messPanel.Height);
            boxMessPanel.Left = messPanel.Width - boxMessPanel.Width;


            // search Panel 
            searLinePanel.Width = searchPanel.Width - 25;
            searLinePanel.Location = new Point((searchPanel.Width - searLinePanel.Width) / 2, 10);

            sBookPanel.Width = searchPanel.Width - 25;
            sBookPanel.Height = searchPanel.Height - 51;

            textBox1.Width = searLinePanel.Width - 50;
            textBox1.Left = 0;

            searchB.Left = searchPanel.Width - 70;

            // profile panel 
            profPanel.Location = new Point((mainContentPanel.Width - profPanel.Width) / 2, (mainContentPanel.Height - profPanel.Height) / 2);
            historyPanel.Location = new Point(profPanel.Width - historyPanel.Width, profPanel.Height- historyPanel.Height);
            historyLab.Location = new Point(profPanel.Width - historyPanel.Width, profPanel.Height - historyPanel.Height - borrBookLab.Height);
            historyLab.Width = historyPanel.Width;
            borrBookPanel.Location = new Point(0, profPanel.Height - borrBookPanel.Height);
            borrBookLab.Width = borrBookPanel.Width;
            
            
            logOutButt.Top = menuPanel.Height - 92;
            pictureBox1.Left = (topBarPanel.Width - pictureBox1.Width);

        }
        private void homePageC_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void nameLa_Hover(object sender, EventArgs e)
        {
            nameLa.AutoSize = true;
        }

        private void nameLa_Leave(object sender, EventArgs e)
        {
            nameLa.AutoSize = false;
        }

        private void emailLa_Hover(object sender, EventArgs e)
        {
            emailLa.AutoSize = true;
        }

        private void emailLa_Leave(object sender, EventArgs e)
        {
            emailLa.AutoSize = false;
        }

        private void logOutButt_Click(object sender, EventArgs e)
        {
            loginPage loginPage = new loginPage();
            loginPage.ClientSize = this.ClientSize;
            loginPage.Show();
            this.Hide();
        }

        private void menuButt_Click(object sender, EventArgs e)
        {
            if (menuPanel.Visible)
            {

                menuPanel.Visible = false;
                mainContentPanel.Left = 0;
                mainContentPanel.Width = this.ClientSize.Width;
                messPanel.Location = new Point((mainContentPanel.Width - messPanel.Width) / 2, (mainContentPanel.Height - messPanel.Height) / 2);
                searchPanel.Location = new Point((mainContentPanel.Width - searchPanel.Width) / 2, (mainContentPanel.Height - searchPanel.Height) / 2);
                profPanel.Location = new Point((mainContentPanel.Width - profPanel.Width) / 2, (mainContentPanel.Height - profPanel.Height) / 2);

                isVisible = false;
            }
            else
            {
                menuPanel.Visible = true;
                mainContentPanel.Left = 212;
                mainContentPanel.Width = this.ClientSize.Width - 212;
                messPanel.Location = new Point((mainContentPanel.Width - messPanel.Width) / 2, (mainContentPanel.Height - messPanel.Height) / 2);
                searchPanel.Location = new Point((mainContentPanel.Width - searchPanel.Width) / 2, (mainContentPanel.Height - searchPanel.Height) / 2);
                profPanel.Location = new Point((mainContentPanel.Width - profPanel.Width) / 2, (mainContentPanel.Height - profPanel.Height) / 2);
                isVisible = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void messButt_Click(object sender, EventArgs e)
        {
            foreach (Button b in buttons)
            {
                b.BackColor = Color.FromArgb(64, 73, 110);
                b.ForeColor = Color.White;
            }
            messButt.BackColor = Color.AliceBlue;
            messButt.ForeColor = Color.Black;
            searchPanel.Visible = false;
            profPanel.Visible = false;

            messPanel.Visible = true;
        }

        private void searButt_Click(object sender, EventArgs e)
        {
            foreach (Button b in buttons)
            {
                b.BackColor = Color.FromArgb(64, 73, 110);
                b.ForeColor = Color.White;
            }
            searButt.BackColor = Color.AliceBlue;
            searButt.ForeColor = Color.Black;
            messPanel.Visible = false;
            profPanel.Visible = false;

            searchPanel.Visible = true;

        }
        private void profButt_Click(object sender, EventArgs e)

        {
            foreach (Button b in buttons)
            {
                b.BackColor = Color.FromArgb(64, 73, 110);
                b.ForeColor = Color.White;
            }
            profButt.BackColor = Color.AliceBlue;
            profButt.ForeColor = Color.Black;
            messPanel.Visible = false;
            searchPanel.Visible = false;
            profPanel.Visible = true;
        }

        private void idLa_Click(object sender, EventArgs e)
        {

        }

        private void emailLa_Click(object sender, EventArgs e)
        {

        }

        private void homePageC_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox2.Width - 1, pictureBox2.Height - 1);
            Region rg = new Region(gp);
            pictureBox2.Region = rg;
        }
    }
}
