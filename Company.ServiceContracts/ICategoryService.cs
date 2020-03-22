using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DomainModels;

namespace Company.ServiceContracts
{
    public interface ICategoryService
    {
        void AddCategory(Category c);
        void EditCategory(Category c);

        List<Category> GetCategories();

        List<Category> GetCategoriesCategoryNameContains(string contains);

        Category GetCategoryById(long categoryId);

        void DeleteCategory(long id);
    }
}
