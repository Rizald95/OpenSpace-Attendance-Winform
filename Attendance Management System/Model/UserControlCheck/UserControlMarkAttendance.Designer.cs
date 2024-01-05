namespace Attendance_Management_System.Model.UserControlCheck
{
    partial class UserControlMarkAttendance
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
            tabControlMarkAttendance = new TabControl();
            tabPageMarkAttendance = new TabPage();
            dataGridViewAttendance = new DataGridView();
            Student_IDTable = new DataGridViewTextBoxColumn();
            Student_NameTable = new DataGridViewTextBoxColumn();
            Student_TotalRegsiter = new DataGridViewTextBoxColumn();
            Student_classTable = new DataGridViewCheckBoxColumn();
            Student_GenderTable = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            comboBoxClass = new ComboBox();
            label1 = new Label();
            dateTimePickerDate = new DateTimePicker();
            panel1 = new Panel();
            labelDate = new Label();
            labelName = new Label();
            tabPage2 = new TabPage();
            tabControlMarkAttendance.SuspendLayout();
            tabPageMarkAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).BeginInit();
            SuspendLayout();
            // 
            // tabControlMarkAttendance
            // 
            tabControlMarkAttendance.Alignment = TabAlignment.Bottom;
            tabControlMarkAttendance.Anchor = AnchorStyles.None;
            tabControlMarkAttendance.Controls.Add(tabPageMarkAttendance);
            tabControlMarkAttendance.Controls.Add(tabPage2);
            tabControlMarkAttendance.Location = new Point(0, 0);
            tabControlMarkAttendance.Name = "tabControlMarkAttendance";
            tabControlMarkAttendance.SelectedIndex = 0;
            tabControlMarkAttendance.Size = new Size(942, 501);
            tabControlMarkAttendance.TabIndex = 0;
            // 
            // tabPageMarkAttendance
            // 
            tabPageMarkAttendance.Controls.Add(dataGridViewAttendance);
            tabPageMarkAttendance.Controls.Add(panel2);
            tabPageMarkAttendance.Controls.Add(comboBoxClass);
            tabPageMarkAttendance.Controls.Add(label1);
            tabPageMarkAttendance.Controls.Add(dateTimePickerDate);
            tabPageMarkAttendance.Controls.Add(panel1);
            tabPageMarkAttendance.Controls.Add(labelDate);
            tabPageMarkAttendance.Controls.Add(labelName);
            tabPageMarkAttendance.Location = new Point(4, 4);
            tabPageMarkAttendance.Name = "tabPageMarkAttendance";
            tabPageMarkAttendance.Padding = new Padding(3);
            tabPageMarkAttendance.Size = new Size(934, 468);
            tabPageMarkAttendance.TabIndex = 0;
            tabPageMarkAttendance.Text = "Mark Attendance";
            tabPageMarkAttendance.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAttendance
            // 
            dataGridViewAttendance.AllowUserToAddRows = false;
            dataGridViewAttendance.AllowUserToDeleteRows = false;
            dataGridViewAttendance.AllowUserToResizeColumns = false;
            dataGridViewAttendance.AllowUserToResizeRows = false;
            dataGridViewAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAttendance.BackgroundColor = Color.White;
            dataGridViewAttendance.BorderStyle = BorderStyle.None;
            dataGridViewAttendance.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttendance.Columns.AddRange(new DataGridViewColumn[] { Student_IDTable, Student_NameTable, Student_TotalRegsiter, Student_classTable, Student_GenderTable });
            dataGridViewAttendance.Location = new Point(6, 141);
            dataGridViewAttendance.Name = "dataGridViewAttendance";
            dataGridViewAttendance.ReadOnly = true;
            dataGridViewAttendance.RowHeadersWidth = 51;
            dataGridViewAttendance.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewAttendance.RowTemplate.Height = 29;
            dataGridViewAttendance.ScrollBars = ScrollBars.Vertical;
            dataGridViewAttendance.ShowCellErrors = false;
            dataGridViewAttendance.ShowEditingIcon = false;
            dataGridViewAttendance.ShowRowErrors = false;
            dataGridViewAttendance.Size = new Size(896, 287);
            dataGridViewAttendance.TabIndex = 12;
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
            Student_NameTable.HeaderText = "Student Name";
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
            Student_classTable.HeaderText = "Status";
            Student_classTable.MinimumWidth = 6;
            Student_classTable.Name = "Student_classTable";
            Student_classTable.ReadOnly = true;
            Student_classTable.Resizable = DataGridViewTriState.True;
            Student_classTable.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Student_GenderTable
            // 
            Student_GenderTable.DataPropertyName = "Column5";
            Student_GenderTable.HeaderText = "Status";
            Student_GenderTable.MinimumWidth = 6;
            Student_GenderTable.Name = "Student_GenderTable";
            Student_GenderTable.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Location = new Point(535, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(328, 3);
            panel2.TabIndex = 5;
            // 
            // comboBoxClass
            // 
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Location = new Point(539, 82);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(313, 28);
            comboBoxClass.TabIndex = 4;
            comboBoxClass.SelectedIndexChanged += comboBoxClass_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(535, 62);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 3;
            label1.Text = "Class";
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.CustomFormat = "dd/MM/yyyy";
            dateTimePickerDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerDate.Location = new Point(68, 85);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(303, 27);
            dateTimePickerDate.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(68, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 3);
            panel1.TabIndex = 2;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(68, 62);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(41, 20);
            labelDate.TabIndex = 1;
            labelDate.Text = "Date";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(23, 17);
            labelName.Name = "labelName";
            labelName.Size = new Size(122, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Mark Attendance";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(934, 468);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // UserControlMarkAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlMarkAttendance);
            Name = "UserControlMarkAttendance";
            Size = new Size(942, 501);
            tabControlMarkAttendance.ResumeLayout(false);
            tabPageMarkAttendance.ResumeLayout(false);
            tabPageMarkAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMarkAttendance;
        private TabPage tabPageMarkAttendance;
        private Label labelName;
        private TabPage tabPage2;
        private DateTimePicker dateTimePickerDate;
        private Panel panel1;
        private Label labelDate;
        private Panel panel2;
        private ComboBox comboBoxClass;
        private Label label1;
        private DataGridView dataGridViewAttendance;
        private DataGridViewTextBoxColumn Student_IDTable;
        private DataGridViewTextBoxColumn Student_NameTable;
        private DataGridViewTextBoxColumn Student_TotalRegsiter;
        private DataGridViewCheckBoxColumn Student_classTable;
        private DataGridViewTextBoxColumn Student_GenderTable;
    }
}
