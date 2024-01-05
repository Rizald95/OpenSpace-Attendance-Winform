using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Attendance_Management_System.View
{
    public partial class FormRegisterUser : Form
    {
        private SqlConnection connection;
        private string connectionString = @"Data Source=DESKTOP-L0O7QKS\SQLEXPRESS;Initial Catalog=OpenSpace_StudyClub;Integrated Security=True";
        public FormRegisterUser()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxCloseButton_Click(object sender, EventArgs e)
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

        private void pictureBoxCloseButton_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxCloseButton, "Close");
        }

        private void buttonOutLogin_Click(object sender, EventArgs e)
        {
            // Menutup form saat kembali ke formLogin
            this.Close(); // atau formForgotPassword.Close();

            loginFormUserAdministrator formLogin = new loginFormUserAdministrator();
            formLogin.Show();
        }

        private void buttonRegisterUser_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Gantilah dengan nilai yang benar dari properti-properti yang sesuai
                string query = "INSERT INTO TabelUser_1 (Name, Password, Phone, CNIC, DOB, Gender, Email, Role, User_Add) " +
                               "VALUES (@Name, @Password, @Phone, @CNIC, @DOB, @Gender, @Email, @Role, @User_Add)";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Password", textBoxPassword.Text);
                cmd.Parameters.AddWithValue("@Phone", textBox2.Text);
                cmd.Parameters.AddWithValue("@CNIC", textBoxCNIC.Text);
                // Jika Anda memiliki TextBox untuk DOB, sesuaikan di sini
                cmd.Parameters.AddWithValue("@DOB", "01/01/2000"); // Contoh, sesuaikan dengan nilai yang benar
                cmd.Parameters.AddWithValue("@Gender", radioButtonMale.Checked ? "Male" : "Female");
                cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                // Jika Anda memiliki ComboBox atau TextBox untuk Role, sesuaikan di sini
                cmd.Parameters.AddWithValue("@Role", radioButtonUser.Checked ? "User" : "Admin"); // Contoh, sesuaikan dengan nilai yang benar
                cmd.Parameters.AddWithValue("@User_Add", textBoxAddress.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }

}
