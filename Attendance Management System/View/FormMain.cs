using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System.View
{
    public partial class FormMain : Form
    {
        public string USERNAME, ROLE;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Close(); // atau formForgotPassword.Close();

            loginFormUserAdministrator formLogin = new loginFormUserAdministrator();
            formLogin.Show();
        }
    }
}
