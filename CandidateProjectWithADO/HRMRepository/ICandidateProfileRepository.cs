using BusinessObjects.Models;

namespace HRMRepository
{
    public interface ICandidateProfileRepository
    {
        List<CandidateProfile> GetAll();
        List<CandidateProfile> GetCandiBySearch(string keyword);
        int create(CandidateProfile candidateProfile);
        int update(CandidateProfile candidateProfile);
        int delete(string id);
    }
}
