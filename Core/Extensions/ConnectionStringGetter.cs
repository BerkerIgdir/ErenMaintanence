using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Core.Extensions
{
    public static class ConnectionStringGetter
    {
        private static string FilePath = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) }\\{Application.CompanyName}\\Connection.dat";

        public static string Get()
        {

            if (File.Exists(FilePath))
            {
                return File.ReadAllText(FilePath);
            }
            return null;
        }

        public static void Set(string ConnectionString)
        {
            if(!Directory.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) }\\{Application.CompanyName}"))
            {
                Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) }\\{Application.CompanyName}");


            }

            File.WriteAllText(FilePath,ConnectionString);

        }
        public static bool Check(string connectionString = null)
        {
            SqlConnectionStringBuilder ConnectionStringBuilder = new SqlConnectionStringBuilder(connectionString??Get());
            ConnectionStringBuilder.InitialCatalog = "master";
            using (SqlConnection Connection = new SqlConnection(ConnectionStringBuilder.ConnectionString))
            {
                try
                {
                    Connection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

    }
}
