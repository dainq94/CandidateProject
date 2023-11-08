namespace HRMAPP
{
    partial class CandidateProfileForm
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
            dtgCandidates = new DataGridView();
            groupBox2 = new GroupBox();
            cbPost = new ComboBox();
            label3 = new Label();
            lbDescription = new Label();
            txtDecription = new TextBox();
            dtBirthDay = new DateTimePicker();
            label5 = new Label();
            txtProfile = new TextBox();
            txtFullName = new TextBox();
            txtCandidateID = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            btnClose = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            groupBox4 = new GroupBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCandidates).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtgCandidates);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1075, 272);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Candidate List";
            // 
            // dtgCandidates
            // 
            dtgCandidates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCandidates.Location = new Point(0, 19);
            dtgCandidates.Name = "dtgCandidates";
            dtgCandidates.RowHeadersWidth = 51;
            dtgCandidates.RowTemplate.Height = 29;
            dtgCandidates.Size = new Size(1045, 253);
            dtgCandidates.TabIndex = 0;
            dtgCandidates.CellClick += dtgCandidates_CellClick;
            dtgCandidates.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbPost);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(lbDescription);
            groupBox2.Controls.Add(txtDecription);
            groupBox2.Controls.Add(dtBirthDay);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtProfile);
            groupBox2.Controls.Add(txtFullName);
            groupBox2.Controls.Add(txtCandidateID);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 368);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(755, 276);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Candidate Profile";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // cbPost
            // 
            cbPost.FormattingEnabled = true;
            cbPost.Location = new Point(502, 205);
            cbPost.Name = "cbPost";
            cbPost.Size = new Size(151, 28);
            cbPost.TabIndex = 15;
            cbPost.SelectedIndexChanged += cbPost_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(398, 208);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 14;
            label3.Text = "Post";
            label3.Click += label3_Click;
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(25, 199);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(89, 20);
            lbDescription.TabIndex = 12;
            lbDescription.Text = "Description";
            // 
            // txtDecription
            // 
            txtDecription.Location = new Point(129, 175);
            txtDecription.Multiline = true;
            txtDecription.Name = "txtDecription";
            txtDecription.Size = new Size(216, 85);
            txtDecription.TabIndex = 11;
            txtDecription.TextChanged += txtDecription_TextChanged;
            // 
            // dtBirthDay
            // 
            dtBirthDay.Location = new Point(129, 125);
            dtBirthDay.Name = "dtBirthDay";
            dtBirthDay.Size = new Size(216, 27);
            dtBirthDay.TabIndex = 10;
            dtBirthDay.ValueChanged += dtBirthDay_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(398, 130);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 9;
            label5.Text = "Profile";
            // 
            // txtProfile
            // 
            txtProfile.Location = new Point(502, 123);
            txtProfile.Name = "txtProfile";
            txtProfile.Size = new Size(157, 27);
            txtProfile.TabIndex = 8;
            txtProfile.TextChanged += txtProfile_TextChanged;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(502, 61);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(157, 27);
            txtFullName.TabIndex = 7;
            // 
            // txtCandidateID
            // 
            txtCandidateID.Location = new Point(129, 61);
            txtCandidateID.Name = "txtCandidateID";
            txtCandidateID.Size = new Size(216, 27);
            txtCandidateID.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 64);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 3;
            label4.Text = "Fullname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 123);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "BirthDay";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 61);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "CandidateID";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnClose);
            groupBox3.Controls.Add(btnDelete);
            groupBox3.Controls.Add(btnUpdate);
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Location = new Point(765, 368);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(173, 276);
            groupBox3.TabIndex = 2;
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
            btnUpdate.Click += button2_Click;
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
            // groupBox4
            // 
            groupBox4.Controls.Add(pictureBox1);
            groupBox4.Controls.Add(btnSearch);
            groupBox4.Controls.Add(txtSearch);
            groupBox4.Controls.Add(label6);
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1075, 57);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(33, 11, 97);
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.ControlLightLight;
            btnSearch.Location = new Point(839, 23);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(99, 28);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(253, 24);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(514, 27);
            txtSearch.TabIndex = 15;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(69, 26);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 4;
            label6.Text = "Fullname";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.giphy1;
            pictureBox1.Location = new Point(207, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // CandidateProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1075, 656);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "CandidateProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CandidateProfile";
            Load += CandidateProfile_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgCandidates).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnClose;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label1;
        private Label label2;
        private DateTimePicker dtBirthDay;
        private Label label5;
        private TextBox txtProfile;
        private TextBox txtFullName;
        private TextBox txtCandidateID;
        private Label label4;
        private Label label3;
        private Label lbDescription;
        private TextBox txtDecription;
        private GroupBox groupBox4;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label6;
        private ComboBox cbPost;
        private DataGridView dtgCandidates;
        private PictureBox pictureBox1;
    }
}