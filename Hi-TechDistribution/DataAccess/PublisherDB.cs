using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Hi_TechDistribution.Business;
using System.Data;

namespace Hi_TechDistribution.DataAccess
{
    public class PublisherDB
    {
        public static List<Publisher> GetPublisherList()
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            List<Publisher> listPublisher = new List<Publisher>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Publishers", connDB);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                Publisher pub;
                while (reader.Read())
                {
                    pub = new Publisher();
                    pub.PublisherId = Convert.ToInt32(reader["PublisherId"]);
                    pub.PublisherName = (reader["PublisherName"]).ToString();
                    listPublisher.Add(pub);
                }
            }
            else
            {
                listPublisher = null;
            }
            return listPublisher;
        }
    }
}
