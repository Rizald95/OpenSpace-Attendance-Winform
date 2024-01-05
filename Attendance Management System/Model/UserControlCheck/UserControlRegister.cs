using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Attendance_Management_System.Model.UserControlCheck
{
    public partial class UserControlRegister : UserControl
    {
        SqlConnection sql1 = new SqlConnection(@"Data Source=DESKTOP-L0O7QKS\SQLEXPRESS;Initial Catalog=OpenSpace_StudyClub;Integrated Security=True");
        private string RID = "";

        private string GenderforVariable = "", RoleforVariable, ID = "";

        public UserControlRegister()
        {
            InitializeComponent();
        }

        private void tabPageaddClass_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void tabPageSeacrhClass_Click(object sender, EventArgs e)
        {

        }

        private void tabPageUpUser_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxCNICUpdate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        public void HideErrorPicture()
        {
            pictureBoxErrorEmail.Visible = false;
            pictureBoxErrorCNIC.Visible = false;
            pictureBoxErrorDOB.Visible = false;
            pictureBoxErrorPhoneNo.Visible = false;
        }

        public void HideErrorPictureUpdate()
        {
            pictureBoxPhoneNoUpdate.Visible = false;
            pictureBoxCNICUpdate.Visible = false;
            pictureBoxEmailUpdate.Visible = false;
            pictureBoxDOBUpdate.Visible = false;

        }

        public void ClearTextBox()
        {
            textBoxNameUser.Clear();
            textBoxPassword.Clear();
            maskedTextBoxPhone.Text = "+ 00 000 000000";
            maskedTextBoxPhone.ForeColor = Color.DarkGray;
            maskedTextBoxCNC.Text = "00000-000000-0";
            maskedTextBoxCNC.ForeColor = Color.DarkGray;
            maskedTextBoxDateOfBirth.Text = "00/00/0000";
            maskedTextBoxDateOfBirth.ForeColor = Color.DarkGray;
            radioButtonMale.Checked = false;

            radioButtonFemale.Checked = false;
            textBoxEmail.Text = "Example@gmail.com";
            textBoxEmail.ForeColor = Color.DarkGray;

            checkBoxAdmin.Checked = false;
            checkBoxUser.Checked = false;
            textBoxAddressUser.Clear();
            tabControlAddUser.SelectedTab = tabPageaddUser;

        }

        public void ClearTextBoxUpdate()
        {
            textBoxNameUserUpdate.Clear();
            textBoxPasswordUpdate.Clear();
            maskedTextBoxPhoneNoUpdate.Text = "+ 00 000 000000";
            maskedTextBoxPhoneNoUpdate.ForeColor = Color.DarkGray;
            maskedTextBoxCNICUpdate.Text = "00000-000000-0";
            maskedTextBoxCNICUpdate.ForeColor = Color.DarkGray;
            maskedTextBoxDOBUpdate.Text = "00/00/0000";
            maskedTextBoxDOBUpdate.ForeColor = Color.DarkGray;
            textBoxUserEmailUpdate.Text = "Example@gmail.com";
            textBoxUserEmailUpdate.ForeColor = Color.DarkGray;
            textBoxAddressUpdate.Clear();
            radioButtonMaleUpdate.Checked = false;
            radioButtonFemale.Checked = false;
            checkBoxUserUpdate.Checked = false;
            checkBoxAdminUpdate.Checked = false;

            ID = "";
        }

        private void Mask(MaskedTextBox txtBox)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                txtBox.Select(0, 0);
            });
        }

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

        private bool IsValidDate(string date)
        {
            DateTime d;
            bool chValidty;
            try
            {
                return chValidty = DateTime.TryParseExact(date, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out d);

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void pictureBoxSeacrhUser_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxSeacrhUser, "Search");
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Example@gmail.com")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "Example@gmail.com";
                textBoxEmail.ForeColor = Color.DarkGray;
            }
        }
    }
}
