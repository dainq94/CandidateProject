using BusinessObjects.Models;
using HRMRepository;

namespace HRMAPP
{
    public partial class CandidateProfileForm : Form
    {
        //private readonly IJobService jobService = null;
        //private readonly IAccountService accountService = null;
        private readonly ICandidateProfileRepository _candiRepo = null;
        private readonly IJobRepository _jobRepo = null;
        private CandidateProfile candidate = new CandidateProfile();
        public CandidateProfileForm()
        {
            InitializeComponent();
            _candiRepo = new CandidateProfileRepository();
            _jobRepo = new JobRepository();
        }

        private void CandidateProfile_Load(object sender, EventArgs e)
        {
            dtgCandidates.DataSource = _candiRepo.GetAll();
            cbPost.DataSource = _jobRepo.GetAll();
            cbPost.DisplayMember = "JobPostingTitle";
            cbPost.ValueMember = "PostingId";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CandidateProfile candidateprofile = new CandidateProfile();
            candidateprofile.CandidateId = txtCandidateID.Text.Trim();
            candidateprofile.Fullname = txtFullName.Text.Trim();
            candidateprofile.Birthday = dtBirthDay.Value;
            candidateprofile.ProfileUrl = txtProfile.Text.Trim();
            candidateprofile.ProfileShortDescription = txtDecription.Text.Trim();
            candidateprofile.PostingId = cbPost.SelectedValue.ToString();

            int result = _candiRepo.update(candidateprofile);
            if (result == 1)
            {
                MessageBox.Show("Update Sucessfull");
                dtgCandidates.DataSource = _candiRepo.GetAll();

            }
            else
            {
                MessageBox.Show("Update Fail!");

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDecription_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgCandidates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string s = datagrid
        }

        private void txtPost_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtProfile_TextChanged(object sender, EventArgs e)
        {

        }
        public void ClearData()
        {
            txtProfile.Clear();
            txtCandidateID.Clear();
            txtFullName.Clear();
            dtBirthDay.ResetText();
            txtDecription.Clear();
            cbPost.Refresh();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            candidate.CandidateId = txtCandidateID.Text.Trim();
            candidate.Fullname = txtFullName.Text.Trim();
            candidate.Birthday = dtBirthDay.Value;
            candidate.ProfileUrl = txtProfile.Text.Trim();
            candidate.ProfileShortDescription = txtDecription.Text.Trim();
            candidate.PostingId = cbPost.SelectedValue.ToString();
            if (candidate.CandidateId.Length > 0)
            {
                int result = _candiRepo.create(candidate);
                if (result == 1)
                {
                    MessageBox.Show("Record Save Successfully");
                    dtgCandidates.DataSource = _candiRepo.GetAll();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Add Fail");
                }


            }
            else
            {
                MessageBox.Show("ID not allow empty");
            }
        }

        private void cbPost_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvLop_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //int row = e.RowIndex;
            //int cel = e.ColumnIndex;
            //txtCandidateID.Text = dtgCandidates.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //txtFullName.Text = dtgCandidates.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //dtBirthDay.Value = (DateTime)dtgCandidates.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            //txtProfile.Text = dtgCandidates.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //txtDecription.Text = dtgCandidates.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //cbPost.Text = dtgCandidates.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            //Console.WriteLine(txtCandidateID.Text);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgCandidates_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //txtCandidateID.Text = dtgCandidates.CurrentRow.Cells[0].Value.ToString();
            //txtFullName.Text = dtgCandidates.CurrentRow.Cells[1].Value.ToString();
            //dtBirthDay.Text = dtgCandidates.CurrentRow.Cells[2].Value.ToString();
            //txtProfile.Text = dtgCandidates.CurrentRow.Cells[3].Value.ToString();
            //txtDecription.Text = dtgCandidates.CurrentRow.Cells[4].Value.ToString();
            //string id = dtgCandidates.CurrentRow.Cells[5].Value.ToString();
            //var JobPosting = _jobRepo.GetJobPostings(id);
            //if (JobPosting != null)
            //{
            //    cbPost.Text = JobPosting.JobPostingTitle;
            //}

        }

        private void dtBirthDay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgCandidates_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCandidateID.Text = dtgCandidates.CurrentRow.Cells[0].Value.ToString();
            txtFullName.Text = dtgCandidates.CurrentRow.Cells[1].Value.ToString();
            dtBirthDay.Text = dtgCandidates.CurrentRow.Cells[2].Value.ToString();
            txtProfile.Text = dtgCandidates.CurrentRow.Cells[3].Value.ToString();
            txtDecription.Text = dtgCandidates.CurrentRow.Cells[4].Value.ToString();
            cbPost.SelectedValue = dtgCandidates.CurrentRow.Cells[5].Value;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCandidateID.Text.Trim().Length > 0)
            {
                if (MessageBox.Show("Are you sure to delete", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    int result;
                    //txtCandidateID.Text = dtgCandidates.CurrentRow.Cells[0].Value.ToString();

                    result = _candiRepo.delete(txtCandidateID.Text);


                    if (result == 1)
                    {
                        MessageBox.Show("Delete Successfull");
                        dtgCandidates.DataSource = _candiRepo.GetAll();

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
                MessageBox.Show("Please Input CandidateID");

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            if (searchValue.Trim().Length > 0)
            {
                var candidates = _candiRepo.GetCandiBySearch(searchValue);
                dtgCandidates.DataSource = candidates;
            }
            else
            {
                dtgCandidates.DataSource = _candiRepo.GetAll();

            }

        }
    }
}
