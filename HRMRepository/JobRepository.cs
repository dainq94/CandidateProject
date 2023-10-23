using BusinessObjects.Models;
using HRMDAO;

namespace HRMRepository
{
    public class JobRepository : IJobRepository
    {
        public JobPosting GetJobPosting(string id) => JobDAO.Instance.GetJobPosting(id);



        public List<JobPosting> GetJobPosts() => JobDAO.Instance.GetJobPosting();



    }
}
