using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using winelegend.models;
using winelegend.service.Models;
using winelegend.service.services;

namespace winelegend.service.Repositary
{
    public class CategoryRepositary: ICategoryService
    {
        private readonly WineLegendContext _dbContext;
        public CategoryRepositary()
        {
            this._dbContext = new WineLegendContext();
        }
        public void CreateCategory(Category category)
        {
            if(category!=null)
            {
                _dbContext.Categories.Add(category);
                _dbContext.SaveChanges();
            }
        }

        public void DeleteCategory(Guid id)
        {
            if(id!=null)
            {
                var category = _dbContext.Categories.Find(id);
                if(category!=null)
                {
                    _dbContext.Categories.Remove(category);
                }
                _dbContext.SaveChanges();
            }
        }

        public List<Category> GetAllCategories()
        {
            List<Category> category = _dbContext.Categories.ToList();
            return category.ToList();
        }

        public Category  GetCategoryId(Guid id)
        {
            var _category = _dbContext.Categories.Where(x => x.CategoryId == id).SingleOrDefault();
            return _category;
        }

        public void UpdateCategory(Guid id, Category category)
        {
            Category categories = _dbContext.Categories.Where(x => x.CategoryId == id).SingleOrDefault();
             if(categories!=null)
            {
                categories.CategoryName= category.CategoryName;
                categories.Description = category.Description;
                categories.ModifiedBy = "supritha";
                categories.ModifiedOn = DateTime.Now;

            }
            _dbContext.SaveChanges();
        }
    }
}