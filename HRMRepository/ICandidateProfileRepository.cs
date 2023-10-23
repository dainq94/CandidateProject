using BusinessObjects.Models;

namespace HRMRepository
{
    public interface ICandidateProfileRepository
    {
        List<CandidateProfile> GetCandidateProfiles();
        bool InsertCandidateProfile(CandidateProfile candidateProfile);
        bool UpdateCandidateProfile(CandidateProfile candidateProfile);
        bool DeleteCandidateProfile(string candidateID);
        List<CandidateProfile> SearchCandidateByFullname(string fullname);
    }
}
