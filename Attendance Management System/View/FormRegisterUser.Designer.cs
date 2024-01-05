namespace Attendance_Management_System.View
{
    partial class FormRegisterUser
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterUser));
            pictureBox1 = new PictureBox();
            pictureBoxCloseButton = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            textBox2 = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            textBoxEmail = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            textBoxPassword = new TextBox();
            label5 = new Label();
            panel5 = new Panel();
            textBoxAddress = new TextBox();
            label6 = new Label();
            panel6 = new Panel();
            textBoxCNIC = new TextBox();
            label7 = new Label();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            label17 = new Label();
            panel7 = new Panel();
            buttonRegisterUser = new Button();
            toolTip1 = new ToolTip(components);
            buttonOutLogin = new Button();
            label8 = new Label();
            radioButtonAdmin = new RadioButton();
            radioButtonUser = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCloseButton).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(325, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxCloseButton
            // 
            pictureBoxCloseButton.Image = (Image)resources.GetObject("pictureBoxCloseButton.Image");
            pictureBoxCloseButton.Location = new Point(710, 12);
            pictureBoxCloseButton.Name = "pictureBoxCloseButton";
            pictureBoxCloseButton.Size = new Size(32, 35);
            pictureBoxCloseButton.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCloseButton.TabIndex = 1;
            pictureBoxCloseButton.TabStop = false;
            pictureBoxCloseButton.Click += pictureBoxCloseButton_Click;
            pictureBoxCloseButton.MouseHover += pictureBoxCloseButton_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 170);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 2;
            label1.Text = "Register User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 208);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(81, 245);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 20);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(81, 271);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 3);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Location = new Point(81, 384);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 3);
            panel2.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaption;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(81, 364);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 20);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 321);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 6;
            label3.Text = "Phone Number";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.Location = new Point(81, 498);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 3);
            panel3.TabIndex = 11;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = SystemColors.ActiveCaption;
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Location = new Point(81, 472);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(250, 20);
            textBoxEmail.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 435);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Red;
            panel4.Location = new Point(444, 271);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 3);
            panel4.TabIndex = 14;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = SystemColors.ActiveCaption;
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Location = new Point(444, 245);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(250, 20);
            textBoxPassword.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(444, 208);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 12;
            label5.Text = "Password";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Red;
            panel5.Location = new Point(81, 605);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 3);
            panel5.TabIndex = 17;
            // 
            // textBoxAddress
            // 
            textBoxAddress.BackColor = SystemColors.ActiveCaption;
            textBoxAddress.BorderStyle = BorderStyle.None;
            textBoxAddress.Location = new Point(81, 579);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(250, 20);
            textBoxAddress.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(81, 542);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 15;
            label6.Text = "Address";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Red;
            panel6.Location = new Point(444, 384);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 3);
            panel6.TabIndex = 20;
            // 
            // textBoxCNIC
            // 
            textBoxCNIC.BackColor = SystemColors.ActiveCaption;
            textBoxCNIC.BorderStyle = BorderStyle.None;
            textBoxCNIC.Location = new Point(444, 358);
            textBoxCNIC.Name = "textBoxCNIC";
            textBoxCNIC.Size = new Size(250, 20);
            textBoxCNIC.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(444, 321);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 18;
            label7.Text = "CNIC";
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(631, 447);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(78, 24);
            radioButtonFemale.TabIndex = 47;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(531, 447);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(63, 24);
            radioButtonMale.TabIndex = 46;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(444, 449);
            label17.Name = "label17";
            label17.Size = new Size(68, 20);
            label17.TabIndex = 45;
            label17.Text = "Gender : ";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Red;
            panel7.Location = new Point(444, 498);
            panel7.Name = "panel7";
            panel7.Size = new Size(250, 3);
            panel7.TabIndex = 52;
            // 
            // buttonRegisterUser
            // 
            buttonRegisterUser.BackColor = Color.Firebrick;
            buttonRegisterUser.FlatAppearance.BorderSize = 0;
            buttonRegisterUser.FlatStyle = FlatStyle.Flat;
            buttonRegisterUser.Location = new Point(333, 704);
            buttonRegisterUser.Name = "buttonRegisterUser";
            buttonRegisterUser.Size = new Size(94, 29);
            buttonRegisterUser.TabIndex = 0;
            buttonRegisterUser.Text = "Register";
            buttonRegisterUser.UseVisualStyleBackColor = false;
            buttonRegisterUser.Click += buttonRegisterUser_Click;
            // 
            // buttonOutLogin
            // 
            buttonOutLogin.BackColor = Color.Brown;
            buttonOutLogin.FlatAppearance.BorderSize = 0;
            buttonOutLogin.FlatStyle = FlatStyle.Flat;
            buttonOutLogin.Location = new Point(333, 763);
            buttonOutLogin.Name = "buttonOutLogin";
            buttonOutLogin.Size = new Size(94, 29);
            buttonOutLogin.TabIndex = 0;
            buttonOutLogin.Text = "Form Login";
            buttonOutLogin.UseVisualStyleBackColor = false;
            buttonOutLogin.Click += buttonOutLogin_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(444, 542);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 53;
            label8.Text = "Role : ";
            // 
            // radioButtonAdmin
            // 
            radioButtonAdmin.AutoSize = true;
            radioButtonAdmin.Location = new Point(528, 546);
            radioButtonAdmin.Name = "radioButtonAdmin";
            radioButtonAdmin.Size = new Size(74, 24);
            radioButtonAdmin.TabIndex = 54;
            radioButtonAdmin.TabStop = true;
            radioButtonAdmin.Text = "Admin";
            radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // radioButtonUser
            // 
            radioButtonUser.AutoSize = true;
            radioButtonUser.Location = new Point(528, 584);
            radioButtonUser.Name = "radioButtonUser";
            radioButtonUser.Size = new Size(59, 24);
            radioButtonUser.TabIndex = 55;
            radioButtonUser.TabStop = true;
            radioButtonUser.Text = "User";
            radioButtonUser.UseVisualStyleBackColor = true;
            // 
            // FormRegisterUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(754, 817);
            Controls.Add(radioButtonUser);
            Controls.Add(radioButtonAdmin);
            Controls.Add(label8);
            Controls.Add(buttonOutLogin);
            Controls.Add(buttonRegisterUser);
            Controls.Add(panel7);
            Controls.Add(radioButtonFemale);
            Controls.Add(radioButtonMale);
            Controls.Add(label17);
            Controls.Add(panel6);
            Controls.Add(textBoxCNIC);
            Controls.Add(label7);
            Controls.Add(panel5);
            Controls.Add(textBoxAddress);
            Controls.Add(label6);
            Controls.Add(panel4);
            Controls.Add(textBoxPassword);
            Controls.Add(label5);
            Controls.Add(panel3);
            Controls.Add(textBoxEmail);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBoxCloseButton);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegisterUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegisterUser";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCloseButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBoxCloseButton;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox2;
        private Label label3;
        private Panel panel3;
        private TextBox textBoxEmail;
        private Label label4;
        private Panel panel4;
        private TextBox textBoxPassword;
        private Label label5;
        private Panel panel5;
        private TextBox textBoxAddress;
        private Label label6;
        private Panel panel6;
        private TextBox textBoxCNIC;
        private Label label7;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private Label label17;
        private Panel panel7;
        private Button buttonRegisterUser;
        private ToolTip toolTip1;
        private Button buttonOutLogin;
        private Label label8;
        private RadioButton radioButtonAdmin;
        private RadioButton radioButtonUser;
    }
}