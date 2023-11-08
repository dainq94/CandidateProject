using BusinessObjects.Models;

namespace HRMRepository
{
    public interface IJobRepository
    {
        List<JobPosting> GetJobPosts();
        JobPosting GetJobPosting(string id);
    }
}
