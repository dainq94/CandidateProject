using BusinessObjects.Models;

namespace HRMService
{
    public interface IJobService
    {
        List<JobPosting> GetJobPostings();
        JobPosting GetJobPostings(string id);
    }
}
