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


namespace Attendance_Management_System.Model.UserControlCheck
{
    public partial class UserControlAddClass : UserControl
    {
        SqlConnection sql1 = new SqlConnection(@"Data Source=DESKTOP-L0O7QKS\SQLEXPRESS;Initial Catalog=OpenSpace_StudyClub;Integrated Security=True");
        public UserControlAddClass()
        {
            InitializeComponent();
        }

        private void tabPageaddClass_Click(object sender, EventArgs e)
        {

        }

        private void tabPageSearchClass_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxSeacrh_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxSeacrh, "Seacrh");
        }

        private void tabPageUpClass_Click(object sender, EventArgs e)
        {

        }
    }
}
