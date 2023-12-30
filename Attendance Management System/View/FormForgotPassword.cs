using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System.View
{
    public partial class FormForgotPassword : Form
    {
        public FormForgotPassword()
        {
            InitializeComponent();
        }

        SqlConnection sql1 = new SqlConnection(@"Data Source=DESKTOP-L0O7QKS\SQLEXPRESS;Initial Catalog=OpenSpace_StudyClub;Integrated Security=True");
        private string sql = @"Data Source=DESKTOP-L0O7QKS\SQLEXPRESS;Initial Catalog=OpenSpace_StudyClub;Integrated Security=True";


        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want Exit ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
        private void CloseButton_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(CloseButton, "Close");
        }


        private void alertButton_Click(object sender, EventArgs e)
        {

        }

        private void alertButton_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(alertButton, "InvalidEmail!");
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Trim() == "example_email@gmail.com")
            {
                textBoxEmail.Clear();
                textBoxEmail.ForeColor = Color.Black;
            }

            if (!IsValidEmail(textBoxEmail.Text.Trim()) || textBoxEmail.Text.Trim() == "example_email@gmail.com")
                alertButton.Show();
            else
                alertButton.Hide();
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Trim() == string.Empty)
            {
                textBoxEmail.Text = "example_email@gmail.com";
                textBoxEmail.ForeColor = Color.DarkGray;
            }

            if (!IsValidEmail(textBoxEmail.Text) || textBoxEmail.Text == "example_email@gmail.com")
                alertButton.Show();
            else
                alertButton.Hide();
        }

        private void VerifyEmailButton_Click(object sender, EventArgs e)
        {
            if (IsValidEmailCheck(textBoxEmail.Text.Trim()))
            {
                string connectionString = @"Data Source=DESKTOP-L0O7QKS\SQLEXPRESS;Initial Catalog=OpenSpace_StudyClub;Integrated Security=True"; // Ganti dengan string koneksi database Anda

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT Name, Password FROM TabelUser_1 WHERE Email = @Email";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Email", textBoxEmail.Text.Trim());

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string userName = reader["Name"].ToString();
                                string password = reader["Password"].ToString();

                                MessageBox.Show($"Your Username is {userName} and Password is {password}.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Email not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private bool IsValidEmailCheck(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void FormForgotPassword_Load(object sender, EventArgs e)
        {
            alertButton.Hide();
        }

        private void buttonHome_Back_Click(object sender, EventArgs e)
        {
            // Menutup form saat kembali ke formLogin
            this.Close(); // atau formForgotPassword.Close();

            loginFormUserAdministrator formLogin = new loginFormUserAdministrator();
            formLogin.Show();
        }
    }
}
