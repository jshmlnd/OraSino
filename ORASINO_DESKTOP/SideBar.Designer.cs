namespace ORASINO_DESKTOP
{
    partial class SideBar
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
            MyScheduleButton = new Button();
            MyClassesButton = new Button();
            MyGradesButton = new Button();
            MyAccountButton = new Button();
            SuspendLayout();
            // 
            // MyScheduleButton
            // 
            MyScheduleButton.Cursor = Cursors.Hand;
            MyScheduleButton.Location = new Point(12, 12);
            MyScheduleButton.Name = "MyScheduleButton";
            MyScheduleButton.Size = new Size(231, 23);
            MyScheduleButton.TabIndex = 0;
            MyScheduleButton.Text = "My Schedule";
            MyScheduleButton.UseVisualStyleBackColor = true;
            MyScheduleButton.Click += MyScheduleButton_Click;
            // 
            // MyClassesButton
            // 
            MyClassesButton.Cursor = Cursors.Hand;
            MyClassesButton.Location = new Point(12, 41);
            MyClassesButton.Name = "MyClassesButton";
            MyClassesButton.Size = new Size(231, 23);
            MyClassesButton.TabIndex = 1;
            MyClassesButton.Text = "My Classes";
            MyClassesButton.UseVisualStyleBackColor = true;
            MyClassesButton.Click += MyClassesButton_Click;
            // 
            // MyGradesButton
            // 
            MyGradesButton.Cursor = Cursors.Hand;
            MyGradesButton.Location = new Point(12, 70);
            MyGradesButton.Name = "MyGradesButton";
            MyGradesButton.Size = new Size(231, 23);
            MyGradesButton.TabIndex = 2;
            MyGradesButton.Text = "My Grades";
            MyGradesButton.UseVisualStyleBackColor = true;
            MyGradesButton.Click += MyGradesButton_Click;
            // 
            // MyAccountButton
            // 
            MyAccountButton.Cursor = Cursors.Hand;
            MyAccountButton.Location = new Point(12, 99);
            MyAccountButton.Name = "MyAccountButton";
            MyAccountButton.Size = new Size(231, 23);
            MyAccountButton.TabIndex = 3;
            MyAccountButton.Text = "My Account";
            MyAccountButton.UseVisualStyleBackColor = true;
            MyAccountButton.Click += MyAccountButton_Click;
            // 
            // SideBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 134);
            ControlBox = false;
            Controls.Add(MyAccountButton);
            Controls.Add(MyGradesButton);
            Controls.Add(MyClassesButton);
            Controls.Add(MyScheduleButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SideBar";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SideBar";
            Load += SideBar_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button MyScheduleButton;
        private Button MyClassesButton;
        private Button MyGradesButton;
        private Button MyAccountButton;
    }
}