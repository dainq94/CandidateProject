using BusinessObjects.Models;
using HRMRepository;

namespace HRMAPP
{
    public partial class LoginForm2 : Form
    {
        private readonly IAccountRepositories _accountRepository = null;
        public static Hraccount hraccount = null;
        public LoginForm2()
        {
            InitializeComponent();
            _accountRepository = new AccountRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                hraccount = _accountRepository.GetHraccountByEmail(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                if (hraccount != null && txtPassword.Text.Trim().Equals(hraccount.Password))
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please check username and password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // SignUpForm signUpForm = new SignUpForm();
            // signUpForm.Show();
            this.Hide();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbShowPassword.Checked ? '\0' : '*';
        }

    }
}
