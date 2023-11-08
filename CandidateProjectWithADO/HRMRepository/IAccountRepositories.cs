using BusinessObjects.Models;

namespace HRMRepository
{
    public interface IAccountRepositories
    {
        Hraccount GetHraccountByEmail(string email, string password);
        List<Hraccount> GetAll();
        List<Hraccount> GetHraccountBySearch(string keyword);
        int Create(Hraccount hraccount);
        int Update(Hraccount hraccount);
        int Delete(string email);
    }
}
