using BusinessObjects.Models;

namespace HRMDAO
{
    public class JobDAO
    {
        private static JobDAO instance = null;

        public static JobDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new JobDAO();
                }
                return instance;
            }
        }
        public List<JobPosting> GetJobPosting()
        {
            try
            {
                var dbContext = new CandidateManagementContext();
                return dbContext.JobPostings.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public JobPosting GetJobPosting(string id)
        {
            try
            {
                var dbContext = new CandidateManagementContext();
                return dbContext.JobPostings.SingleOrDefault(e => e.PostingId == id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
