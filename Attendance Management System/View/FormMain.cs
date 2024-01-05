using Attendance_Management_System.Model.UserControlCheck;
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
        public string USERNAME = "", ROLE = "";
        public FormMain()
        {
            InitializeComponent();
            timerDateAndTime.Start();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            panelExpand.Hide();
            labelUsername.Text = USERNAME;
            labelRole.Text = ROLE;


            ///  if( ROLE = "User")
            //   {
            //     buttonDashboard.Hide();
            //     buttonSession.Hide();
            //    buttonRegister.Hide();
            //    buttonMember.Hide();
            // }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(" You wanna Quit?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                timerDateAndTime.Stop();
                Close();
                loginFormUserAdministrator formLogin = new loginFormUserAdministrator();
                formLogin.Show();
            }
            else
                panelExpand.Hide();



        }

        private void panelExpand_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            panelExpand.Hide();
            WindowState = FormWindowState.Minimized;
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = new DateTime();
            labelTime.Text = now.ToString("F");

        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void MoveSidePanel(Control button)
        {
            panelSideButton.Location = new Point(button.Location.X - button.Location.Y - 180);

        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonDashboard);
            userControlAddClass1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlforDashboard1.Count();
            userControlforDashboard1.Visible = true;
            userControlRegister1.Visible = false;
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAttendance);
            userControlAddClass1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlforDashboard1.Visible = false;
            userControlRegister1.Visible = false;
        }

        private void buttonSession_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonSession);
            userControlAddClass1.ClearTextBox();
            userControlAddClass1.Visible = true;
            userControlforDashboard1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlRegister1.Visible = false;
        }

        private void buttonMember_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonMember);
            userControlAddClass1.Visible = false;
            userControlforDashboard1.Visible = false;
            userControlAddStudent1.ClearTextBox();
            userControlAddStudent1.Visible = true;
            userControlRegister1.Visible = false;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonReport);
            userControlAddClass1.Visible = false;
            userControlforDashboard1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlRegister1.Visible = false;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonRegister);
            userControlAddClass1.Visible = false;
            userControlforDashboard1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlRegister1.Visible = true;
        }

        private void panelSideButton_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSideButton_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxExpand_Click(object sender, EventArgs e)
        {
            if (panelExpand.Visible)
            {
                panelExpand.Visible = false;
            }
            else
            {
                panelExpand.Visible = true;
            }
        }

        private void userControlDashboard2_Load(object sender, EventArgs e)
        {

        }

        private void userControlforDashboard1_Load(object sender, EventArgs e)
        {

        }

        private void userControlAddClass1_Load(object sender, EventArgs e)
        {

        }
    }
}
