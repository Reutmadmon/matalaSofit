
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace matalaSofit
{
    partial class signUp
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button signUpButt;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            signUpButt = new Button();
            error = new Label();
            pictureBox1 = new PictureBox();
            back = new Button();
            panel2 = new Panel();
            picProfile = new PictureBox();
            firstName = new TextBox();
            lastName = new TextBox();
            birthDateLa = new Label();
            password = new TextBox();
            birthDate = new DateTimePicker();
            confirm = new TextBox();
            phoneNum = new TextBox();
            email = new TextBox();
            id = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            SuspendLayout();
            // 
            // signUpButt
            // 
            signUpButt.BackColor = Color.FromArgb(64, 73, 110);
            signUpButt.FlatAppearance.BorderSize = 0;
            signUpButt.FlatStyle = FlatStyle.Flat;
            signUpButt.ForeColor = SystemColors.ButtonFace;
            signUpButt.Location = new Point(314, 560);
            signUpButt.Name = "signUpButt";
            signUpButt.Size = new Size(100, 30);
            signUpButt.TabIndex = 2;
            signUpButt.Text = "register";
            signUpButt.UseVisualStyleBackColor = false;
            signUpButt.Click += signUpButt_Click;
            // 
            // error
            // 
            error.Dock = DockStyle.Bottom;
            error.ForeColor = Color.Red;
            error.ImageAlign = ContentAlignment.TopCenter;
            error.Location = new Point(0, 671);
            error.Margin = new Padding(3);
            error.Name = "error";
            error.Size = new Size(809, 15);
            error.TabIndex = 19;
            error.Text = "error";
            error.TextAlign = ContentAlignment.MiddleCenter;
            error.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_Jun_17__2025__04_00_06_PM;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(64, 73, 110);
            back.FlatAppearance.BorderSize = 0;
            back.FlatStyle = FlatStyle.Flat;
            back.ForeColor = SystemColors.ButtonFace;
            back.Location = new Point(730, 12);
            back.Name = "back";
            back.Size = new Size(50, 21);
            back.TabIndex = 23;
            back.Text = "Back ➧";
            back.TextAlign = ContentAlignment.MiddleLeft;
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(picProfile);
            panel2.Controls.Add(firstName);
            panel2.Controls.Add(lastName);
            panel2.Controls.Add(birthDateLa);
            panel2.Controls.Add(password);
            panel2.Controls.Add(birthDate);
            panel2.Controls.Add(confirm);
            panel2.Controls.Add(phoneNum);
            panel2.Controls.Add(email);
            panel2.Controls.Add(id);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(209, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(417, 488);
            panel2.TabIndex = 21;
            // 
            // picProfile
            // 
            picProfile.Cursor = Cursors.Hand;
            picProfile.Image = Properties.Resources.defaultImage;
            picProfile.Location = new Point(258, 128);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(122, 123);
            picProfile.SizeMode = PictureBoxSizeMode.Zoom;
            picProfile.TabIndex = 0;
            picProfile.TabStop = false;
            picProfile.Click += picProfile_Click;
            // 
            // firstName
            // 
            firstName.ForeColor = Color.Gray;
            firstName.Location = new Point(40, 128);
            firstName.Name = "firstName";
            firstName.Size = new Size(166, 23);
            firstName.TabIndex = 5;
            firstName.Text = "first name";
            firstName.Enter += firstName_Enter;
            firstName.Leave += firstName_Leave;
            // 
            // lastName
            // 
            lastName.ForeColor = Color.Gray;
            lastName.Location = new Point(40, 168);
            lastName.Name = "lastName";
            lastName.Size = new Size(166, 23);
            lastName.TabIndex = 6;
            lastName.Text = "last name";
            lastName.Enter += lastName_Enter;
            lastName.Leave += lastName_Leave;
            // 
            // birthDateLa
            // 
            birthDateLa.AutoSize = true;
            birthDateLa.Location = new Point(37, 424);
            birthDateLa.Name = "birthDateLa";
            birthDateLa.Size = new Size(58, 15);
            birthDateLa.TabIndex = 18;
            birthDateLa.Text = "birth date";
            // 
            // password
            // 
            password.ForeColor = Color.Gray;
            password.Location = new Point(40, 211);
            password.Name = "password";
            password.Size = new Size(166, 23);
            password.TabIndex = 7;
            password.Text = "password";
            password.Enter += password_Enter;
            password.Leave += password_Leave;
            // 
            // birthDate
            // 
            birthDate.Location = new Point(34, 445);
            birthDate.MaxDate = new DateTime(2015, 6, 11, 0, 0, 0, 0);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(177, 23);
            birthDate.TabIndex = 17;
            birthDate.Value = new DateTime(2015, 6, 11, 0, 0, 0, 0);
            // 
            // confirm
            // 
            confirm.ForeColor = Color.Gray;
            confirm.Location = new Point(40, 255);
            confirm.Name = "confirm";
            confirm.Size = new Size(166, 23);
            confirm.TabIndex = 8;
            confirm.Text = "confirm password";
            confirm.Enter += confirm_Enter;
            confirm.Leave += confirm_Leave;
            // 
            // phoneNum
            // 
            phoneNum.ForeColor = Color.Gray;
            phoneNum.Location = new Point(40, 381);
            phoneNum.Name = "phoneNum";
            phoneNum.Size = new Size(166, 23);
            phoneNum.TabIndex = 12;
            phoneNum.Text = "phone number";
            phoneNum.Enter += phoneNum_Enter;
            phoneNum.Leave += phoneNum_Leave;
            // 
            // email
            // 
            email.ForeColor = Color.Gray;
            email.Location = new Point(40, 298);
            email.Name = "email";
            email.Size = new Size(166, 23);
            email.TabIndex = 9;
            email.Text = "email";
            email.Enter += email_Enter;
            email.Leave += email_Leave;
            // 
            // id
            // 
            id.ForeColor = Color.Gray;
            id.Location = new Point(40, 341);
            id.Name = "id";
            id.Size = new Size(166, 23);
            id.TabIndex = 11;
            id.Text = "id";
            id.Enter += id_Enter;
            id.Leave += id_Leave;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(101, 27);
            label1.Name = "label1";
            label1.Size = new Size(207, 85);
            label1.TabIndex = 10;
            label1.Text = "sign up";
            // 
            // signUp
            // 
            AutoScroll = true;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(809, 686);
            Controls.Add(panel2);
            Controls.Add(back);
            Controls.Add(pictureBox1);
            Controls.Add(error);
            Controls.Add(signUpButt);
            Font = new Font("Segoe UI", 9F);
            Name = "signUp";
            RightToLeft = RightToLeft.No;
            Text = "sign up";
            FormClosing += signUp_FormClosing;
            Load += signUp_Load;
            Resize += signUp_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            ResumeLayout(false);
        }
        private Label error;
        private PictureBox pictureBox1;
        private Button back;
        private Panel panel2;
        private PictureBox picProfile;
        private TextBox firstName;
        private TextBox lastName;
        private Label birthDateLa;
        private TextBox password;
        private DateTimePicker birthDate;
        private TextBox confirm;
        private TextBox phoneNum;
        private TextBox email;
        private TextBox id;
        private Label label1;
    }
}
