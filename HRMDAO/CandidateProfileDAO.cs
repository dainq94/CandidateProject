using BusinessObjects.Models;

namespace HRMDAO
{
    public class CandidateProfileDAO
    {
        private static CandidateProfileDAO instance = null;

        public static CandidateProfileDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CandidateProfileDAO();
                }
                return instance;
            }
        }
        public List<CandidateProfile> GetAllCandidate()
        {
            try
            {
                var dbContext = new CandidateManagementContext();
                return dbContext.CandidateProfiles.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public CandidateProfile GetCandidateProfileById(string candidteID)
        {
            try
            {
                var dbContext = new CandidateManagementContext();

                return dbContext.CandidateProfiles.SingleOrDefault(m => m.CandidateId.Equals(candidteID));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public bool InsertCandidate(CandidateProfile candidateProfile)
        {
            try
            {
                var dbContext = new CandidateManagementContext();
                CandidateProfile candidate = GetCandidateProfileById(candidateProfile.CandidateId);
                if (candidate == null)
                {
                    dbContext.CandidateProfiles.Add(candidateProfile);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return false;
        }
        public bool UpdateCandidate(CandidateProfile candidateProfile)
        {
            try
            {
                var dbContext = new CandidateManagementContext();
                CandidateProfile candidate = GetCandidateProfileById(candidateProfile.CandidateId);
                if (candidate != null)
                {
                    dbContext.CandidateProfiles.Update(candidateProfile);
                    dbContext.SaveChanges();
                    return true;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return false;
        }
        public bool DeleteCandidate(string candidateID)
        {

            try
            {
                var dbContext = new CandidateManagementContext();
                CandidateProfile candidate = GetCandidateProfileById(candidateID);
                if (candidate != null)
                {
                    dbContext.CandidateProfiles.Remove(candidate);
                    dbContext.SaveChanges();
                    return true;

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return false;
        }
        public List<CandidateProfile> SearchCandidateByFullName(string fullName)
        {
            try
            {
                var dbContext = new CandidateManagementContext();
                return dbContext.CandidateProfiles.Where(s => s.Fullname.Contains(fullName)).ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
