using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Attendance_Management_System.View
{
    public partial class loginFormUserAdministrator : Form
    {

        SqlConnection sql1 = new SqlConnection(@"Data Source=DESKTOP-L0O7QKS\SQLEXPRESS;Initial Catalog=OpenSpace_StudyClub;Integrated Security=True");

       



        public loginFormUserAdministrator()
        {
            InitializeComponent();
        }

        private void loginFormUserAdministrator_Load(object sender, EventArgs e)
        {
            designEyeOpen.Hide();
            alertPicture.Hide();
            label1.Hide();


        }

        private void labelinput_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //close button
        private void pictureBox2_Click(object sender, EventArgs e)
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


        //minimize button
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox3, "Minimize Button");
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Close Button");
        }

        //end effect


        private void designEyeOpen_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(designEyeOpen, "Show Password");
        }

        private void designEyeClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(designEyeClose, "Hide Password");
        }

        private void designEyeOpen_Click(object sender, EventArgs e)
        {
            formPassword.UseSystemPasswordChar = false;
            designEyeOpen.Hide();
            designEyeClose.Show();
        }

        private void designEyeClose_Click(object sender, EventArgs e)
        {
            formPassword.UseSystemPasswordChar = true;
            designEyeOpen.Show();
            designEyeClose.Hide();
        }

        private void formPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void alertPicture_Click(object sender, EventArgs e)
        {

        }

        //button login
        private void button_login_Click(object sender, EventArgs e)
        {
            string username, user_password;
            username = textBox1.Text;
            user_password = formPassword.Text;

            try
            {
                string query = "SELECT * FROM TabelUser_1 WHERE Name = '" + textBox1.Text + "' AND Password = '" + formPassword.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql1);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = textBox1.Text;
                    user_password = formPassword.Text;

                    FormMain formMain = new FormMain();
                    formMain.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid Login Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    formPassword.Clear();

                    textBox1.Focus();
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                sql1.Close();
            }

            if (textBox1.Text.Trim() != string.Empty && formPassword.Text.Trim() != string.Empty)
            {
                FormMain formMain = new FormMain();
                formMain.USERNAME = textBox1.Text;

            }

          



            //Contoh

          ///  if (textBox1.Text.Trim() != string.Empty && formPassword.Text.Trim() != string.Empty)
           //  {
             //Menggunakan variabel constr sebagai string koneksi
            //string checkpassword = Attendance.Attendance.IsValidNamePass(textBox1.Text.Trim(), formPassword.Text.Trim(), constr);

            //if (checkpassword != "")
            //{
            //FormMain formMain = new FormMain();
            //textBox1.Clear();
            //formPassword.Clear();
            //designEyeClose_Click(sender, e);
            //textBox1.Focus();
            //  label1.Hide();
            //    alertPicture.Hide();
            //      formMain.ShowDialog();
            //}
            //else
            //{
            //  textBox1.Show();
            //alertPicture.Show();
            //}
            //}
        }



        //username
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        //Password
        private void formPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void formPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button_login.PerformClick();
                e.Handled = true;
            }
        }

        //forgot password
        private void label2_Click(object sender, EventArgs e)
        {
            FormForgotPassword formForgotPassword = new FormForgotPassword();
            formForgotPassword.ShowDialog();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            formPassword.Clear();

            textBox1.Focus();
        }
    }
}
