using BusinessObjects.Models;
using HRMDAO;

namespace HRMRepository
{
    public class AccountRepository : IAccountRepositories
    {

        private readonly AccountDAO _accountDAO;
        public AccountRepository()
        {
            _accountDAO = new AccountDAO();
        }

        public int Create(Hraccount hraccount)
        => _accountDAO.create(hraccount);

        public int Delete(string email)
        => _accountDAO.remove(email);

        public List<Hraccount> GetAll()
        => _accountDAO.GetAll();

        public Hraccount GetHraccountByEmail(string email, string password)
        => _accountDAO.loginAccount(email, password);

        public List<Hraccount> GetHraccountBySearch(string keyword)
        => _accountDAO.GetHraccountBySearch(keyword);

        public int Update(Hraccount hraccount)
        => _accountDAO.update(hraccount);
    }
}