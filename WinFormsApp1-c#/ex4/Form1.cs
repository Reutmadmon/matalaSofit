using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1_c_.ex4
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this checks if the client is already logged in

            String userName = textBox1.Text;
            String password = textBox2.Text;

            bool found = false;

            foreach (string line in File.ReadLines("usersInfo.txt"))
            {
                if (line.Contains($"username: {userName}") && line.Contains($"password: {password}"))
                {
                    found = true;
                    break;
                }
               
            }

            if (found)
            {
                form2 = new Form2();
                form2.Show();
                this.Close();
            }
            else
            {
                textBox3.Visible = true;
            }


        }

       
    }
}
