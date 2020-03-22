using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DomainModels;

namespace Company.RepositoryContracts
{
    public interface ICategoryRepository
    {
        void AddCategory(Category c);
        void EditCategory(Category c);

        List<Category> GetCategories();

        Category GetCategoryById(long categoryId);

        List<Category> GetCategoriesCategoryNameContains(string contains);

        void DeleteCategory(long id);

        //List<Category> GetCategoryContains(string contains);
    }
}
