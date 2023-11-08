using BusinessObjects.Models;

namespace HRMRepository
{
    public interface IAccountRepositories
    {
        Hraccount GetHraccountByEmail(String email);
        List<Hraccount> GetHraccounts();
        bool InsertHraccount(Hraccount hraccount);
        List<Hraccount> SearchAccountByEmail(String email);
        bool UpdateHrAccount(Hraccount hraccount);
        bool DeleteHrAccount(string hraccountID);
    }
}
