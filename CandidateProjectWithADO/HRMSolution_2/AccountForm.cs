using BusinessObjects.Models;
using HRMRepository;

namespace HRMAPP
{
    public partial class AccountForm : Form
    {
        private readonly IAccountRepositories _accountRepo = null;
        public AccountForm()
        {
            InitializeComponent();
            _accountRepo = new AccountRepository();
        }
        public void ClearData()
        {
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtFullname.Text = string.Empty;
            txtRole.Text = string.Empty;

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            if (searchValue.Trim().Length > 0)
            {
                var accounts = _accountRepo.GetHraccountBySearch(searchValue);
                dtgAccount.DataSource = accounts;
            }
            else
            {
                dtgAccount.DataSource = _accountRepo.GetAll();

            }
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            dtgAccount.DataSource = _accountRepo.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Hraccount hraccount = new Hraccount();
                hraccount.Email = txtEmail.Text.Trim();
                hraccount.FullName = txtFullname.Text.Trim();
                hraccount.Password = txtPassword.Text.Trim();
                hraccount.MemberRole = int.Parse(txtRole.Text);
                if (hraccount.Email.Length > 0)
                {
                    int result = _accountRepo.Create(hraccount);
                    if (result == 1)
                        MessageBox.Show("Record Save Successfully");
                    else
                        MessageBox.Show("Add Faill");
                    dtgAccount.DataSource = _accountRepo.GetAll();

                }
                else
                {
                    MessageBox.Show("ID not allow empty");
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Hraccount account = new Hraccount();
            account.Email = txtEmail.Text.Trim();
            account.Password = txtPassword.Text.Trim();
            account.FullName = txtFullname.Text.Trim();
            account.MemberRole = int.Parse(txtRole.Text);

            int result = _accountRepo.Update(account);
            if (result == 1)
            {
                MessageBox.Show("Update Successfull");
                dtgAccount.DataSource = _accountRepo.GetAll();

            }
            else
            {
                MessageBox.Show("Update Faill");
            }
        }

        private void dtgAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmail.Text = dtgAccount.CurrentRow.Cells[0].Value.ToString();
            txtPassword.Text = dtgAccount.CurrentRow.Cells[1].Value.ToString();
            txtFullname.Text = dtgAccount.CurrentRow.Cells[2].Value.ToString();
            txtRole.Text = dtgAccount.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim().Length > 0)
            {

                if (MessageBox.Show("Are you sure to delete", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int result;
                    //txtEmail.Text = dtgAccount.CurrentRow.Cells[0].Value.ToString();

                    result = _accountRepo.Delete(txtEmail.Text);


                    if (result == 1)
                    {
                        MessageBox.Show("Delete Successfull");
                        dtgAccount.DataSource = _accountRepo.GetAll();

                    }
                    else
                    {
                        MessageBox.Show("Delete Faill");

                    }
                    ClearData();
                }
            }
            else
            {
                MessageBox.Show("Please Enter Emai TO Delete");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
