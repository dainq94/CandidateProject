using BusinessObjects.Models;

namespace HRMRepository
{
    public interface IJobRepository
    {
        List<JobPosting> GetAll();

    }
}
