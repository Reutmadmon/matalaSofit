using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1_c_.ex2
{
    public partial class Form2 : Form
    {
        private Form1 f1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            f1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            f1.Show();

        }
    }
}
