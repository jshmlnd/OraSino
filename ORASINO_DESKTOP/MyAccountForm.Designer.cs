namespace ORASINO_DESKTOP
{
    partial class MyAccountForm
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
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            OldPassword = new TextBox();
            label4 = new Label();
            Password_1 = new TextBox();
            Password_2 = new TextBox();
            label5 = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 36, 36);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 85);
            panel1.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(24, 26);
            button1.Name = "button1";
            button1.Size = new Size(55, 32);
            button1.TabIndex = 5;
            button1.Text = "MENU";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(121, 25);
            label1.Name = "label1";
            label1.Size = new Size(152, 32);
            label1.TabIndex = 4;
            label1.Text = "My Account";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.University_of_Santo_Tomas___Legazpi;
            pictureBox1.Location = new Point(333, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.White;
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.DisabledLinkColor = Color.White;
            linkLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            linkLabel1.ForeColor = SystemColors.ControlText;
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(133, 440);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(114, 19);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Logout Account";
            linkLabel1.VisitedLinkColor = Color.White;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(124, 138);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 10;
            label2.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(120, 158);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 23);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(124, 199);
            label3.Name = "label3";
            label3.Size = new Size(92, 17);
            label3.TabIndex = 12;
            label3.Text = "Old Password";
            // 
            // OldPassword
            // 
            OldPassword.Cursor = Cursors.IBeam;
            OldPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OldPassword.Location = new Point(120, 219);
            OldPassword.Name = "OldPassword";
            OldPassword.Size = new Size(135, 23);
            OldPassword.TabIndex = 13;
            OldPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(124, 261);
            label4.Name = "label4";
            label4.Size = new Size(97, 17);
            label4.TabIndex = 14;
            label4.Text = "New Password";
            // 
            // Password_1
            // 
            Password_1.Cursor = Cursors.IBeam;
            Password_1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password_1.Location = new Point(120, 281);
            Password_1.Name = "Password_1";
            Password_1.Size = new Size(135, 23);
            Password_1.TabIndex = 15;
            Password_1.UseSystemPasswordChar = true;
            // 
            // Password_2
            // 
            Password_2.Cursor = Cursors.IBeam;
            Password_2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password_2.Location = new Point(120, 343);
            Password_2.Name = "Password_2";
            Password_2.Size = new Size(135, 23);
            Password_2.TabIndex = 17;
            Password_2.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(124, 323);
            label5.Name = "label5";
            label5.Size = new Size(97, 17);
            label5.TabIndex = 16;
            label5.Text = "New Password";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(36, 36, 36);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(140, 397);
            button2.Name = "button2";
            button2.Size = new Size(92, 23);
            button2.TabIndex = 18;
            button2.Text = "Save Changes";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // MyAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 186, 0);
            ClientSize = new Size(398, 697);
            Controls.Add(button2);
            Controls.Add(Password_2);
            Controls.Add(label5);
            Controls.Add(Password_1);
            Controls.Add(label4);
            Controls.Add(OldPassword);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MyAccountForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Account";
            Load += MyAccountForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox OldPassword;
        private Label label4;
        private TextBox Password_1;
        private TextBox Password_2;
        private Label label5;
        private Button button2;
    }
}