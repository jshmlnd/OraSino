namespace ORASINO_DESKTOP
{
    partial class MyScheduleForm
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
            MenuButton = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 36, 36);
            panel1.Controls.Add(MenuButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 85);
            panel1.TabIndex = 5;
            // 
            // MenuButton
            // 
            MenuButton.BackColor = Color.Transparent;
            MenuButton.FlatAppearance.BorderSize = 0;
            MenuButton.FlatStyle = FlatStyle.Flat;
            MenuButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            MenuButton.Location = new Point(24, 26);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(55, 32);
            MenuButton.TabIndex = 5;
            MenuButton.Text = "MENU";
            MenuButton.UseVisualStyleBackColor = false;
            MenuButton.Click += MenuButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(118, 25);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 4;
            label1.Text = "My Schedule";
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
            // MyScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 186, 0);
            ClientSize = new Size(398, 697);
            Controls.Add(panel1);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MyScheduleForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Schedule";
            Load += MyScheduleForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        //private Button button1;
        private LinkLabel linkLabel1;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button MenuButton;
    }
}