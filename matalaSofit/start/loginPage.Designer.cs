namespace matalaSofit
{
    partial class loginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            emplo = new Button();
            register = new LinkLabel();
            cust = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(22, 24);
            label1.Name = "label1";
            label1.Size = new Size(189, 85);
            label1.TabIndex = 0;
            label1.Text = "sign in";
            // 
            // emplo
            // 
            emplo.BackColor = Color.FromArgb(64, 73, 110);
            emplo.FlatStyle = FlatStyle.Flat;
            emplo.FlatAppearance.BorderSize = 0;
            emplo.Font = new Font("Segoe UI", 20F);
            emplo.ForeColor = Color.White;
            emplo.Location = new Point(22, 204);
            emplo.Name = "emplo";
            emplo.Size = new Size(183, 73);
            emplo.TabIndex = 2;
            emplo.Text = "employee";
            emplo.UseVisualStyleBackColor = false;
            emplo.Click += emplo_Click;
            // 
            // register
            // 
            register.AutoSize = true;
            register.Location = new Point(34, 302);
            register.Name = "register";
            register.Size = new Size(157, 15);
            register.TabIndex = 3;
            register.TabStop = true;
            register.Text = "not registered yet? click here";
            register.LinkClicked += linkLabel1_LinkClicked;
            // 
            // cust
            // 
            cust.BackColor = Color.FromArgb(64, 73, 110);
            cust.FlatStyle = FlatStyle.Flat;
            cust.FlatAppearance.BorderSize = 0;
            cust.Font = new Font("Segoe UI", 20F);
            cust.ForeColor = Color.White;
            cust.Location = new Point(22, 125);
            cust.Name = "cust";
            cust.Size = new Size(183, 73);
            cust.TabIndex = 4;
            cust.Text = "customer";
            cust.UseVisualStyleBackColor = false;
            cust.Click += cust_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_Jun_17__2025__04_00_06_PM;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // menuPanel
            // 
            panel1.Controls.Add(cust);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(emplo);
            panel1.Controls.Add(register);
            panel1.Location = new Point(324, 82);
            panel1.Name = "menuPanel";
            panel1.Size = new Size(218, 365);
            panel1.TabIndex = 18;
            panel1.Paint += panel1_Paint;
            // 
            // loginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(802, 450);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "loginPage";
            Text = "the best library";
            FormClosing += loginPage_FormClosing;
            Load += loginPage_Load;
            Resize += loginPage_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button emplo;
        private LinkLabel register;
        private Button cust;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}
