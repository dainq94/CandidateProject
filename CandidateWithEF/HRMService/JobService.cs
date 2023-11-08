using BusinessObjects.Models;
using HRMRepository;

namespace HRMService
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;
        public JobService()
        {
            _jobRepository = new JobRepository();
        }
        public List<JobPosting> GetJobPostings()
        {
            return _jobRepository.GetJobPosts();
        }

        public JobPosting GetJobPostings(string id)
        {
            return _jobRepository.GetJobPosting(id);
        }
    }
}
