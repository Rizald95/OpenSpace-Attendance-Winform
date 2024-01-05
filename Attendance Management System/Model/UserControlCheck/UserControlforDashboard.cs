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

namespace Attendance_Management_System.Model.UserControlCheck
{
    public partial class UserControlforDashboard : UserControl
    {
        SqlConnection sql1 = new SqlConnection(@"Data Source=DESKTOP-L0O7QKS\SQLEXPRESS;Initial Catalog=OpenSpace_StudyClub;Integrated Security=True");

        public UserControlforDashboard()
        {
            InitializeComponent();
        }

        public void Count()
        {
            //labeltotalClass.Text = Attendance.Attendance.Count("SELECT COUNT(*) FROM Class_Table;", sql).ToString();
            //labeltotalStudent.Text = Attendance.Attendance.Count("SELECT COUNT(*) FROM Student_Table;", sql).ToString();

        }

        private void UserControlforDashboard_Load(object sender, EventArgs e)
        {
            Count();
        }

        private void labeltotalClass_Click(object sender, EventArgs e)
        {

        }
    }


}
