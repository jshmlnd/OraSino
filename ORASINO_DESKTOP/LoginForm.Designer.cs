
namespace ORASINO_DESKTOP
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PasswordBox = new TextBox();
            LoginButton = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            PictureBox2 = new PictureBox();
            ForgotPassword = new LinkLabel();
            StudentIDBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            SuspendLayout();
            // 
            // PasswordBox
            // 
            PasswordBox.AccessibleName = "";
            PasswordBox.Cursor = Cursors.IBeam;
            PasswordBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordBox.ForeColor = Color.Black;
            PasswordBox.Location = new Point(104, 399);
            PasswordBox.MaxLength = 10;
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PlaceholderText = "Password";
            PasswordBox.Size = new Size(200, 23);
            PasswordBox.TabIndex = 1;
            PasswordBox.UseSystemPasswordChar = true;
            PasswordBox.KeyPress += PasswordBox_KeyPress;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(36, 36, 36);
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = SystemColors.GradientInactiveCaption;
            LoginButton.Location = new Point(150, 463);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(99, 22);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "LOGIN";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.University_of_Santo_Tomas___Legazpi;
            pictureBox1.Location = new Point(173, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 36, 36);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 82);
            panel1.TabIndex = 4;
            // 
            // PictureBox2
            // 
            PictureBox2.BackColor = Color.Transparent;
            PictureBox2.Image = Properties.Resources.ORAS1;
            PictureBox2.Location = new Point(0, 88);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(401, 246);
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox2.TabIndex = 7;
            PictureBox2.TabStop = false;
            // 
            // ForgotPassword
            // 
            ForgotPassword.AutoSize = true;
            ForgotPassword.Cursor = Cursors.Hand;
            ForgotPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForgotPassword.LinkBehavior = LinkBehavior.NeverUnderline;
            ForgotPassword.LinkColor = Color.White;
            ForgotPassword.Location = new Point(141, 504);
            ForgotPassword.Name = "ForgotPassword";
            ForgotPassword.Size = new Size(127, 20);
            ForgotPassword.TabIndex = 8;
            ForgotPassword.TabStop = true;
            ForgotPassword.Text = "Forgot Password";
            ForgotPassword.VisitedLinkColor = Color.White;
            ForgotPassword.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // StudentIDBox
            // 
            StudentIDBox.AccessibleName = "";
            StudentIDBox.Cursor = Cursors.IBeam;
            StudentIDBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentIDBox.ForeColor = Color.Black;
            StudentIDBox.Location = new Point(104, 352);
            StudentIDBox.MaxLength = 10;
            StudentIDBox.Name = "StudentIDBox";
            StudentIDBox.PlaceholderText = "Student ID";
            StudentIDBox.Size = new Size(200, 23);
            StudentIDBox.TabIndex = 9;
            StudentIDBox.KeyPress += StudentID_KeyPress;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 186, 0);
            ClientSize = new Size(398, 697);
            Controls.Add(StudentIDBox);
            Controls.Add(ForgotPassword);
            Controls.Add(LoginButton);
            Controls.Add(PasswordBox);
            Controls.Add(panel1);
            Controls.Add(PictureBox2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private TextBox PasswordBox;
        private Button LoginButton;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox PictureBox2;
        private LinkLabel ForgotPassword;
        private TextBox StudentIDBox;
    }
}
