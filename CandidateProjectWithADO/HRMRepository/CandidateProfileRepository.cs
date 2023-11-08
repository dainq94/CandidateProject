using BusinessObjects.Models;
using HRMDAO;

namespace HRMRepository
{
    public class CandidateProfileRepository : ICandidateProfileRepository
    {
        private readonly CandidateProfileDAO _candidateProfileDAO;
        public CandidateProfileRepository()
        {
            _candidateProfileDAO = new CandidateProfileDAO();
        }

        public int create(CandidateProfile candidateProfile)
        => _candidateProfileDAO.create(candidateProfile);

        public int delete(string id)
        => _candidateProfileDAO.remove(id);
        public List<CandidateProfile> GetAll()
        => _candidateProfileDAO.GetAll();

        public List<CandidateProfile> GetCandiBySearch(string keyword)
        => _candidateProfileDAO.GetCandiBySearch(keyword);

        public int update(CandidateProfile candidateProfile)
        => _candidateProfileDAO.update(candidateProfile);
    }
}
