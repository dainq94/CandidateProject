//using BusinessObjects.Models;
//using HRMService;
//using System.Text.RegularExpressions;
//namespace HRMAPP
//{
//    public partial class SignUpForm : Form
//    {
//        private readonly IAccountService _accountService;
//        public SignUpForm()
//        {
//            InitializeComponent();
//            _accountService = new AccountService();
//        }

//        private void SignUpForm_Load(object sender, EventArgs e)
//        {

//        }

//        private void label2_Click(object sender, EventArgs e)
//        {

//        }
//        public void ClearData()
//        {
//            txtUserName.Clear();
//            txtFullName.Clear();
//            txtPassword.Clear();
//            txtCfPassword.Clear();
//        }
//        public bool CheckAccount(string account)
//        {
//            return Regex.IsMatch(account, "^[a-zA-Z0-9]{6,24}$");
//        }

//        public bool CheckFullName(string fullname)
//        {
//            return Regex.IsMatch(fullname, @"^[a-zA-Z\s]{3,20}$");
//        }
//        public bool CheckEmail(string email)
//        {
//            return Regex.IsMatch(email, @"^[a-zA-Z0-9.]{3,20}@hr.com.vn$");
//        }
//        private void btnLogin_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                Hraccount hraccount = new Hraccount();
//                hraccount.Email = txtUserName.Text.Trim();
//                hraccount.FullName = txtPassword.Text.Trim();
//                hraccount.MemberRole = 3;
//                hraccount.Password = txtPassword.Text.Trim();
//                if (!CheckEmail(hraccount.Email))
//                {
//                    MessageBox.Show("Please input correct email format!");
//                }
//                else if (txtPassword.Text != txtCfPassword.Text)
//                {
//                    lbConfirmPassword.Visible = true;
//                }
//                else
//                {

//                    lbConfirmPassword.Visible = false;


//                    bool result = _accountService
//                        .InsertHraccount(hraccount);
//                    ClearData();
//                    if (result)
//                    {
//                        MessageBox.Show("Register Successfull");
//                    }
//                    else
//                    {
//                        MessageBox.Show("Register Fail");
//                    }

//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }

//        }

//        private void txtPassword_TextChanged(object sender, EventArgs e)
//        {
//        }

//        private void label5_Click(object sender, EventArgs e)
//        {

//        }

//        private void txtUserName_TextChanged(object sender, EventArgs e)
//        {
//        }

//        private void label4_Click(object sender, EventArgs e)
//        {

//        }

//        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
//        {
//            txtPassword.PasswordChar = cbShowPassword.Checked ? '\0' : '*';
//            txtCfPassword.PasswordChar = cbShowPassword.Checked ? '\0' : '*';
//        }

//        private void textBox1_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void label1_Click(object sender, EventArgs e)
//        {

//        }

//        private void btnSignUp_Click(object sender, EventArgs e)
//        {
//            LoginForm2 loginForm2 = new LoginForm2();
//            loginForm2.Show();
//            this.Hide();
//        }
//    }
//}
