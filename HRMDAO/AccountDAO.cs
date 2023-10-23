using BusinessObjects.Models;

namespace HRMDAO
{
    public class AccountDAO
    {
        private static AccountDAO? instance = null;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAO();
                }
                return instance;
            }
        }
        public Hraccount GetHraccountByEmail(String email)
        {
            try
            {
                var dbContent = new CandidateManagementContext();
                return dbContent.Hraccounts.SingleOrDefault(m => m.Email.Equals(email));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Hraccount> GetHraccounts()
        {
            try
            {
                var dbContext = new CandidateManagementContext();
                return dbContext.Hraccounts.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool InsertHraccount(Hraccount hraccount)
        {
            try
            {
                var dbContext = new CandidateManagementContext();
                Hraccount hraccountdb = GetHraccountByEmail(hraccount.Email);
                if (hraccountdb == null)
                {
                    dbContext.Hraccounts.Add(hraccount);
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
        public List<Hraccount> SearchAccountByEmail(string email)
        {
            try
            {
                var dbContext = new CandidateManagementContext();
                return dbContext.Hraccounts.Where(s => s.Email.Contains(email)).ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public bool UpdateHrAccount(Hraccount hraccount)
        {
            try
            {
                var dbContext = new CandidateManagementContext();
                Hraccount account = GetHraccountByEmail(hraccount.Email);
                if (account != null)
                {
                    dbContext.Hraccounts.Update(hraccount);
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
        public bool DeleteHrAccount(string hraccountID)
        {

            try
            {
                var dbContext = new CandidateManagementContext();
                Hraccount account = GetHraccountByEmail(hraccountID);

                if (account != null)
                {
                    dbContext.Hraccounts.Remove(account);
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
    }
}