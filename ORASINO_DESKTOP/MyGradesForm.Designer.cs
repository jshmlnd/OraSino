﻿namespace ORASINO_DESKTOP
{
    partial class MyGradesForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Prelim = new DataGridViewTextBoxColumn();
            Midterm = new DataGridViewTextBoxColumn();
            Final = new DataGridViewTextBoxColumn();
            SubjectCode = new DataGridViewTextBoxColumn();
            Subject = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(132, 25);
            label1.Name = "label1";
            label1.Size = new Size(136, 32);
            label1.TabIndex = 4;
            label1.Text = "My Grades";
            label1.Click += label1_Click;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 36, 36);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 85);
            panel1.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
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
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Prelim, Midterm, Final, SubjectCode, Subject });
            dataGridView1.Location = new Point(39, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(321, 579);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Prelim
            // 
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Prelim.DefaultCellStyle = dataGridViewCellStyle1;
            Prelim.HeaderText = "Prelim";
            Prelim.Name = "Prelim";
            Prelim.Width = 50;
            // 
            // Midterm
            // 
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Midterm.DefaultCellStyle = dataGridViewCellStyle2;
            Midterm.HeaderText = "Midterm";
            Midterm.Name = "Midterm";
            Midterm.Width = 60;
            // 
            // Final
            // 
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Final.DefaultCellStyle = dataGridViewCellStyle3;
            Final.HeaderText = "Final";
            Final.Name = "Final";
            Final.Width = 40;
            // 
            // SubjectCode
            // 
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubjectCode.DefaultCellStyle = dataGridViewCellStyle4;
            SubjectCode.HeaderText = "Code";
            SubjectCode.Name = "SubjectCode";
            SubjectCode.Width = 70;
            // 
            // Subject
            // 
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Subject.DefaultCellStyle = dataGridViewCellStyle5;
            Subject.HeaderText = "Subject";
            Subject.Name = "Subject";
            // 
            // MyGradesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 186, 0);
            ClientSize = new Size(398, 697);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MyGradesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Grades";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Prelim;
        private DataGridViewTextBoxColumn Midterm;
        private DataGridViewTextBoxColumn Final;
        private DataGridViewTextBoxColumn SubjectCode;
        private DataGridViewTextBoxColumn Subject;
    }
}