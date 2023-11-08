using BusinessObjects.Models;
using HRMDAO;

namespace HRMRepository
{
    public class JobRepository : IJobRepository
    {
        private readonly JobDAO _jobDAO;
        public JobRepository()
        {
            _jobDAO = new JobDAO();
        }
        public List<JobPosting> GetAll()
        => _jobDAO.GetAll();
    }
}
