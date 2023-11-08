using BusinessObjects.Models;

namespace HRMService
{
    public interface IAccountService
    {
        Hraccount getAccountByEmail(string email);
        List<Hraccount> getAccounts();
        bool InsertHraccount(Hraccount account);
        List<Hraccount> SearchAccountByEmail(string email);
        bool UpdateHrAccount(Hraccount hraccount);
        bool DeleteHrAccount(string hraccountID);
    }
}
