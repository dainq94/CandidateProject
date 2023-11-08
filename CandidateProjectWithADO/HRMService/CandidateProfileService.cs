using BusinessObjects.Models;
using HRMRepository;

namespace HRMService
{
    public class CandidateProfileService : ICandidateProfileService
    {
        private readonly ICandidateProfileRepository _candidateProfileRepository;
        public CandidateProfileService()
        {
            _candidateProfileRepository = new CandidateProfileRepository();
        }

        public bool DeleteCandidate(string candidateID)
        {
            return _candidateProfileRepository.DeleteCandidateProfile(candidateID);
        }

        public List<CandidateProfile> GetCandidateProfiles()
        {
            return _candidateProfileRepository.GetCandidateProfiles();
        }

        public bool InsertCandidate(CandidateProfile candidateProfile)
        {
            return _candidateProfileRepository.InsertCandidateProfile(candidateProfile);
        }

        public List<CandidateProfile> SearchCandidateByFullname(string fullname)
        {
            return _candidateProfileRepository.SearchCandidateByFullname(fullname);
        }

        public bool UpdateCandidate(CandidateProfile candidateProfile)
        {
            return _candidateProfileRepository.UpdateCandidateProfile(candidateProfile);
        }
    }
}
