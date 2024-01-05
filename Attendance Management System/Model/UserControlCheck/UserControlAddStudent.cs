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
    public partial class UserControlAddStudent : UserControl
    {
        SqlConnection sql1 = new SqlConnection(@"Data Source=DESKTOP-L0O7QKS\SQLEXPRESS;Initial Catalog=OpenSpace_StudyClub;Integrated Security=True");
        private string SID = "", gender = "";

        public UserControlAddStudent()
        {
            InitializeComponent();
        }

        private void dataGridViewStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void ClearTextBox()
        {
            textBoxNameStudent.Clear();
            textBoxRegistrationNo.Clear();
            comboBoxClass.SelectedIndex = -1;
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            tabControlAddStudent.SelectedTab = tabPageaddStudent;
        }

        private void ClearTextBoxUpdate()
        {
            textBoxNameUpdate.Clear();
            textBoxRegisterUpdate.Clear();
            comboBoxClassUpdate.SelectedIndex = -1;
            radioButtonFemaleUpdate.Checked = false;
            radioButtonMaleUpdate.Checked = false;


            SID = "";
        }

        private void pictureBoxSeacrh_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxSeacrh, "Search");
        }

        private void tabPageSeacrhStudent_Enter(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            comboBoxSearch.SelectedIndex = -1;
            //connect database and get data
            //Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_ID, Student_Name, Student_Reg, Student_Gender, Class_Name FROM Student_Table INNER JOIN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID;", dataGridViewStudent);
            //dataGridViewStudent.Columns[0].Visible = false;
            //labelCountStudent.Text = dataGridViewStudent.Rows.Count.ToString();
        }

        private void tabPageaddStudent_Enter(object sender, EventArgs e)
        {
            ClearTextBoxUpdate();
        }

        private void tabPageaddStudent_Leave(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void tabPageUpStudent_Leave(object sender, EventArgs e)
        {
            ClearTextBoxUpdate();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (radioButtonMale.Checked)
                gender = "Male";
            if (radioButtonFemale.Checked)
                gender = "Female";

            if (textBoxNameStudent.Text.Trim() == string.Empty || textBoxRegistrationNo.Text.Trim() == string.Empty || comboBoxClass.SelectedIndex == -1)
            {
                MessageBox.Show("First fill out all fields", "Required all fileds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (radioButtonMale.Checked == false && radioButtonFemale.Checked == false)
            {
                MessageBox.Show("First fill out all fields", "Required all fileds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // bool check = Attendance.Attendance.AddStudent(textBoxName.Text.Trim(), textBoxRegistrationNo.Text.Trim(), comboBoxClass.SelectedItem.ToString(), gender, sql);
                // if (check)
                //ClearTextBox()
                //

            }
        }

        private void comboBoxClass_Click(object sender, EventArgs e)
        {
            comboBoxClass.Items.Clear();
            //check resource in attendance res
            //Attendance.Attendance.FillComboBox("SELECT DISTINCT(Class_Name) FROM Class_Table", comboBocClass, sql);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxSearch.SelectedIndex == 0)
            {
                //Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_ID, Student_Name, Student_Reg, Student_Gender, Class_Name FROM Student_Table INNER JOIN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID  WHERE Student_Name LIKE '%" + textBoxSearch.Text.Trim() + "%' ;", dataGridViewStudent, sql);
            }
            else if (comboBoxSearch.SelectedIndex == 1)
            {
                //Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_ID, Student_Name, Student_Reg, Student_Gender, Class_Name FROM Student_Table INNER JOIN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID  WHERE Student_Reg LIKE '%" + textBoxSearch.Text.Trim() + "%' ;", dataGridViewStudent, sql);
            }
            else if (comboBoxSearch.SelectedIndex == 2)
            {
                //Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_ID, Student_Name, Student_Reg, Student_Gender, Class_Name FROM Student_Table INNER JOIN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID  WHERE Class_Name LIKE '%" + textBoxSearch.Text.Trim() + "%' ;", dataGridViewStudent, sql);
            }
        }

        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewStudent.Rows[e.RowIndex];
                SID = row.Cells["Column1"].Value.ToString();
                textBoxNameUpdate.Text = row.Cells["Column2"].Value.ToString();
                textBoxRegisterUpdate.Text = row.Cells["Column3"].Value.ToString();
                //Attendancr.Attendance.FillComboBox("SELECT DISTINCT (Class_Name) FROM Class_Table;", comboBoxClassUpdate, sql);
                comboBoxClassUpdate.SelectedItem = row.Cells["Column4"].Value.ToString();
                if (row.Cells["Column5"].Value.ToString() == "Male")
                    radioButtonMaleUpdate.Checked = true;
                if (row.Cells["Column5"].Value.ToString() == "Female")
                    radioButtonFemaleUpdate.Checked = true;

            }
        }



        //button Update update
        private void button2_Click(object sender, EventArgs e)
        {
            if (SID != "")
            {
                string gender = "";
                if (radioButtonMaleUpdate.Checked)
                    gender = "Male";
                if (radioButtonFemaleUpdate.Checked)
                    gender = "Female";

                if (textBoxNameUpdate.Text.Trim() == string.Empty || textBoxRegisterUpdate.Text.Trim() == string.Empty || comboBoxClassUpdate.SelectedIndex == -1)
                {
                    MessageBox.Show("First fill out all fields", "Required all fileds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (radioButtonMaleUpdate.Checked == false && radioButtonFemaleUpdate.Checked == false)
                {
                    MessageBox.Show("First fill out all fields", "Required all fileds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    // bool check = Attendance.Attendance.UpdateStudent(textBoxName.Text.Trim(), textBoxRegistrationNo.Text.Trim(), comboBoxClass.SelectedItem.ToString(), gender, sql);
                    // if (check)
                    //ClearTextBox()
                    //

                }
            }
            else
            {
                MessageBox.Show("First select row from table", "Select row", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        //button deleteUpdate
        private void button1_Click(object sender, EventArgs e)
        {
            if (SID != "")
            {
                string gender = "";
                if (radioButtonMaleUpdate.Checked)
                    gender = "Male";
                if (radioButtonFemaleUpdate.Checked)
                    gender = "Female";

                if (textBoxNameUpdate.Text.Trim() == string.Empty || textBoxRegisterUpdate.Text.Trim() == string.Empty || comboBoxClassUpdate.SelectedIndex == -1)
                {
                    MessageBox.Show("First fill out all fields", "Required all fileds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (radioButtonMaleUpdate.Checked == false && radioButtonFemaleUpdate.Checked == false)
                {
                    MessageBox.Show("First fill out all fields", "Required all fileds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are u want to delete this Student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // bool check = Attendance.Attendance.DeleteClass(CID, sql);
                        //if(check)
                        //ClearTextBoxUpdate();
                    }

                }
            }
            else
            {
                MessageBox.Show("First select row from table", "Select row", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void labelCountStudent_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
