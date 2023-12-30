namespace Attendance_Management_System.View
{
    partial class loginFormUserAdministrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginFormUserAdministrator));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            groupBox1 = new GroupBox();
            formPassword = new TextBox();
            label2 = new Label();
            label1 = new Label();
            alertPicture = new PictureBox();
            designEyeOpen = new PictureBox();
            designEyeClose = new PictureBox();
            labelpassword = new Label();
            button_login = new Button();
            textBox1 = new TextBox();
            labelinput = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            toolTip1 = new ToolTip(components);
            ClearButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)alertPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)designEyeOpen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)designEyeClose).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(768, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1153, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseHover += pictureBox2_MouseHover;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1100, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            pictureBox3.MouseHover += pictureBox3_MouseHover;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(ClearButton);
            groupBox1.Controls.Add(formPassword);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(alertPicture);
            groupBox1.Controls.Add(designEyeOpen);
            groupBox1.Controls.Add(designEyeClose);
            groupBox1.Controls.Add(labelpassword);
            groupBox1.Controls.Add(button_login);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(labelinput);
            groupBox1.Location = new Point(90, 201);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 466);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Please a Login First";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // formPassword
            // 
            formPassword.Location = new Point(93, 168);
            formPassword.Name = "formPassword";
            formPassword.Size = new Size(256, 27);
            formPassword.TabIndex = 4;
            formPassword.TextChanged += formPassword_TextChanged;
            formPassword.KeyPress += formPassword_KeyPress;
            formPassword.KeyUp += formPassword_KeyUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 300);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 9;
            label2.Text = "Forgot Password?";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 248);
            label1.Name = "label1";
            label1.Size = new Size(206, 20);
            label1.TabIndex = 8;
            label1.Text = "Invalid Username or Password";
            label1.Click += label1_Click;
            // 
            // alertPicture
            // 
            alertPicture.BackColor = Color.Transparent;
            alertPicture.BorderStyle = BorderStyle.FixedSingle;
            alertPicture.Cursor = Cursors.No;
            alertPicture.Image = (Image)resources.GetObject("alertPicture.Image");
            alertPicture.Location = new Point(89, 241);
            alertPicture.Name = "alertPicture";
            alertPicture.Size = new Size(28, 27);
            alertPicture.SizeMode = PictureBoxSizeMode.Zoom;
            alertPicture.TabIndex = 7;
            alertPicture.TabStop = false;
            alertPicture.Click += alertPicture_Click;
            // 
            // designEyeOpen
            // 
            designEyeOpen.BackColor = Color.Transparent;
            designEyeOpen.BorderStyle = BorderStyle.FixedSingle;
            designEyeOpen.Cursor = Cursors.Hand;
            designEyeOpen.Image = (Image)resources.GetObject("designEyeOpen.Image");
            designEyeOpen.Location = new Point(399, 168);
            designEyeOpen.Name = "designEyeOpen";
            designEyeOpen.Size = new Size(28, 27);
            designEyeOpen.SizeMode = PictureBoxSizeMode.Zoom;
            designEyeOpen.TabIndex = 6;
            designEyeOpen.TabStop = false;
            designEyeOpen.Visible = false;
            designEyeOpen.Click += designEyeOpen_Click;
            designEyeOpen.MouseHover += designEyeOpen_MouseHover;
            // 
            // designEyeClose
            // 
            designEyeClose.BackColor = Color.Transparent;
            designEyeClose.BorderStyle = BorderStyle.FixedSingle;
            designEyeClose.Cursor = Cursors.Hand;
            designEyeClose.Image = (Image)resources.GetObject("designEyeClose.Image");
            designEyeClose.Location = new Point(355, 168);
            designEyeClose.Name = "designEyeClose";
            designEyeClose.Size = new Size(28, 27);
            designEyeClose.SizeMode = PictureBoxSizeMode.Zoom;
            designEyeClose.TabIndex = 5;
            designEyeClose.TabStop = false;
            designEyeClose.Click += designEyeClose_Click;
            designEyeClose.MouseHover += designEyeClose_MouseHover;
            // 
            // labelpassword
            // 
            labelpassword.AutoSize = true;
            labelpassword.Location = new Point(192, 130);
            labelpassword.Name = "labelpassword";
            labelpassword.Size = new Size(70, 20);
            labelpassword.TabIndex = 3;
            labelpassword.Text = "Password";
            // 
            // button_login
            // 
            button_login.Cursor = Cursors.Hand;
            button_login.Location = new Point(93, 365);
            button_login.Name = "button_login";
            button_login.Size = new Size(260, 29);
            button_login.TabIndex = 2;
            button_login.Text = "Log In";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox1.KeyUp += textBox1_KeyUp;
            // 
            // labelinput
            // 
            labelinput.AutoSize = true;
            labelinput.Location = new Point(192, 49);
            labelinput.Name = "labelinput";
            labelinput.Size = new Size(75, 20);
            labelinput.TabIndex = 0;
            labelinput.Text = "Username";
            labelinput.Click += labelinput_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.Control;
            panel1.Location = new Point(609, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 478);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(785, 225);
            label3.Name = "label3";
            label3.Size = new Size(169, 20);
            label3.TabIndex = 9;
            label3.Text = "OpenSpace Study Club's";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(761, 270);
            label4.Name = "label4";
            label4.Size = new Size(228, 20);
            label4.TabIndex = 10;
            label4.Text = "Attendance Management System";
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(173, 417);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(94, 29);
            ClearButton.TabIndex = 10;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // loginFormUserAdministrator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(1207, 708);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "loginFormUserAdministrator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += loginFormUserAdministrator_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)alertPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)designEyeOpen).EndInit();
            ((System.ComponentModel.ISupportInitialize)designEyeClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private GroupBox groupBox1;
        private Button button_login;
        private TextBox textBox1;
        private Label labelinput;
        private Label labelpassword;
        private PictureBox designEyeClose;
        private TextBox formPassword;
        private PictureBox designEyeOpen;
        private PictureBox alertPicture;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private ToolTip toolTip1;
        private Button ClearButton;
    }
}