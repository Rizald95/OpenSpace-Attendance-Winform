
namespace Attendance_Management_System.View
{
    partial class FormForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForgotPassword));
            CloseButton = new PictureBox();
            pictureBox1 = new PictureBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            VerifyEmailButton = new Button();
            alertButton = new PictureBox();
            panel1 = new Panel();
            toolTip1 = new ToolTip(components);
            buttonHome_Back = new Button();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alertButton).BeginInit();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButton.BackColor = Color.Transparent;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Image = (Image)resources.GetObject("CloseButton.Image");
            CloseButton.Location = new Point(528, 12);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(42, 30);
            CloseButton.SizeMode = PictureBoxSizeMode.Zoom;
            CloseButton.TabIndex = 2;
            CloseButton.TabStop = false;
            CloseButton.Click += CloseButton_Click;
            CloseButton.MouseHover += CloseButton_MouseHover;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(215, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(149, 216);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.ForeColor = Color.DarkGray;
            textBoxEmail.Location = new Point(149, 249);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(256, 27);
            textBoxEmail.TabIndex = 1;
            textBoxEmail.Text = "example_email@gmail.com";
            textBoxEmail.Enter += textBoxEmail_Enter;
            textBoxEmail.Leave += textBoxEmail_Leave;
            // 
            // VerifyEmailButton
            // 
            VerifyEmailButton.Cursor = Cursors.Hand;
            VerifyEmailButton.Location = new Point(162, 393);
            VerifyEmailButton.Name = "VerifyEmailButton";
            VerifyEmailButton.Size = new Size(260, 29);
            VerifyEmailButton.TabIndex = 11;
            VerifyEmailButton.Text = "Verify";
            VerifyEmailButton.UseVisualStyleBackColor = true;
            VerifyEmailButton.Click += VerifyEmailButton_Click;
            // 
            // alertButton
            // 
            alertButton.BackColor = Color.Transparent;
            alertButton.BorderStyle = BorderStyle.FixedSingle;
            alertButton.Cursor = Cursors.No;
            alertButton.Image = (Image)resources.GetObject("alertButton.Image");
            alertButton.Location = new Point(420, 249);
            alertButton.Name = "alertButton";
            alertButton.Size = new Size(28, 27);
            alertButton.SizeMode = PictureBoxSizeMode.Zoom;
            alertButton.TabIndex = 12;
            alertButton.TabStop = false;
            alertButton.Click += alertButton_Click;
            alertButton.MouseHover += alertButton_MouseHover;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Location = new Point(146, 290);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 5);
            panel1.TabIndex = 0;
            // 
            // buttonHome_Back
            // 
            buttonHome_Back.Location = new Point(195, 440);
            buttonHome_Back.Name = "buttonHome_Back";
            buttonHome_Back.Size = new Size(195, 29);
            buttonHome_Back.TabIndex = 13;
            buttonHome_Back.Text = "Back to Log In";
            buttonHome_Back.UseVisualStyleBackColor = true;
            buttonHome_Back.Click += buttonHome_Back_Click;
            // 
            // FormForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 506);
            Controls.Add(buttonHome_Back);
            Controls.Add(panel1);
            Controls.Add(alertButton);
            Controls.Add(VerifyEmailButton);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(pictureBox1);
            Controls.Add(CloseButton);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormForgotPassword";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormForgotPassword_Load;
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)alertButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox CloseButton;
        private PictureBox pictureBox1;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Button VerifyEmailButton;
        private PictureBox alertButton;
        private Panel panel1;
        private ToolTip toolTip1;
        private Button buttonHome_Back;
    }
}