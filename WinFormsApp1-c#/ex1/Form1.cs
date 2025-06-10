namespace WinFormsApp1_c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                textBox2.Text = textBox1.Text;
                textBox1.Clear();
            }
            else if (!string.IsNullOrEmpty(textBox2.Text))
            {
                textBox1.Text = textBox2.Text;
                textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.ReadOnly == true)
            {
                button2.Text = "lock";

                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;

            }
            else if (textBox2.ReadOnly == false)
            {
                button2.Text = "unlock";
                textBox2.ReadOnly = true;
                textBox1.ReadOnly = true;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Color colour = textBox1.BackColor;
            textBox1.BackColor = textBox2.BackColor;
            textBox2.BackColor = colour;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!panel1.Visible)
            {
                panel1.Visible = true;
                button7.Text = "delete controls";
            }
            else
            {
                panel1.Visible = false;
                button7.Text = "return all controls";
            }
        }
    }
}
