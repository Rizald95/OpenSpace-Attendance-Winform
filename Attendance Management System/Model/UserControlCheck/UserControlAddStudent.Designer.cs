namespace Attendance_Management_System.Model.UserControlCheck
{
    partial class UserControlAddStudent
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlAddStudent));
            tabControlAddStudent = new TabControl();
            tabPageaddStudent = new TabPage();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            comboBoxClass = new ComboBox();
            buttonAdd = new Button();
            panel4 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            textBoxRegistrationNo = new TextBox();
            textBoxNameStudent = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPageSeacrhStudent = new TabPage();
            comboBoxSearch = new ComboBox();
            panel10 = new Panel();
            label6 = new Label();
            labelCountStudent = new Label();
            label8 = new Label();
            dataGridViewStudent = new DataGridView();
            textBoxSearch = new TextBox();
            pictureBoxSeacrh = new PictureBox();
            panel5 = new Panel();
            labelSearch = new Label();
            label7 = new Label();
            tabPageUpStudent = new TabPage();
            radioButtonFemaleUpdate = new RadioButton();
            radioButtonMaleUpdate = new RadioButton();
            comboBoxClassUpdate = new ComboBox();
            panel6 = new Panel();
            label9 = new Label();
            panel7 = new Panel();
            label10 = new Label();
            panel8 = new Panel();
            panel9 = new Panel();
            textBoxRegisterUpdate = new TextBox();
            textBoxNameUpdate = new TextBox();
            label11 = new Label();
            label12 = new Label();
            button1 = new Button();
            button2 = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            label14 = new Label();
            toolTip = new ToolTip(components);
            Student_IDTable = new DataGridViewTextBoxColumn();
            Student_NameTable = new DataGridViewTextBoxColumn();
            Student_TotalRegsiter = new DataGridViewTextBoxColumn();
            Student_classTable = new DataGridViewTextBoxColumn();
            Student_GenderTable = new DataGridViewTextBoxColumn();
            tabControlAddStudent.SuspendLayout();
            tabPageaddStudent.SuspendLayout();
            tabPageSeacrhStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSeacrh).BeginInit();
            tabPageUpStudent.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlAddStudent
            // 
            tabControlAddStudent.Alignment = TabAlignment.Bottom;
            tabControlAddStudent.Controls.Add(tabPageaddStudent);
            tabControlAddStudent.Controls.Add(tabPageSeacrhStudent);
            tabControlAddStudent.Controls.Add(tabPageUpStudent);
            tabControlAddStudent.Location = new Point(0, 3);
            tabControlAddStudent.Name = "tabControlAddStudent";
            tabControlAddStudent.SelectedIndex = 0;
            tabControlAddStudent.Size = new Size(942, 495);
            tabControlAddStudent.TabIndex = 1;
            // 
            // tabPageaddStudent
            // 
            tabPageaddStudent.Controls.Add(radioButtonFemale);
            tabPageaddStudent.Controls.Add(radioButtonMale);
            tabPageaddStudent.Controls.Add(comboBoxClass);
            tabPageaddStudent.Controls.Add(buttonAdd);
            tabPageaddStudent.Controls.Add(panel4);
            tabPageaddStudent.Controls.Add(label5);
            tabPageaddStudent.Controls.Add(panel3);
            tabPageaddStudent.Controls.Add(label4);
            tabPageaddStudent.Controls.Add(panel2);
            tabPageaddStudent.Controls.Add(panel1);
            tabPageaddStudent.Controls.Add(textBoxRegistrationNo);
            tabPageaddStudent.Controls.Add(textBoxNameStudent);
            tabPageaddStudent.Controls.Add(label3);
            tabPageaddStudent.Controls.Add(label2);
            tabPageaddStudent.Controls.Add(label1);
            tabPageaddStudent.Location = new Point(4, 4);
            tabPageaddStudent.Name = "tabPageaddStudent";
            tabPageaddStudent.Padding = new Padding(3);
            tabPageaddStudent.Size = new Size(934, 462);
            tabPageaddStudent.TabIndex = 0;
            tabPageaddStudent.Text = "Add Student";
            tabPageaddStudent.UseVisualStyleBackColor = true;
            tabPageaddStudent.Enter += tabPageaddStudent_Enter;
            tabPageaddStudent.Leave += tabPageaddStudent_Leave;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(640, 299);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(78, 24);
            radioButtonFemale.TabIndex = 16;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(640, 253);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(63, 24);
            radioButtonMale.TabIndex = 15;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // comboBoxClass
            // 
            comboBoxClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClass.FlatStyle = FlatStyle.Flat;
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Items.AddRange(new object[] { "-- Select --" });
            comboBoxClass.Location = new Point(102, 270);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(250, 28);
            comboBoxClass.TabIndex = 14;
            comboBoxClass.Click += comboBoxClass_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.IndianRed;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Location = new Point(105, 360);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.IndianRed;
            panel4.Location = new Point(507, 329);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 3);
            panel4.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(507, 253);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 10;
            label5.Text = "Gender : ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Location = new Point(105, 299);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 3);
            panel3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 253);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 7;
            label4.Text = "Male : ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Location = new Point(504, 178);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 3);
            panel2.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Location = new Point(105, 178);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 3);
            panel1.TabIndex = 5;
            // 
            // textBoxRegistrationNo
            // 
            textBoxRegistrationNo.BorderStyle = BorderStyle.None;
            textBoxRegistrationNo.Location = new Point(504, 152);
            textBoxRegistrationNo.Name = "textBoxRegistrationNo";
            textBoxRegistrationNo.Size = new Size(236, 20);
            textBoxRegistrationNo.TabIndex = 4;
            // 
            // textBoxNameStudent
            // 
            textBoxNameStudent.BorderStyle = BorderStyle.None;
            textBoxNameStudent.Location = new Point(105, 152);
            textBoxNameStudent.Name = "textBoxNameStudent";
            textBoxNameStudent.Size = new Size(236, 20);
            textBoxNameStudent.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(507, 132);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 2;
            label3.Text = "Register No : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 132);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Name : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 6);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Add Student";
            // 
            // tabPageSeacrhStudent
            // 
            tabPageSeacrhStudent.Controls.Add(comboBoxSearch);
            tabPageSeacrhStudent.Controls.Add(panel10);
            tabPageSeacrhStudent.Controls.Add(label6);
            tabPageSeacrhStudent.Controls.Add(labelCountStudent);
            tabPageSeacrhStudent.Controls.Add(label8);
            tabPageSeacrhStudent.Controls.Add(dataGridViewStudent);
            tabPageSeacrhStudent.Controls.Add(textBoxSearch);
            tabPageSeacrhStudent.Controls.Add(pictureBoxSeacrh);
            tabPageSeacrhStudent.Controls.Add(panel5);
            tabPageSeacrhStudent.Controls.Add(labelSearch);
            tabPageSeacrhStudent.Controls.Add(label7);
            tabPageSeacrhStudent.Location = new Point(4, 4);
            tabPageSeacrhStudent.Name = "tabPageSeacrhStudent";
            tabPageSeacrhStudent.Padding = new Padding(3);
            tabPageSeacrhStudent.Size = new Size(934, 462);
            tabPageSeacrhStudent.TabIndex = 1;
            tabPageSeacrhStudent.Text = "Seacrh Student";
            tabPageSeacrhStudent.UseVisualStyleBackColor = true;
            tabPageSeacrhStudent.Enter += tabPageSeacrhStudent_Enter;
            // 
            // comboBoxSearch
            // 
            comboBoxSearch.FormattingEnabled = true;
            comboBoxSearch.Items.AddRange(new object[] { "Name", "Register No", "Class" });
            comboBoxSearch.Location = new Point(608, 85);
            comboBoxSearch.Name = "comboBoxSearch";
            comboBoxSearch.Size = new Size(297, 28);
            comboBoxSearch.TabIndex = 17;
            comboBoxSearch.SelectedIndexChanged += comboBoxSearch_SelectedIndexChanged;
            // 
            // panel10
            // 
            panel10.BackColor = Color.IndianRed;
            panel10.Location = new Point(608, 114);
            panel10.Name = "panel10";
            panel10.Size = new Size(297, 3);
            panel10.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(608, 68);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 14;
            label6.Text = "Search by  : ";
            // 
            // labelCountStudent
            // 
            labelCountStudent.AutoSize = true;
            labelCountStudent.Location = new Point(742, 428);
            labelCountStudent.Name = "labelCountStudent";
            labelCountStudent.Size = new Size(26, 20);
            labelCountStudent.TabIndex = 13;
            labelCountStudent.Text = "{?}";
            labelCountStudent.Click += labelCountStudent_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(608, 428);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 12;
            label8.Text = "Total Class : ";
            // 
            // dataGridViewStudent
            // 
            dataGridViewStudent.AllowUserToAddRows = false;
            dataGridViewStudent.AllowUserToDeleteRows = false;
            dataGridViewStudent.AllowUserToResizeColumns = false;
            dataGridViewStudent.AllowUserToResizeRows = false;
            dataGridViewStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudent.BackgroundColor = Color.White;
            dataGridViewStudent.BorderStyle = BorderStyle.None;
            dataGridViewStudent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudent.Columns.AddRange(new DataGridViewColumn[] { Student_IDTable, Student_NameTable, Student_TotalRegsiter, Student_classTable, Student_GenderTable });
            dataGridViewStudent.Location = new Point(21, 130);
            dataGridViewStudent.Name = "dataGridViewStudent";
            dataGridViewStudent.ReadOnly = true;
            dataGridViewStudent.RowHeadersWidth = 51;
            dataGridViewStudent.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewStudent.RowTemplate.Height = 29;
            dataGridViewStudent.ShowCellErrors = false;
            dataGridViewStudent.ShowEditingIcon = false;
            dataGridViewStudent.ShowRowErrors = false;
            dataGridViewStudent.Size = new Size(896, 287);
            dataGridViewStudent.TabIndex = 11;
            dataGridViewStudent.CellClick += dataGridViewStudent_CellClick;
            dataGridViewStudent.CellContentClick += dataGridViewStudent_CellContentClick;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Location = new Point(129, 88);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(238, 20);
            textBoxSearch.TabIndex = 8;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // pictureBoxSeacrh
            // 
            pictureBoxSeacrh.Image = (Image)resources.GetObject("pictureBoxSeacrh.Image");
            pictureBoxSeacrh.Location = new Point(373, 75);
            pictureBoxSeacrh.Name = "pictureBoxSeacrh";
            pictureBoxSeacrh.Size = new Size(53, 33);
            pictureBoxSeacrh.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSeacrh.TabIndex = 10;
            pictureBoxSeacrh.TabStop = false;
            pictureBoxSeacrh.MouseHover += pictureBoxSeacrh_MouseHover;
            // 
            // panel5
            // 
            panel5.BackColor = Color.IndianRed;
            panel5.Location = new Point(129, 114);
            panel5.Name = "panel5";
            panel5.Size = new Size(297, 3);
            panel5.TabIndex = 9;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(132, 68);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(64, 20);
            labelSearch.TabIndex = 7;
            labelSearch.Text = "Search : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 6);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 6;
            label7.Text = "Search Student";
            // 
            // tabPageUpStudent
            // 
            tabPageUpStudent.Controls.Add(radioButtonFemaleUpdate);
            tabPageUpStudent.Controls.Add(radioButtonMaleUpdate);
            tabPageUpStudent.Controls.Add(comboBoxClassUpdate);
            tabPageUpStudent.Controls.Add(panel6);
            tabPageUpStudent.Controls.Add(label9);
            tabPageUpStudent.Controls.Add(panel7);
            tabPageUpStudent.Controls.Add(label10);
            tabPageUpStudent.Controls.Add(panel8);
            tabPageUpStudent.Controls.Add(panel9);
            tabPageUpStudent.Controls.Add(textBoxRegisterUpdate);
            tabPageUpStudent.Controls.Add(textBoxNameUpdate);
            tabPageUpStudent.Controls.Add(label11);
            tabPageUpStudent.Controls.Add(label12);
            tabPageUpStudent.Controls.Add(button1);
            tabPageUpStudent.Controls.Add(button2);
            tabPageUpStudent.Controls.Add(buttonDelete);
            tabPageUpStudent.Controls.Add(buttonUpdate);
            tabPageUpStudent.Controls.Add(label14);
            tabPageUpStudent.Location = new Point(4, 4);
            tabPageUpStudent.Name = "tabPageUpStudent";
            tabPageUpStudent.Padding = new Padding(3);
            tabPageUpStudent.Size = new Size(934, 462);
            tabPageUpStudent.TabIndex = 2;
            tabPageUpStudent.Text = "Update and Delete Student";
            tabPageUpStudent.UseVisualStyleBackColor = true;
            tabPageUpStudent.Leave += tabPageUpStudent_Leave;
            // 
            // radioButtonFemaleUpdate
            // 
            radioButtonFemaleUpdate.AutoSize = true;
            radioButtonFemaleUpdate.Location = new Point(612, 260);
            radioButtonFemaleUpdate.Name = "radioButtonFemaleUpdate";
            radioButtonFemaleUpdate.Size = new Size(78, 24);
            radioButtonFemaleUpdate.TabIndex = 43;
            radioButtonFemaleUpdate.TabStop = true;
            radioButtonFemaleUpdate.Text = "Female";
            radioButtonFemaleUpdate.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaleUpdate
            // 
            radioButtonMaleUpdate.AutoSize = true;
            radioButtonMaleUpdate.Location = new Point(612, 214);
            radioButtonMaleUpdate.Name = "radioButtonMaleUpdate";
            radioButtonMaleUpdate.Size = new Size(63, 24);
            radioButtonMaleUpdate.TabIndex = 42;
            radioButtonMaleUpdate.TabStop = true;
            radioButtonMaleUpdate.Text = "Male";
            radioButtonMaleUpdate.UseVisualStyleBackColor = true;
            // 
            // comboBoxClassUpdate
            // 
            comboBoxClassUpdate.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClassUpdate.FlatStyle = FlatStyle.Flat;
            comboBoxClassUpdate.FormattingEnabled = true;
            comboBoxClassUpdate.Items.AddRange(new object[] { "-- Select --" });
            comboBoxClassUpdate.Location = new Point(74, 231);
            comboBoxClassUpdate.Name = "comboBoxClassUpdate";
            comboBoxClassUpdate.Size = new Size(250, 28);
            comboBoxClassUpdate.TabIndex = 41;
            // 
            // panel6
            // 
            panel6.BackColor = Color.IndianRed;
            panel6.Location = new Point(479, 290);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 3);
            panel6.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(479, 214);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 39;
            label9.Text = "Gender : ";
            // 
            // panel7
            // 
            panel7.BackColor = Color.IndianRed;
            panel7.Location = new Point(77, 260);
            panel7.Name = "panel7";
            panel7.Size = new Size(250, 3);
            panel7.TabIndex = 38;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(80, 214);
            label10.Name = "label10";
            label10.Size = new Size(53, 20);
            label10.TabIndex = 0;
            label10.Text = "Male : ";
            // 
            // panel8
            // 
            panel8.BackColor = Color.IndianRed;
            panel8.Location = new Point(476, 139);
            panel8.Name = "panel8";
            panel8.Size = new Size(250, 3);
            panel8.TabIndex = 36;
            // 
            // panel9
            // 
            panel9.BackColor = Color.IndianRed;
            panel9.Location = new Point(77, 139);
            panel9.Name = "panel9";
            panel9.Size = new Size(250, 3);
            panel9.TabIndex = 35;
            // 
            // textBoxRegisterUpdate
            // 
            textBoxRegisterUpdate.BorderStyle = BorderStyle.None;
            textBoxRegisterUpdate.Location = new Point(476, 113);
            textBoxRegisterUpdate.Name = "textBoxRegisterUpdate";
            textBoxRegisterUpdate.Size = new Size(236, 20);
            textBoxRegisterUpdate.TabIndex = 34;
            // 
            // textBoxNameUpdate
            // 
            textBoxNameUpdate.BorderStyle = BorderStyle.None;
            textBoxNameUpdate.Location = new Point(77, 113);
            textBoxNameUpdate.Name = "textBoxNameUpdate";
            textBoxNameUpdate.Size = new Size(236, 20);
            textBoxNameUpdate.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(479, 93);
            label11.Name = "label11";
            label11.Size = new Size(98, 20);
            label11.TabIndex = 32;
            label11.Text = "Register No : ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(80, 93);
            label12.Name = "label12";
            label12.Size = new Size(60, 20);
            label12.TabIndex = 31;
            label12.Text = "Name : ";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(236, 376);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 30;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(80, 376);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 29;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.None;
            buttonDelete.BackColor = Color.Red;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Location = new Point(622, 541);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 28;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.None;
            buttonUpdate.BackColor = Color.FromArgb(128, 255, 128);
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Location = new Point(466, 541);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 27;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 6);
            label14.Name = "label14";
            label14.Size = new Size(190, 20);
            label14.TabIndex = 14;
            label14.Text = "Update and Delete Student";
            // 
            // Student_IDTable
            // 
            Student_IDTable.DataPropertyName = "Column1";
            Student_IDTable.HeaderText = "ID";
            Student_IDTable.MinimumWidth = 6;
            Student_IDTable.Name = "Student_IDTable";
            Student_IDTable.ReadOnly = true;
            // 
            // Student_NameTable
            // 
            Student_NameTable.DataPropertyName = "Student_Name";
            Student_NameTable.HeaderText = "Name";
            Student_NameTable.MinimumWidth = 6;
            Student_NameTable.Name = "Student_NameTable";
            Student_NameTable.ReadOnly = true;
            // 
            // Student_TotalRegsiter
            // 
            Student_TotalRegsiter.DataPropertyName = "Student_Total";
            Student_TotalRegsiter.HeaderText = "Register No";
            Student_TotalRegsiter.MinimumWidth = 6;
            Student_TotalRegsiter.Name = "Student_TotalRegsiter";
            Student_TotalRegsiter.ReadOnly = true;
            // 
            // Student_classTable
            // 
            Student_classTable.DataPropertyName = "Student_Male";
            Student_classTable.HeaderText = "Class";
            Student_classTable.MinimumWidth = 6;
            Student_classTable.Name = "Student_classTable";
            Student_classTable.ReadOnly = true;
            // 
            // Student_GenderTable
            // 
            Student_GenderTable.DataPropertyName = "Column5";
            Student_GenderTable.HeaderText = "Gender";
            Student_GenderTable.MinimumWidth = 6;
            Student_GenderTable.Name = "Student_GenderTable";
            Student_GenderTable.ReadOnly = true;
            // 
            // UserControlAddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlAddStudent);
            Name = "UserControlAddStudent";
            Size = new Size(942, 501);
            tabControlAddStudent.ResumeLayout(false);
            tabPageaddStudent.ResumeLayout(false);
            tabPageaddStudent.PerformLayout();
            tabPageSeacrhStudent.ResumeLayout(false);
            tabPageSeacrhStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSeacrh).EndInit();
            tabPageUpStudent.ResumeLayout(false);
            tabPageUpStudent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlAddStudent;
        private TabPage tabPageaddStudent;
        private Button buttonAdd;
        private Panel panel4;
        private TextBox textBoxFemale;
        private Label label5;
        private Panel panel3;
        private Label label4;
        private Panel panel2;
        private Panel panel1;
        private TextBox textBoxRegistrationNo;
        private TextBox textBoxNameStudent;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPageSeacrhStudent;
        private Label labelCountStudent;
        private Label label8;
        private DataGridView dataGridViewStudent;
        private TextBox textBoxSearch;
        private PictureBox pictureBoxSeacrh;
        private Panel panel5;
        private Label labelSearch;
        private Label label7;
        private TabPage tabPageUpStudent;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Label label14;
        private Button button1;
        private Button button2;
        private ComboBox comboBoxClass;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private Label label6;
        private Panel panel10;
        private ToolTip toolTip;
        private RadioButton radioButtonFemaleUpdate;
        private RadioButton radioButtonMaleUpdate;
        private ComboBox comboBoxClassUpdate;
        private Panel panel6;
        private Label label9;
        private Panel panel7;
        private Label label10;
        private Panel panel8;
        private Panel panel9;
        private TextBox textBoxRegisterUpdate;
        private TextBox textBoxNameUpdate;
        private Label label11;
        private Label label12;
        private ComboBox comboBoxSearch;
        private DataGridViewTextBoxColumn Student_IDTable;
        private DataGridViewTextBoxColumn Student_NameTable;
        private DataGridViewTextBoxColumn Student_TotalRegsiter;
        private DataGridViewTextBoxColumn Student_classTable;
        private DataGridViewTextBoxColumn Student_GenderTable;
    }
}
