using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
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
        private string CID = "";
        public UserControlAddClass()
        {
            InitializeComponent();
        }

        private void IntegerType(KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        public void ClearTextBox()
        {
            textBoxName.Clear();
            textBoxTotal.Clear();
            textBoxFemale.Clear();
            textBoxMale.Clear();
            tabControlAddClass.SelectedTab = tabPageaddClass;
        }

        private void ClearTextBoxUpdate()
        {
            textBoxNameUpdate.Clear();
            textBoxTotalUpdate.Clear();
            textBoxFemaleUpdate.Clear();
            textBoxMaleUpdate.Clear();
            CID = "";
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Trim() == string.Empty || textBoxTotal.Text.Trim() == string.Empty
                || textBoxMale.Text.Trim() == string.Empty || textBoxFemale.Text.Trim() == string.Empty)
            {
                MessageBox.Show("First fill out all fields", "Required all fileds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //memakai logika
                //
                //bool check = Attendance.Attendance.AddClass(textBoxName.Text.Trim(), textBoxTotal.Text.Trim(), textBoxMale.Text.Trim(), textBoxFemale.Text.Trim(), sql);
                //if (check)
                //  ClearTextBox();
            }
        }

        private void tabPageUpClass_Leave(object sender, EventArgs e)
        {
            ClearTextBoxUpdate();
        }

        private void tabPageSeacrhClass_Leave(object sender, EventArgs e)
        {

        }

        private void tabPageSeacrhClass_Enter(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            //fungsi menampilkan display data
            //("SELECT * FROM Class_Tab;e", dataGridViewClass, sql);
            //dataGridViewClass.Columns[0].Visible = false;
            //labelCount.Text = dataGridViewClass.Rows.Count.ToString();
        }

        private void tabPageaddClass_Enter(object sender, EventArgs e)
        {
            ClearTextBoxUpdate();
        }

        private void tabPageaddClass_Leave(object sender, EventArgs e)
        {

        }

        private void textBoxTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void textBoxMale_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void textBoxMaleUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxFemaleUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFemaleUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void textBoxTotalUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM Class_Table WHERE Class_Name LIKE '%" + textBoxSearch.Text + "%' ", dataGridViewClass, sql);


        }

        private void dataGridViewClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewClass.Rows[e.RowIndex];
                CID = row.Cells[0].Value.ToString();
                textBoxNameUpdate.Text = row.Cells[1].Value.ToString();
                textBoxTotalUpdate.Text = row.Cells[2].Value.ToString();
                textBoxMaleUpdate.Text = row.Cells[3].Value.ToString();
                textBoxFemaleUpdate.Text = row.Cells[4].Value.ToString();

            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (CID != "")
            {
                if (textBoxNameUpdate.Text.Trim() == string.Empty || textBoxTotalUpdate.Text.Trim() == string.Empty
                || textBoxMaleUpdate.Text.Trim() == string.Empty || textBoxFemaleUpdate.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("First fill out all fields", "Required all fileds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //memakai logika
                    //
                    //bool check = Attendance.Attendance.UpdateClass(CID ,textBoxNameUpdate.Text.Trim(), textBoxTotalUpdate.Text.Trim(), textBoxMaleUpdate.Text.Trim(), textBoxFemaleUpdate.Text.Trim(), sql);
                    //if (check)
                    //  ClearTextBoxUpdate();
                }
            }
            else
            {
                MessageBox.Show("First select row from table", "Select row", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (CID != "")
            {
                if (textBoxNameUpdate.Text.Trim() == string.Empty || textBoxTotalUpdate.Text.Trim() == string.Empty
                || textBoxMaleUpdate.Text.Trim() == string.Empty || textBoxFemaleUpdate.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("First fill out all fields", "Required all fileds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are u want to delete this class", "Delete Class", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
    }
}
