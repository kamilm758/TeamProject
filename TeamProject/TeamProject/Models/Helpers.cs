using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Threading.Tasks;
using System.Web;

 
namespace TeamProject.Models
{
    public class Helpers        
    {
        public static string GetRDSConnectionString()
        {
            

            string dbname = "postgres";

            if (string.IsNullOrEmpty(dbname)) return null;

            string username = "postgres";
            string password = "projekt.pb19_20";
            string hostname = "projekt1920.cakejnzadj5u.us-east-1.rds.amazonaws.com";
            string port = "5432";

            return "Data Source=" + hostname + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";";
        }
    }
}
