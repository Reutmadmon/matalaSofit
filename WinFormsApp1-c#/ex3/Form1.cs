using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1_c_.ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this saves text from both text boxes to a file
            String userName = textBox1.Text;
            String password = textBox2.Text;

            String fullInput =$"username: {userName},password: {password}";
            File.AppendAllText("usersInfo.txt", fullInput + Environment.NewLine);
        }
    }
}
