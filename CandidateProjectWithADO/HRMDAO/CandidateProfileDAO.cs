using BusinessObjects.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HRMDAO
{
    public class CandidateProfileDAO
    {
        private static CandidateManagementContext dBContext = null;
        private List<CandidateProfile> listCandi = null;
        public CandidateProfileDAO()
        {
            dBContext = CandidateManagementContext.Instance;
        }

        public List<CandidateProfile> GetAll()
        {
            listCandi = new List<CandidateProfile>();
            try
            {

                SqlConnection con = dBContext.SqlConnection;
                con.Open();
                SqlCommand cm = new SqlCommand("  select * from CandidateProfile", con);
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    CandidateProfile candi = new CandidateProfile();
                    candi.CandidateId = sdr["CandidateID"].ToString();
                    candi.Fullname = sdr["Fullname"].ToString();
                    candi.Birthday = DateTime.Parse(sdr["Birthday"].ToString());
                    candi.ProfileShortDescription = sdr["ProfileShortDescription"].ToString();
                    candi.ProfileUrl = sdr["ProfileURL"].ToString();
                    candi.PostingId = (sdr["PostingID"].ToString());

                    listCandi.Add(candi);
                }
                con.Close();
                return listCandi;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<CandidateProfile> GetCandiBySearch(string keyword)
        {
            List<CandidateProfile> searchList = new List<CandidateProfile>();
            try
            {
                SqlConnection con = dBContext.SqlConnection;

                con.Open();
                SqlCommand cm = new SqlCommand("  select * from CandidateProfile " +
                                                    " WHERE Fullname LIKE @search", con);
                cm.Parameters.AddWithValue("@search", "%" + keyword + "%");

                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {

                    CandidateProfile candi = new CandidateProfile();
                    candi.CandidateId = sdr["CandidateID"].ToString();
                    candi.Fullname = sdr["Fullname"].ToString();
                    candi.Birthday = DateTime.Parse(sdr["Birthday"].ToString());
                    candi.ProfileShortDescription = sdr["ProfileShortDescription"].ToString();
                    candi.ProfileUrl = sdr["ProfileURL"].ToString();
                    candi.PostingId = (sdr["PostingID"].ToString());
                    searchList.Add(candi);
                }
                con.Close();
                return searchList;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public bool isIDExisted(string id)
        {
            try
            {
                SqlConnection con = dBContext.SqlConnection;
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlCommand cm = new SqlCommand("SELECT COUNT(*) FROM CandidateProfile WHERE CandidateID = @id", con);
                cm.Parameters.AddWithValue("@id", id);

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
        public int create(CandidateProfile candi)
        {
            try
            {
                bool idExisted = this.isIDExisted(candi.CandidateId);
                if (idExisted)
                {
                    return 0;
                }
                else
                {
                    SqlConnection con = dBContext.SqlConnection;
                    con.Open();
                    SqlCommand cm = new SqlCommand("INSERT INTO CandidateProfile (CandidateID,Fullname,Birthday,ProfileShortDescription,ProfileURL,PostingID)" +
                        "values(@candidateID,@fullname,@birthday, @profileShortDescription, @profileURL, @postingID)", con);

                    cm.Parameters.AddWithValue("@candidateID", candi.CandidateId);
                    cm.Parameters.AddWithValue("@fullname", candi.Fullname);
                    cm.Parameters.AddWithValue("@birthday", candi.Birthday);
                    cm.Parameters.AddWithValue("@profileShortDescription", candi.ProfileShortDescription);
                    cm.Parameters.AddWithValue("@profileURL", candi.ProfileUrl);
                    cm.Parameters.AddWithValue("@postingID", candi.PostingId);

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

        public int update(CandidateProfile ac)
        {
            try
            {
                if (isIDExisted(ac.CandidateId))
                {
                    SqlConnection con = dBContext.SqlConnection;
                    con.Open();
                    SqlCommand cm = new SqlCommand("UPDATE CandidateProfile SET FullName = @fullname, " +
                        "Birthday = @birthday, ProfileShortDescription = @profileShortDescription, ProfileURL = @profileURL, postingID = @postingID"
                        + " WHERE CandidateID = @id", con);
                    cm.Parameters.AddWithValue("@fullname", ac.Fullname);
                    cm.Parameters.AddWithValue("@birthday", ac.Birthday);
                    cm.Parameters.AddWithValue("@profileShortDescription", ac.ProfileShortDescription);
                    cm.Parameters.AddWithValue("@profileURL", ac.ProfileUrl);
                    cm.Parameters.AddWithValue("@postingID", ac.PostingId);
                    cm.Parameters.AddWithValue("@id", ac.CandidateId);


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
        public int remove(string id)
        {
            try
            {
                SqlConnection con = dBContext.SqlConnection;
                con.Open();
                SqlCommand cm = new SqlCommand("Delete FROM CandidateProfile WHERE CandidateID = @id", con);
                cm.Parameters.AddWithValue("@id", id);
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
