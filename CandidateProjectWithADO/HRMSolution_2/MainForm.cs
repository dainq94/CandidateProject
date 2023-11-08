namespace HRMAPP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void labExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CandidateProfileForm cand = new CandidateProfileForm();
            cand.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            int role = (int)LoginForm2.hraccount.MemberRole;
            if (role == 1)
            {
                AccountForm accountFrom = new AccountForm();
                accountFrom.Show();

            }
            else
            {
                MessageBox.Show("You don't have permission to access");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm2.hraccount = null;
            LoginForm2 loginForm2 = new LoginForm2();
            loginForm2.Show();
        }
    }
}
