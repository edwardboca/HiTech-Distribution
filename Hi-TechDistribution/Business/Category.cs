using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_TechDistribution.DataAccess;


namespace Hi_TechDistribution.Business
{
    public class Category
    {
        private int categoryId;
        private string categoryName;

        public int CategoryId { get => categoryId; set => categoryId = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }

        public List<Category> GetCategoriesList()
        {
            return (CategoryDB.GetCategoryList());
        }
    
    }
}
