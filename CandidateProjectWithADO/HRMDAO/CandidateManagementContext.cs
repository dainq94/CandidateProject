using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HRMDAO
{
    public partial class CandidateManagementContext
    {
        private static CandidateManagementContext instance = null;
        private SqlConnection sqlConnection;
        public CandidateManagementContext()
        {
            sqlConnection = new SqlConnection(GetConnectionString());

        }
        public static CandidateManagementContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CandidateManagementContext();
                }
                return instance;
            }
        }
        protected string GetConnectionString()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            IConfiguration configuration = builder.Build();
            return configuration.GetConnectionString("DBConnection");
        }
        public SqlConnection SqlConnection { get => sqlConnection; }

    }
}
