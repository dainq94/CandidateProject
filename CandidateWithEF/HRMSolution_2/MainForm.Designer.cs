namespace HRMAPP
{
    partial class MainForm
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
            panel1 = new Panel();
            label2 = new Label();
            labExit = new Label();
            panel2 = new Panel();
            button5 = new Button();
            btnAccount = new Button();
            btnJob = new Button();
            btnCandidate = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel7 = new Panel();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            panel6 = new Panel();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            notifyIcon1 = new NotifyIcon(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 11, 97);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(labExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1201, 38);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(220, 20);
            label2.TabIndex = 1;
            label2.Text = "Candidate Management System";
            // 
            // labExit
            // 
            labExit.AutoSize = true;
            labExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labExit.ForeColor = Color.White;
            labExit.Location = new Point(1171, 9);
            labExit.Name = "labExit";
            labExit.Size = new Size(21, 23);
            labExit.TabIndex = 1;
            labExit.Text = "X";
            labExit.Click += labExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 11, 97);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(btnAccount);
            panel2.Controls.Add(btnJob);
            panel2.Controls.Add(btnCandidate);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 726);
            panel2.TabIndex = 1;
            // 
            // button5
            // 
            button5.Location = new Point(12, 684);
            button5.Name = "button5";
            button5.Size = new Size(84, 30);
            button5.TabIndex = 6;
            button5.Text = "Logout";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btnAccount
            // 
            btnAccount.Location = new Point(57, 339);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(146, 41);
            btnAccount.TabIndex = 5;
            btnAccount.Text = "Mange Account";
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnJob
            // 
            btnJob.Location = new Point(57, 460);
            btnJob.Name = "btnJob";
            btnJob.Size = new Size(146, 41);
            btnJob.TabIndex = 4;
            btnJob.Text = "JobPosting";
            btnJob.UseVisualStyleBackColor = true;
            // 
            // btnCandidate
            // 
            btnCandidate.Location = new Point(57, 404);
            btnCandidate.Name = "btnCandidate";
            btnCandidate.Size = new Size(146, 41);
            btnCandidate.TabIndex = 3;
            btnCandidate.Text = "Candidate Profile";
            btnCandidate.UseVisualStyleBackColor = true;
            btnCandidate.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(72, 217);
            label3.Name = "label3";
            label3.Size = new Size(122, 21);
            label3.TabIndex = 1;
            label3.Text = "Welcom, User";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_employee_card_100px;
            pictureBox1.Location = new Point(72, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 105);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(274, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(895, 207);
            panel3.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(33, 11, 97);
            panel7.Controls.Add(pictureBox5);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(618, 36);
            panel7.Name = "panel7";
            panel7.Size = new Size(250, 144);
            panel7.TabIndex = 1;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.icons8_Salary_male_30px1;
            pictureBox5.Location = new Point(24, 28);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(61, 71);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(81, 110);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 1;
            label5.Text = "Total Employees";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(33, 11, 97);
            panel6.Controls.Add(pictureBox4);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(326, 36);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 144);
            panel6.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_group_background_selected_filled_60px;
            pictureBox4.Location = new Point(26, 28);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(67, 62);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(78, 110);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 1;
            label4.Text = "Total Employees";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(33, 11, 97);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(36, 36);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 144);
            panel5.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_employee_card_60px_11;
            pictureBox3.Location = new Point(29, 28);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(79, 79);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(85, 110);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 0;
            label1.Text = "Total Employees";
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(274, 282);
            panel4.Name = "panel4";
            panel4.Size = new Size(895, 440);
            panel4.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._62fce6103af555f6b9bfcdce_ATS_in_the_recruitment_process;
            pictureBox2.Location = new Point(-3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(895, 437);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 764);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label labExit;
        private Panel panel2;
        private Button btnJob;
        private Button btnCandidate;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btnAccount;
        private Button button5;
        private Panel panel3;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Label label1;
        private Panel panel4;
        private Label label5;
        private Label label4;
        private NotifyIcon notifyIcon1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
    }
}