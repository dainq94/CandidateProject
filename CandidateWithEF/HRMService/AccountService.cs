using BusinessObjects.Models;
using HRMRepository;

namespace HRMService
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepositories accountRepositories;

        public AccountService()
        {
            accountRepositories = new AccountRepository();
        }

        public bool DeleteHrAccount(string hraccountID)
        {
            return accountRepositories.DeleteHrAccount(hraccountID);
        }

        public Hraccount getAccountByEmail(string email)
        {
            return accountRepositories.GetHraccountByEmail(email);
        }

        public List<Hraccount> getAccounts()
        {
            return accountRepositories.GetHraccounts();
        }

        public bool InsertHraccount(Hraccount account)
        {
            return accountRepositories.InsertHraccount(account);
        }

        public List<Hraccount> SearchAccountByEmail(string email)
        {
            return accountRepositories.SearchAccountByEmail(email);
        }

        public bool UpdateHrAccount(Hraccount hraccount)
        {
            return accountRepositories.UpdateHrAccount(hraccount);
        }
    }
}