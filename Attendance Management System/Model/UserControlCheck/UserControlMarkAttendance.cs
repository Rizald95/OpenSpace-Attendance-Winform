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
    public partial class UserControlMarkAttendance : UserControl
    {
        private SqlConnection connection;
        private string connectionString = @"Data Source=DESKTOP-L0O7QKS\SQLEXPRESS;Initial Catalog=OpenSpace_StudyClub;Integrated Security=True";

        private bool okay;

        public UserControlMarkAttendance()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            dataGridViewAttendance.Columns["Column1"].Visible = false;
            dataGridViewAttendance.Columns["Column5"].Visible = false;
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Attendance.Attendance.IsMarkAttendance(dateTimePickerDate.Text, comboBoxClass.SelectedItem.ToString(), connectionString))
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_Table.Student_ID, Student_Name, Student_Total, Attendance_Status FROM Student_Table INNER JOIN Attendance_Table ON Student_Table.Student_ID = Attendance_Table.Student_ID INNER JOIN Class_Table ON Class_Table.Class_ID = Student_Table.Class_ID WHERE Attendance_Date = '"+ dateTimePickerDate.Text + "' AND Class_Name = '" + comboBoxClass.SelectedItem.ToString() + "';",dataGridViewAttendance,connectionString );
                okay = true;
            }

        }
    }
}
