using System;
using System.Collections.Generic;
using System.Text;

namespace FoodData
{
    public class SqlCategoryRepository : ICategoryRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlCategoryRepository(String connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public void SaveCategory(int categoryId, string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            var d = new 
        }
    }
}
