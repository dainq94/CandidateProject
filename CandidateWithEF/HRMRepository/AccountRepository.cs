using BusinessObjects.Models;
using HRMDAO;

namespace HRMRepository
{
    public class AccountRepository : IAccountRepositories
    {
        public List<Hraccount> SearchAccountByEmail(string email)
        => AccountDAO.Instance.SearchAccountByEmail(email);


        public Hraccount GetHraccountByEmail(string email)
        {
            return AccountDAO.Instance.GetHraccountByEmail(email);
        }

        public List<Hraccount> GetHraccounts()
        {
            return AccountDAO.Instance.GetHraccounts();
        }

        public bool InsertHraccount(Hraccount hraccount)
        => AccountDAO.Instance.InsertHraccount(hraccount);

        public bool UpdateHrAccount(Hraccount hraccount)
        => AccountDAO.Instance.UpdateHrAccount(hraccount);


        public bool DeleteHrAccount(string hraccountID)
        => AccountDAO.Instance.DeleteHrAccount(hraccountID);

    }
}