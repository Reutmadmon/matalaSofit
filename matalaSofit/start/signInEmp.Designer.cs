namespace matalaSofit.start
{
    partial class signInEmp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            id = new TextBox();
            logIn = new Button();
            password = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            back = new Button();
            isNotFL = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(isNotFL);
            panel1.Controls.Add(id);
            panel1.Controls.Add(logIn);
            panel1.Controls.Add(password);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 154);
            panel1.TabIndex = 14;
            // 
            // id
            // 
            id.ForeColor = Color.Gray;
            id.Location = new Point(18, 26);
            id.Name = "id";
            id.Size = new Size(166, 23);
            id.TabIndex = 12;
            id.Text = "id";
            id.Enter += id_Enter;
            id.Leave += id_Leave;
            // 
            // logIn
            // 
            logIn.BackColor = Color.FromArgb(64, 73, 110);
            logIn.FlatAppearance.BorderSize = 0;
            logIn.FlatStyle = FlatStyle.Flat;
            logIn.ForeColor = SystemColors.ButtonFace;
            logIn.Location = new Point(67, 121);
            logIn.Name = "logIn";
            logIn.Size = new Size(75, 23);
            logIn.TabIndex = 13;
            logIn.Text = "logIn";
            logIn.UseVisualStyleBackColor = false;
            logIn.Click += logIn_Click;
            // 
            // password
            // 
            password.ForeColor = Color.Gray;
            password.Location = new Point(18, 69);
            password.Name = "password";
            password.Size = new Size(166, 23);
            password.TabIndex = 8;
            password.Text = "password";
            password.Enter += password_Enter;
            password.Leave += password_Leave;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(253, 44);
            label1.Name = "label1";
            label1.Size = new Size(141, 74);
            label1.TabIndex = 18;
            label1.Text = "log in\n employee";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(64, 73, 110);
            back.FlatAppearance.BorderSize = 0;
            back.FlatStyle = FlatStyle.Flat;
            back.ForeColor = SystemColors.ButtonFace;
            back.Location = new Point(738, 12);
            back.Name = "back";
            back.Size = new Size(50, 21);
            back.TabIndex = 19;
            back.Text = "Back ➧";
            back.TextAlign = ContentAlignment.MiddleLeft;
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // isNotFL
            // 
            isNotFL.AutoSize = true;
            isNotFL.ForeColor = Color.Red;
            isNotFL.Location = new Point(14, 100);
            isNotFL.Name = "isNotFL";
            isNotFL.Size = new Size(172, 15);
            isNotFL.TabIndex = 15;
            isNotFL.Text = "The password or ID is incorrect.";
            isNotFL.Visible = false;
            // 
            // signInEmp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(back);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "signInEmp";
            Text = "signInEmp";
            FormClosing += signIn_FormClosing;
            Load += signInEmp_Load;
            Resize += signIn_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox id;
        private Button logIn;
        private TextBox password;
        private PictureBox pictureBox1;
        private Label label1;
        private Button back;
        private Label isNotFL;
    }
}