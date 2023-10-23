using BusinessObjects.Models;
using HRMDAO;

namespace HRMRepository
{
    public class CandidateProfileRepository : ICandidateProfileRepository
    {
        public bool DeleteCandidateProfile(string candidateID)
        => CandidateProfileDAO.Instance.DeleteCandidate(candidateID);

        public List<CandidateProfile> GetCandidateProfiles()
            => CandidateProfileDAO.Instance.GetAllCandidate();

        public bool InsertCandidateProfile(CandidateProfile candidateProfile)
        => CandidateProfileDAO.Instance.InsertCandidate(candidateProfile);

        public List<CandidateProfile> SearchCandidateByFullname(string fullname)
        => CandidateProfileDAO.Instance.SearchCandidateByFullName(fullname);


        public bool UpdateCandidateProfile(CandidateProfile candidateProfile)
        => CandidateProfileDAO.Instance.UpdateCandidate(candidateProfile);

    }
}
