using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using FoodData.Model;
using FoodData.DataDelegates;

namespace FoodData
{
    public class SqlCategoryRepository : ICategoryRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlCategoryRepository(String connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public List<Category> CreateCategory(int CategoryID, string CategoryName)
        {
            if(string.IsNullOrWhiteSpace(CategoryName))
                throw new ArgumentException("The parameter cannot be null or empty. ", nameof(CategoryName));
            
            var d = new CreateCategoryDataDelegate(CategoryID, CategoryName);
            return null; // executor.ExecuteNonQuery(d);//delegate done figure out return
        }

        public Category FetchCategory(int CategoryId, string CategoryName)
        {
            var d = new FetchCategoryDataDelegate(CategoryId, CategoryName);//delegate done
            return executor.ExecuteReader(d);
        }

        public Category GetCategory(string categoryName)
        {
            var d = new GetCategoryDataDelegate(categoryName);//delegate done
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Category> RetrieveCategories()
        {
            return executor.ExecuteReader(new RetrieveCategoryDataDelegate());
        }
    }
}
