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

            settPanel.Location = new Point((mainContentPanel.Width - settPanel.Width) / 2, (mainContentPanel.Height - settPanel.Height) / 2);
            settPanel.Size = new Size(mainContentPanel.Width - 108, mainContentPanel.Height - 80);


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
            historyPanel.Size = new Size(profPanel.Width / 2 - 10, profPanel.Height / 2);
            profPanel.Location = new Point((mainContentPanel.Width - profPanel.Width) / 2, (mainContentPanel.Height - profPanel.Height) / 2);
            historyPanel.Location = new Point(profPanel.Width - historyPanel.Width, profPanel.Height - historyPanel.Height);
            historyLab.Width = historyPanel.Width;
            borrBookPanel.Size = new Size(profPanel.Width / 2 - 10, profPanel.Height / 2);
            borrBookPanel.Location = new Point(0, profPanel.Height - borrBookPanel.Height);
            borrBookLab.Width = borrBookPanel.Width;

            // settings panel
            pictureBox3.Size = new Size(settPanel.Width / 4, settPanel.Height / 4);
            pictureBox3.Location = new Point(0, 0);
            pictureBox4.Size = new Size(settPanel.Width / 4, settPanel.Height / 4);
            pictureBox4.Location = new Point(0, pictureBox3.Height + 10);
            pictureBox5.Size = new Size(settPanel.Width / 4, settPanel.Height / 4);
            pictureBox5.Location = new Point(pictureBox3.Width + 10, 0);

            mainContentPanel.ForeColor = Color.Black;
            menuPanel.ForeColor = Color.White;

        }
        private bool isVisible = true;
        private void homePageC_Resize(object sender, EventArgs e)
        {
            topBarPanel.Width = this.ClientSize.Width;
            menuPanel.Height = this.ClientSize.Height - 40;
            mainContentPanel.Size = new Size(this.ClientSize.Width - 212, this.ClientSize.Height - 40);
            logOutButt.Top = menuPanel.Height - 92;
            pictureBox1.Left = (topBarPanel.Width - pictureBox1.Width);

            if (isVisible)
            {
                messPanel.Size = new Size(mainContentPanel.Width - 108, mainContentPanel.Height - 80);
                searchPanel.Size = new Size(mainContentPanel.Width - 108, mainContentPanel.Height - 80);
                profPanel.Size = new Size(mainContentPanel.Width - 108, mainContentPanel.Height - 80);
                settPanel.Size = new Size(mainContentPanel.Width - 108, mainContentPanel.Height - 80);
            }else
            {
                mainContentPanel.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - 40);
                messPanel.Size = new Size(mainContentPanel.Width - 320, mainContentPanel.Height - 80);
                searchPanel.Size = new Size(mainContentPanel.Width - 302, mainContentPanel.Height - 80);
                profPanel.Size = new Size(mainContentPanel.Width - 302, mainContentPanel.Height - 80);
                settPanel.Size = new Size(mainContentPanel.Width - 302, mainContentPanel.Height - 80);
            }
            // panels location:
            messPanel.Location = new Point((mainContentPanel.Width - messPanel.Width) / 2, (mainContentPanel.Height - messPanel.Height) / 2);
            searchPanel.Location = new Point((mainContentPanel.Width - searchPanel.Width) / 2, (mainContentPanel.Height - searchPanel.Height) / 2);
            settPanel.Location = new Point((mainContentPanel.Width - settPanel.Width) / 2, (mainContentPanel.Height - settPanel.Height) / 2);
            profPanel.Location = new Point((mainContentPanel.Width - profPanel.Width) / 2, (mainContentPanel.Height - profPanel.Height) / 2);

            // messages Panel:
            boxMessPanel.Size = new Size(messPanel.Width / 3, messPanel.Height);
            boxMessPanel.Left = messPanel.Width - boxMessPanel.Width;


            // search Panel:
            searLinePanel.Width = searchPanel.Width - 25;
            searLinePanel.Location = new Point((searchPanel.Width - searLinePanel.Width) / 2, 10);

            sBookPanel.Width = searchPanel.Width - 25;
            sBookPanel.Height = searchPanel.Height - 51;

            textBox1.Width = searLinePanel.Width - 50;
            textBox1.Left = 0;

            searchB.Left = searchPanel.Width - 70;

            // profile panel:
            historyPanel.Size = new Size(profPanel.Width / 2 - 10, profPanel.Height / 2);
            historyPanel.Location = new Point(profPanel.Width - historyPanel.Width, profPanel.Height - historyPanel.Height);
            historyLab.Width = historyPanel.Width;
            borrBookPanel.Size = new Size(profPanel.Width / 2 - 10, profPanel.Height / 2);
            borrBookPanel.Location = new Point(0, profPanel.Height - borrBookPanel.Height);
            borrBookLab.Width = borrBookPanel.Width;

            //settings panel:
            pictureBox3.Size = new Size(settPanel.Width / 4, settPanel.Height / 4);
            pictureBox3.Location = new Point(0, 0);
            pictureBox4.Size = new Size(settPanel.Width / 4, settPanel.Height / 4);
            pictureBox4.Location = new Point(0, pictureBox3.Height+10);
            pictureBox5.Size = new Size(settPanel.Width / 4, settPanel.Height / 4);
            pictureBox5.Location = new Point(pictureBox3.Width+10, 0);


            

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
                settPanel.Location = new Point((mainContentPanel.Width - settPanel.Width) / 2, (mainContentPanel.Height - settPanel.Height) / 2);

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
                settPanel.Location = new Point((mainContentPanel.Width - settPanel.Width) / 2, (mainContentPanel.Height - settPanel.Height) / 2);

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
                b.BackColor = menuPanel.BackColor;
                b.ForeColor = menuPanel.ForeColor;
            }
            messButt.BackColor = mainContentPanel.BackColor;
            messButt.ForeColor = mainContentPanel.ForeColor;
            searchPanel.Visible = false;
            profPanel.Visible = false;
            settPanel.Visible = false;
            messPanel.Visible = true;
        }

        private void searButt_Click(object sender, EventArgs e)
        {
            foreach (Button b in buttons)
            {
                    b.BackColor = menuPanel.BackColor;
                    b.ForeColor = menuPanel.ForeColor;
            }
            searButt.BackColor = mainContentPanel.BackColor;
            searButt.ForeColor = mainContentPanel.ForeColor;
            messPanel.Visible = false;
            profPanel.Visible = false;
            settPanel.Visible = false;
            searchPanel.Visible = true;

        }
        private void profButt_Click(object sender, EventArgs e)

        {
            foreach (Button b in buttons)
            {
                b.BackColor = menuPanel.BackColor;
                b.ForeColor = menuPanel.ForeColor;
            }
            profButt.BackColor = mainContentPanel.BackColor;
            profButt.ForeColor = mainContentPanel.ForeColor;
            messPanel.Visible = false;
            searchPanel.Visible = false;
            settPanel.Visible = false;
            profPanel.Visible = true;
        }

        private void settButt_Click(object sender, EventArgs e)
        {
            foreach (Button b in buttons)
            {
                b.BackColor = menuPanel.BackColor;
                b.ForeColor = menuPanel.ForeColor;
            }
            settButt.BackColor = mainContentPanel.BackColor;
            settButt.ForeColor = mainContentPanel.ForeColor;
            messPanel.Visible = false;
            searchPanel.Visible = false;
            profPanel.Visible = false;
            settPanel.Visible = true;
        }
        private void idLa_Click(object sender, EventArgs e)
        {

        }

        private void emailLa_Click(object sender, EventArgs e)
        {

        }

        private void homePageC_Load(object sender, EventArgs e) // עושה שתמונת הפרופיל תהיה עגולה
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox2.Width - 1, pictureBox2.Height - 1);
            Region rg = new Region(gp);
            pictureBox2.Region = rg;
        }

        private void historyLab_Click(object sender, EventArgs e)
        {

        }

        private void LightBlueTheme(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                // שינוי צבע רקע
                if (ctrl.BackColor == Color.FromArgb(36, 39, 50) // שחור
                    || ctrl.BackColor == Color.FromArgb(255, 255, 255)) // ורוד

                {
                    ctrl.BackColor = Color.AliceBlue;
                    ctrl.ForeColor = Color.Black;
                }
                // שינוי תיבות
                if (ctrl.BackColor == Color.FromArgb(235, 220, 220) // ורוד
                    || ctrl.BackColor == Color.FromArgb(58, 62, 84)) // שחור
                {
                    ctrl.BackColor = SystemColors.ActiveCaption;
                    ctrl.ForeColor = Color.Black;
                }
                // שינוי תפריט
                if (ctrl.BackColor == Color.FromArgb(248, 218, 218) // ורוד
                    || ctrl.BackColor == Color.FromArgb(30, 40, 60)) // שחור
                {
                    ctrl.BackColor = Color.FromArgb(64, 73, 110);
                    ctrl.ForeColor = Color.White;
                }
                if (ctrl.ForeColor == SystemColors.ControlDarkDark)
                {

                }
                // אם לקונטרול הזה יש ילדים – נפעיל את הפונקציה עליהם גם
                if (ctrl.HasChildren)
                {
                    LightBlueTheme(ctrl);
                }
            }
            

        }

        private void MidnightTheme(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                // שינוי צבע רקע
                if (ctrl.BackColor == Color.AliceBlue // כחול
                    || ctrl.BackColor == Color.FromArgb(255, 255, 255) // ורוד
                    || ctrl.BackColor == Color.White) 

                {
                    ctrl.BackColor = Color.FromArgb(36, 39, 50);
                    ctrl.ForeColor = Color.White;
                }
                // שינוי תיבות
                if (ctrl.BackColor == SystemColors.ActiveCaption // כחול
                    || ctrl.BackColor == Color.FromArgb(235, 220, 220)) // ורוד
                {
                    ctrl.BackColor = Color.FromArgb(58, 62, 84);
                    ctrl.ForeColor = Color.White;   
                }
                // שינוי תפריט
                if (ctrl.BackColor == Color.FromArgb(64, 73, 110) // כחול
                    || ctrl.BackColor == Color.FromArgb(248, 218, 218)) // ורוד
                {
                    ctrl.BackColor = Color.FromArgb(30, 40, 60);
                    ctrl.ForeColor = Color.White;
                }
                if (ctrl.ForeColor == SystemColors.ControlDarkDark)
                {

                }
                // אם לקונטרול הזה יש ילדים – נפעיל את הפונקציה עליהם גם
                if (ctrl.HasChildren)
                {
                    MidnightTheme(ctrl);
                }
            }
            
        }
        private void SoftPinkTheme(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                // שינוי צבע רקע
                if (ctrl.BackColor == Color.AliceBlue // כחול
                    || ctrl.BackColor == Color.FromArgb(36, 39, 50)) // שחור

                {
                    ctrl.BackColor = Color.FromArgb(255, 255, 255);
                    ctrl.ForeColor = Color.Black;
                }
                // שינוי תיבות
                if (ctrl.BackColor == SystemColors.ActiveCaption // כחול
                    || ctrl.BackColor == Color.FromArgb(58, 62, 84)) // שחור
                {
                    ctrl.BackColor = Color.FromArgb(235, 220, 220);
                    ctrl.ForeColor = Color.Black;
                }
                // שינוי תפריט
                if (ctrl.BackColor == Color.FromArgb(64, 73, 110) // כחול
                    || ctrl.BackColor == Color.FromArgb(30, 40, 60)) // שחור
                {
                    ctrl.BackColor = Color.FromArgb(248, 218, 218);
                    ctrl.ForeColor = Color.White;
                }
                if (ctrl.ForeColor == SystemColors.ControlDarkDark)
                {

                }
                // אם לקונטרול הזה יש ילדים – נפעיל את הפונקציה עליהם גם
                if (ctrl.HasChildren)
                {
                    SoftPinkTheme(ctrl);
                }
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MidnightTheme(this);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SoftPinkTheme(this);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LightBlueTheme(this);
        }
    }
}
