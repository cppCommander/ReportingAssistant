using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DataLayer;
using Company.DomainModels;
using Company.RepositoryContracts;

namespace Company.RespositoryLayer
{
    public class CategoryRepository : ICategoryRepository
    {
        CompanyDbContext db;

        public CategoryRepository()
        {
            this.db = new CompanyDbContext();
        }
        public void AddCategory(Category c)
        {
            db.Categories.Add(c);
            db.SaveChanges();
        }

        public void DeleteCategory(long id)
        {
            Category existingCategory = db.Categories.Where(temp => temp.CategoryID == id).FirstOrDefault();
            db.Categories.Remove(existingCategory);
            db.SaveChanges();
        }

        public void EditCategory(Category c)
        {
            Category category = db.Categories.Where(temp => temp.CategoryID == c.CategoryID).FirstOrDefault();
            if (category != null)
            {
                category.CategoryName= c.CategoryName;
                db.SaveChanges();
            }
        }

        public List<Category> GetCategories()
        {
            List<Category> categories = db.Categories.ToList();
            return categories;
        }

        public List<Category> GetCategoriesCategoryNameContains(string contains)
        {
            List<Category> categories = db.Categories.Where(temp => temp.CategoryName.Contains(contains)).ToList();
            return categories;
        }

        public Category GetCategoryById(long categoryId)
        {
            Category category = db.Categories.Where(temp => temp.CategoryID == categoryId).SingleOrDefault();
            return category;
        }
    }
}
