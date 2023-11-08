namespace HRMAPP
{
    partial class SignUpForm
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
            label8 = new Label();
            label7 = new Label();
            cbShowPassword = new CheckBox();
            btnRegister = new Button();
            txtCfPassword = new TextBox();
            label5 = new Label();
            txtUserName = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtFullName = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            lbConfirmPassword = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 11, 97);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnSignUp);
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 625);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_employee_card_100px;
            pictureBox1.Location = new Point(98, 275);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.MaximumSize = new Size(100, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.LimeGreen;
            btnSignUp.Location = new Point(35, 525);
            btnSignUp.Margin = new Padding(2);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(213, 39);
            btnSignUp.TabIndex = 0;
            btnSignUp.Text = "SIGN IN";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(43, 481);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(205, 19);
            label8.TabIndex = 0;
            label8.Text = "Login With Your Account";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(33, 11, 97);
            label7.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(197, 38);
            label7.Name = "label7";
            label7.Size = new Size(443, 33);
            label7.TabIndex = 0;
            label7.Text = "Candidate Management System";
            // 
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbShowPassword.Location = new Point(577, 440);
            cbShowPassword.Margin = new Padding(2);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(135, 21);
            cbShowPassword.TabIndex = 0;
            cbShowPassword.Text = "show Password";
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(33, 11, 97);
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(405, 511);
            btnRegister.Margin = new Padding(2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(113, 37);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnLogin_Click;
            // 
            // txtCfPassword
            // 
            txtCfPassword.Location = new Point(405, 398);
            txtCfPassword.Margin = new Padding(2);
            txtCfPassword.Name = "txtCfPassword";
            txtCfPassword.PasswordChar = '*';
            txtCfPassword.Size = new Size(307, 27);
            txtCfPassword.TabIndex = 3;
            txtCfPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(405, 375);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(154, 21);
            label5.TabIndex = 0;
            label5.Text = "Comfirm Password:";
            label5.Click += label5_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(405, 176);
            txtUserName.Margin = new Padding(2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(307, 27);
            txtUserName.TabIndex = 0;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(405, 153);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 0;
            label4.Text = "Email:";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(338, 104);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(194, 27);
            label2.TabIndex = 0;
            label2.Text = "SignUp Account";
            label2.Click += label2_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(405, 253);
            txtFullName.Margin = new Padding(2);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(307, 27);
            txtFullName.TabIndex = 1;
            txtFullName.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(405, 230);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 0;
            label1.Text = "FullName:";
            label1.Click += label1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(405, 328);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(307, 27);
            txtPassword.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(405, 305);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 0;
            label3.Text = "Password:";
            // 
            // lbConfirmPassword
            // 
            lbConfirmPassword.AutoSize = true;
            lbConfirmPassword.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbConfirmPassword.ForeColor = Color.Red;
            lbConfirmPassword.Location = new Point(405, 463);
            lbConfirmPassword.Margin = new Padding(2, 0, 2, 0);
            lbConfirmPassword.Name = "lbConfirmPassword";
            lbConfirmPassword.Size = new Size(291, 21);
            lbConfirmPassword.TabIndex = 5;
            lbConfirmPassword.Text = "The Comfirm Password doesn't match";
            lbConfirmPassword.Visible = false;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 625);
            Controls.Add(lbConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtFullName);
            Controls.Add(label1);
            Controls.Add(cbShowPassword);
            Controls.Add(btnRegister);
            Controls.Add(txtCfPassword);
            Controls.Add(label5);
            Controls.Add(txtUserName);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(panel1);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += SignUpForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private CheckBox cbShowPassword;
        private Button btnRegister;
        private TextBox txtCfPassword;
        private Label label5;
        private TextBox txtUserName;
        private Label label4;
        private Label label2;
        private TextBox txtFullName;
        private Label label1;
        private TextBox txtPassword;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btnSignUp;
        private Label label8;
        private Label lbConfirmPassword;
    }
}