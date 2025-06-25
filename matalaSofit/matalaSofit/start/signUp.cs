
using System;
using System.Drawing;
using System.IO;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace matalaSofit
{
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
            panel2.Left = (this.ClientSize.Width - panel2.Width) / 2;
            error.Width = this.ClientSize.Width;
            signUpButt.Left = (this.ClientSize.Width - signUpButt.Width) / 2;
            back.Left = (this.ClientSize.Width - back.Width) - 20;


        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool isDefaultImage = true;
        private void picProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picProfile.Image = Image.FromFile(ofd.FileName);
                isDefaultImage = false;
            }
        }
        private void signUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private bool isFirstName = true;
        private bool isLastName = true;
        private bool isPassword = true;
        private bool isConfirmPassword = true;
        private bool isEmail = true;
        private bool isId = true;
        private bool isPhone = true;

        private void firstName_Enter(object sender, EventArgs e)
        {
            if (isFirstName)
            {
                firstName.Text = "";
                firstName.ForeColor = Color.Black;
                isFirstName = false;
            }
        }

        private void firstName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstName.Text))
            {
                firstName.Text = "first name";
                firstName.ForeColor = Color.Gray;
                isFirstName = true;
            }
        }

        private void lastName_Enter(object sender, EventArgs e)
        {
            if (isLastName)
            {
                lastName.Text = "";
                lastName.ForeColor = Color.Black;
                isLastName = false;
            }
        }

        private void lastName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lastName.Text))
            {
                lastName.Text = "last name";
                lastName.ForeColor = Color.Gray;
                isLastName = true;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (isPassword)
            {
                password.Text = "";
                password.ForeColor = Color.Black;
                password.UseSystemPasswordChar = true;
                isPassword = false;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(password.Text))
            {
                password.Text = "password";
                password.ForeColor = Color.Gray;
                password.UseSystemPasswordChar = false;
                isPassword = true;
            }
        }

        private void confirm_Enter(object sender, EventArgs e)
        {
            if (isConfirmPassword)
            {
                confirm.Text = "";
                confirm.ForeColor = Color.Black;
                confirm.UseSystemPasswordChar = true;
                isConfirmPassword = false;
            }
        }

        private void confirm_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(confirm.Text))
            {
                confirm.Text = "confirm password";
                confirm.ForeColor = Color.Gray;
                confirm.UseSystemPasswordChar = false;
                isConfirmPassword = true;
            }
        }

        private void email_Enter(object sender, EventArgs e)
        {
            if (isEmail)
            {
                email.Text = "";
                email.ForeColor = Color.Black;
                isEmail = false;
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email.Text))
            {
                email.Text = "email";
                email.ForeColor = Color.Gray;
                isEmail = true;
            }
        }

        private void id_Enter(object sender, EventArgs e)
        {
            if (isId)
            {
                id.Text = "";
                id.ForeColor = Color.Black;
                isId = false;
            }
        }

        private void id_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id.Text))
            {
                id.Text = "id";
                id.ForeColor = Color.Gray;
                isId = true;
            }
        }

        private void phoneNum_Enter(object sender, EventArgs e)
        {
            if (isPhone)
            {
                phoneNum.Text = "";
                phoneNum.ForeColor = Color.Black;
                isPhone = false;
            }
        }

        private void phoneNum_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(phoneNum.Text))
            {
                phoneNum.Text = "phone number";
                phoneNum.ForeColor = Color.Gray;
                isPhone = true;
            }
        }

        private void signUp_Resize(object sender, EventArgs e)
        {
            panel2.Left = (this.ClientSize.Width - panel2.Width) / 2;
            error.Width = this.ClientSize.Width;
            signUpButt.Left = (this.ClientSize.Width - signUpButt.Width) / 2;
            back.Left = (this.ClientSize.Width - back.Width) - 20;
        }





        private void signUpButt_Click(object sender, EventArgs e)
        {
            if (!isDefaultImage && !isEmail && !isPhone && !isPassword && !isFirstName && !isLastName && !isConfirmPassword && !isId)
            {
                if (password.Text.Equals(confirm.Text))
                {
                    if (Regex.IsMatch(firstName.Text, @"^[a-zA-Z\s]+$") && Regex.IsMatch(lastName.Text, @"^[a-zA-Z\s]+$") && Regex.IsMatch(email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") && Regex.IsMatch(id.Text, @"^\d{9}$") && Regex.IsMatch(phoneNum.Text, @"^05\d{8}$") && Regex.IsMatch(password.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$"))
                    {
                        bool isFound = false;
                        try
                        {
                            string[] lines = File.ReadAllLines("../../../Files/myfile.txt");
                            foreach (string line in lines)
                            {
                                string[] parts = line.Split(':');
                                if (parts[0].Equals(id.Text) || parts[1].Equals(password.Text))
                                {
                                    isFound = true;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            error.Visible = true;
                            error.Text = ex.ToString();
                        }


                        if (!isFound)
                        {
                            signInCus signIn = new signInCus("signup");
                            signIn.Show();
                            signIn.ClientSize = this.ClientSize;
                            this.Hide();
                        }
                        else
                        {
                            error.Visible = true;
                            error.Text = "such a password or an id number exists";
                        }

                    }
                    else
                    {
                        error.Visible = true;
                        error.Text = "password, email, id number or phone number are invalid";
                    }
                }
                else
                {

                    error.Visible = true;
                    error.Text = "passwords are not identical";
                }

            }
            else
            {
                error.Text = "all fields are required";
                error.Visible = true;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            loginPage loginPage = new loginPage();
            loginPage.ClientSize = this.ClientSize;
            loginPage.Show();
            this.Hide();
        }

        private void signUp_Load(object sender, EventArgs e)
        {
            birthDate.MaxDate = DateTime.Today.AddYears(-10);
            birthDate.Value = DateTime.Today.AddYears(-10); 
        }
    }
}
