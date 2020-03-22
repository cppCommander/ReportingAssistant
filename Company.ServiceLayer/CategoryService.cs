using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DomainModels;
using Company.RepositoryContracts;
using Company.RespositoryLayer;
using Company.ServiceContracts;

namespace Company.ServiceLayer
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository r)
        {
            this.categoryRepository = r;
        }

        public void AddCategory(Category c)
        {
            categoryRepository.AddCategory(c);
        }

        public void DeleteCategory(long id)
        {
            categoryRepository.DeleteCategory(id);
        }

        public void EditCategory(Category c)
        {
            categoryRepository.EditCategory(c);
        }

        public List<Category> GetCategories()
        {
            List<Category> categories = categoryRepository.GetCategories();
            return categories;
        }

        public List<Category> GetCategoriesCategoryNameContains(string contains)
        {
            List<Category> categories = categoryRepository.GetCategoriesCategoryNameContains(contains);
            return categories;
        }

        public Category GetCategoryById(long categoryId)
        {
            Category category = categoryRepository.GetCategoryById(categoryId);
            return category;
        }

    }
}
