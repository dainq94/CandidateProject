namespace HRMAPP
{
    partial class LoginForm2
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
            pictureBox1 = new PictureBox();
            btnSignUp = new Button();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label5 = new Label();
            btnLogin = new Button();
            cbShowPassword = new CheckBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 11, 97);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnSignUp);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(351, 654);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_employee_card_100px;
            pictureBox1.Location = new Point(113, 289);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.MaximumSize = new Size(100, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 142);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.LimeGreen;
            btnSignUp.Location = new Point(56, 544);
            btnSignUp.Margin = new Padding(2);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(213, 39);
            btnSignUp.TabIndex = 1;
            btnSignUp.Text = "SignUp";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(76, 502);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(185, 19);
            label6.TabIndex = 0;
            label6.Text = "Register Your Account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1029, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 22);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(402, 187);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(176, 27);
            label2.TabIndex = 2;
            label2.Text = "Login Account";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(452, 266);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 4;
            label4.Text = "UserName:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(452, 309);
            txtUserName.Margin = new Padding(2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(307, 28);
            txtUserName.TabIndex = 5;
            txtUserName.Text = "admin@hr.com.vn";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(452, 417);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(307, 28);
            txtPassword.TabIndex = 7;
            txtPassword.Text = "123@";
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(452, 377);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 21);
            label5.TabIndex = 6;
            label5.Text = "Password:";
            label5.Click += label5_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(33, 11, 97);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(452, 483);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(113, 37);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbShowPassword.Location = new Point(624, 458);
            cbShowPassword.Margin = new Padding(2);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(135, 21);
            cbShowPassword.TabIndex = 9;
            cbShowPassword.Text = "show Password";
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(33, 11, 97);
            label7.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(207, 75);
            label7.Name = "label7";
            label7.Size = new Size(443, 33);
            label7.TabIndex = 4;
            label7.Text = "Candidate Management System";
            // 
            // LoginForm2
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 654);
            Controls.Add(label7);
            Controls.Add(cbShowPassword);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(txtUserName);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginForm2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label5;
        private Button btnLogin;
        private CheckBox cbShowPassword;
        private PictureBox pictureBox1;
        private Button btnSignUp;
        private Label label6;
        private Label label7;
    }
}