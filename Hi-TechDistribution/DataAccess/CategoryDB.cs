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
    public class CategoryDB
    {
        public static List<Category> GetCategoryList()
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            List<Category> listCategory = new List<Category>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Categories", connDB);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                Category cat;
                while (reader.Read())
                {
                    cat = new Category();
                    cat.CategoryId = Convert.ToInt32((reader["CategoryId"]));
                    cat.CategoryName = (reader["CategoryName"]).ToString();
                    listCategory.Add(cat);
                }
            }
            else
            {
                listCategory = null;
            }
            return listCategory;
        }
        
        
    }
}
