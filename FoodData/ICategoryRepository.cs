using System;
using System.Collections.Generic;
using FoodData.Model;

namespace FoodData
{
    public interface ICategoryRepository
    {
        IReadOnlyList<Category> RetrieveCategories();

        Category FetchCategory(int CategoryID, string CategoryName);

        Category GetCategory(string name);

        Category CreateCategory(int categoryID, string name);
    }
}
