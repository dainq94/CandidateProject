namespace HRMAPP
{
    partial class AccountForm
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
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            btnClose = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dtgAccount = new DataGridView();
            label6 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtRole = new TextBox();
            label5 = new Label();
            txtFullname = new TextBox();
            lbDescription = new Label();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgAccount).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(845, 61);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.giphy;
            pictureBox1.Location = new Point(140, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(33, 11, 97);
            btnSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.ControlLightLight;
            btnSearch.Location = new Point(657, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(121, 41);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(179, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(425, 27);
            txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(54, 20);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 0;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnClose);
            groupBox3.Controls.Add(btnDelete);
            groupBox3.Controls.Add(btnUpdate);
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Location = new Point(688, 330);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(203, 261);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(33, 11, 97);
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.ControlLightLight;
            btnClose.Location = new Point(27, 208);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(123, 38);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(33, 11, 97);
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(27, 143);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(123, 38);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(33, 11, 97);
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(27, 85);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(123, 38);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(33, 11, 97);
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(27, 26);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 38);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dtgAccount
            // 
            dtgAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAccount.Location = new Point(6, 18);
            dtgAccount.Name = "dtgAccount";
            dtgAccount.RowHeadersWidth = 51;
            dtgAccount.RowTemplate.Height = 29;
            dtgAccount.Size = new Size(873, 216);
            dtgAccount.TabIndex = 5;
            dtgAccount.CellClick += dtgAccount_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(25, 58);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 0;
            label6.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(381, 62);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(115, 55);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(484, 55);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(157, 27);
            txtPassword.TabIndex = 7;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(484, 121);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(157, 27);
            txtRole.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(369, 121);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 9;
            label5.Text = "MemberRole";
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(115, 121);
            txtFullname.Multiline = true;
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(216, 29);
            txtFullname.TabIndex = 11;
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbDescription.Location = new Point(25, 126);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(76, 20);
            lbDescription.TabIndex = 12;
            lbDescription.Text = "FullName";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbDescription);
            groupBox2.Controls.Add(txtFullname);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtRole);
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 346);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(663, 208);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Account Mange";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dtgAccount);
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(12, 84);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(879, 240);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 603);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccountForm";
            Load += AccountForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgAccount).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
        private GroupBox groupBox3;
        private Button btnClose;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dtgAccount;
        private Label label6;
        private Label label4;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtRole;
        private Label label5;
        private TextBox txtFullname;
        private Label lbDescription;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private GroupBox groupBox4;
    }
}