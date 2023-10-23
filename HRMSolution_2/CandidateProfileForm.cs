using BusinessObjects.Models;
using HRMService;

namespace HRMAPP
{
    public partial class CandidateProfileForm : Form
    {
        private readonly IJobService jobService = null;
        private readonly IAccountService accountService = null;
        private readonly ICandidateProfileService candidateProfileService = null;

        private CandidateProfile candidate = new CandidateProfile();
        public CandidateProfileForm()
        {
            InitializeComponent();
            jobService = new JobService();
            accountService = new AccountService();
            candidateProfileService = new CandidateProfileService();
        }

        private void CandidateProfile_Load(object sender, EventArgs e)
        {
            dtgCandidates.DataSource = candidateProfileService.GetCandidateProfiles();
            cbPost.DataSource = jobService.GetJobPostings();
            cbPost.DisplayMember = "JobPostingTitle";
            cbPost.ValueMember = "PostingId";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CandidateProfile candidateProfile = new CandidateProfile();
            candidateProfile.CandidateId = txtCandidateID.Text.Trim();
            candidateProfile.Fullname = txtFullName.Text.Trim();
            candidateProfile.Birthday = dtBirthDay.Value;
            candidateProfile.ProfileUrl = txtProfile.Text.Trim();
            candidateProfile.ProfileShortDescription = txtDecription.Text.Trim();
            candidateProfile.PostingId = cbPost.SelectedValue.ToString();

            bool result = candidateProfileService.UpdateCandidate(candidateProfile);
            if (result)
            {
                MessageBox.Show("Update Successfull");
                dtgCandidates.DataSource = candidateProfileService.GetCandidateProfiles();

            }
            else
            {
                MessageBox.Show("Update Fail!!");

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
                bool result = candidateProfileService.InsertCandidate(candidate);
                if (result)
                {
                    MessageBox.Show("Record Save Successfully");
                    dtgCandidates.DataSource = candidateProfileService.GetCandidateProfiles();
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
            int row = e.RowIndex;
            int cel = e.ColumnIndex;
            //txtCandidateID.Text = dtgCandidates.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //txtFullName.Text = dtgCandidates.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            ////dtBirthDay.Value = (DateTime)dtgCandidates.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            //txtProfile.Text = dtgCandidates.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //txtDecription.Text = dtgCandidates.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //cbPost.Text = dtgCandidates.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            Console.WriteLine(txtCandidateID.Text);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgCandidates_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtCandidateID.Text = dtgCandidates.CurrentRow.Cells[0].Value.ToString();
            txtFullName.Text = dtgCandidates.CurrentRow.Cells[1].Value.ToString();
            dtBirthDay.Text = dtgCandidates.CurrentRow.Cells[2].Value.ToString();
            txtProfile.Text = dtgCandidates.CurrentRow.Cells[3].Value.ToString();
            txtDecription.Text = dtgCandidates.CurrentRow.Cells[4].Value.ToString();
            string id = dtgCandidates.CurrentRow.Cells[5].Value.ToString();
            var JobPosting = jobService.GetJobPostings(id);
            if (JobPosting != null)
            {
                cbPost.Text = JobPosting.JobPostingTitle;
            }

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
            string id = dtgCandidates.CurrentRow.Cells[5].Value.ToString();
            var JobPosting = jobService.GetJobPostings(id);
            if (JobPosting != null)
            {
                cbPost.Text = JobPosting.JobPostingTitle;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCandidateID.Text.Trim().Length > 0)
            {
                if (MessageBox.Show("Are you sure to delete", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    bool result = false;
                    //txtCandidateID.Text = dtgCandidates.CurrentRow.Cells[0].Value.ToString();

                    result = candidateProfileService.DeleteCandidate(txtCandidateID.Text);


                    if (result)
                    {
                        MessageBox.Show("Delete Successfull");
                        dtgCandidates.DataSource = candidateProfileService.GetCandidateProfiles();

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
                var candidates = candidateProfileService.SearchCandidateByFullname(searchValue);
                dtgCandidates.DataSource = candidates;
            }
            else
            {
                dtgCandidates.DataSource = candidateProfileService.GetCandidateProfiles();

            }

        }
    }
}
