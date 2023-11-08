using BusinessObjects.Models;
using Microsoft.Data.SqlClient;

namespace HRMDAO
{
    public class JobDAO
    {
        private static CandidateManagementContext dBContext = null;
        private List<JobPosting> listJob = null;
        public JobDAO()
        {
            dBContext = CandidateManagementContext.Instance;
        }

        public List<JobPosting> GetAll()
        {
            listJob = new List<JobPosting>();
            try
            {

                SqlConnection con = dBContext.SqlConnection;
                con.Open();
                SqlCommand cm = new SqlCommand("  select * from JobPosting", con);
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    JobPosting job = new JobPosting();
                    job.PostingId = sdr["PostingID"].ToString();
                    job.JobPostingTitle = sdr["JobPostingTitle"].ToString();
                    job.Description = sdr["Description"].ToString();
                    job.PostedDate = DateTime.Parse(sdr["PostedDate"].ToString());

                    listJob.Add(job);
                }
                con.Close();
                return listJob;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
