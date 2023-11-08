using BusinessObjects.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HRMDAO
{
    public class AccountDAO
    {
        private static CandidateManagementContext dBContext = null;
        private List<Hraccount> listHraccount = null;
        public AccountDAO()
        {
            dBContext = CandidateManagementContext.Instance;
        }
        public Hraccount loginAccount(string email, string password)
        {
            Hraccount account = new Hraccount();
            try
            {
                SqlConnection con = dBContext.SqlConnection;
                con.Open();
                SqlCommand cm = new SqlCommand("Select Email, Password, MemberRole from HRAccount where Email = @email and Password = @password", con);
                cm.Parameters.AddWithValue("@email", email);
                cm.Parameters.AddWithValue("@password", password);
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    account.Email = sdr["Email"].ToString();
                    account.Password = sdr["Password"].ToString();
                    account.MemberRole = Int32.Parse(sdr["MemberRole"].ToString());
                }
                con.Close();
                return account;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public List<Hraccount> GetAll()
        {
            listHraccount = new List<Hraccount>();
            try
            {

                SqlConnection con = dBContext.SqlConnection;
                con.Open();
                SqlCommand cm = new SqlCommand("  select * from HRAccount", con);
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Hraccount account = new Hraccount();
                    account.Email = sdr["Email"].ToString();
                    account.Password = sdr["Password"].ToString();
                    account.FullName = sdr["FullName"].ToString();

                    account.MemberRole = int.Parse(sdr["MemberRole"].ToString());

                    listHraccount.Add(account);
                }
                con.Close();
                return listHraccount;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Hraccount> GetHraccountBySearch(string keyword)
        {
            List<Hraccount> searchList = new List<Hraccount>();
            try
            {
                SqlConnection con = dBContext.SqlConnection;

                con.Open();
                SqlCommand cm = new SqlCommand("  select * from HRAccount " +
                                                    " WHERE FullName LIKE @search", con);
                cm.Parameters.AddWithValue("@search", "%" + keyword + "%");

                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {

                    Hraccount account = new Hraccount();
                    account.Email = sdr["Email"].ToString();
                    account.Password = sdr["Password"].ToString();
                    account.FullName = sdr["FullName"].ToString();

                    account.MemberRole = int.Parse(sdr["MemberRole"].ToString());
                    searchList.Add(account);
                }
                con.Close();
                return searchList;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public bool isIDExisted(string email)
        {
            try
            {
                SqlConnection con = dBContext.SqlConnection;
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlCommand cm = new SqlCommand("SELECT COUNT(*) FROM HRAccount WHERE Email = @email", con);
                cm.Parameters.AddWithValue("@email", email);

                int count = (int)cm.ExecuteScalar();
                if (count > 0)
                {
                    con.Close();
                    return true;
                }
                con.Close();
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public int create(Hraccount account)
        {
            try
            {
                bool idExisted = this.isIDExisted(account.Email);
                if (idExisted)
                {
                    return 0;
                }
                else
                {
                    SqlConnection con = dBContext.SqlConnection;
                    con.Open();
                    SqlCommand cm = new SqlCommand("INSERT INTO HRAccount (Email,Password,FullName,MemberRole)" +
                        "values(@email,@password,@fullname, @memberRole)", con);

                    cm.Parameters.AddWithValue("@email", account.Email);
                    cm.Parameters.AddWithValue("@password", account.Password);
                    cm.Parameters.AddWithValue("@fullname", account.FullName);
                    cm.Parameters.AddWithValue("@memberRole", account.MemberRole);
                    int r = cm.ExecuteNonQuery();
                    con.Close();
                    return r;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int update(Hraccount ac)
        {
            try
            {
                if (isIDExisted(ac.Email))
                {
                    SqlConnection con = dBContext.SqlConnection;
                    con.Open();
                    SqlCommand cm = new SqlCommand("UPDATE HRAccount SET Password = @password, FullName = @fullname, MemberRole = @memberRole"
                        + " WHERE Email = @email", con);
                    cm.Parameters.AddWithValue("@email", ac.Email);
                    cm.Parameters.AddWithValue("@password", ac.Password);
                    cm.Parameters.AddWithValue("@fullname", ac.FullName);
                    cm.Parameters.AddWithValue("@memberRole", ac.MemberRole);

                    int r = cm.ExecuteNonQuery();
                    con.Close();
                    return r;
                }
                else return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int remove(string email)
        {
            try
            {
                SqlConnection con = dBContext.SqlConnection;
                con.Open();
                SqlCommand cm = new SqlCommand("Delete FROM HRAccount WHERE Email = @email", con);
                cm.Parameters.AddWithValue("@email", email);
                int r = cm.ExecuteNonQuery();
                con.Close();
                return r;
            }

            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}