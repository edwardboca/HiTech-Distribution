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
    public class AuthorDB
    {
        public static List<Author> GetRecordList()
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            List<Author> listAuthor = new List<Author>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Authors", connDB);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Author aut = new Author();// create the object here, not outside
                    aut.AuthorId = Convert.ToInt32(reader["AuthorId"]);
                    aut.FirstName= (reader["FirstName"]).ToString();
                    aut.LastName= (reader["LastName"]).ToString();
                    aut.Email= (reader["Email"]).ToString();

                    listAuthor.Add(aut);
                }
            }
            else
            {
                listAuthor = null;
            }

            return listAuthor;
        }
    }
}
