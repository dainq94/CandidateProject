using BusinessObjects.Models;

namespace HRMService
{
    public interface ICandidateProfileService
    {
        List<CandidateProfile> GetCandidateProfiles();
        bool InsertCandidate(CandidateProfile candidateProfile);
        bool UpdateCandidate(CandidateProfile candidateProfile);
        bool DeleteCandidate(string candidateID);
        List<CandidateProfile> SearchCandidateByFullname(string fullname);
    }
}
