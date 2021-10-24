using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using winelegend.models;
using winelegend.service.Models;
using winelegend.service.services;

namespace winelegend.service.Repositary
{
    public class SubCategoryRepositary : ISubCategoryService
    {
        private readonly WineLegendContext _dbContext;
        public SubCategoryRepositary()
        {
            this._dbContext = new WineLegendContext();
        }
        public void CreateSubCategory(SubCategory subcategory)
        {
            if(subcategory!=null)
            {
                _dbContext.SubCategories.Add(subcategory);
                _dbContext.SaveChanges();
            }
        }

        public void DeleteSubCategory(Guid id)
        {
            if(id!=null)
            {
                var _subcategory = _dbContext.SubCategories.Find(id);
                if(_subcategory!=null)
                {
                    _dbContext.SubCategories.Remove(_subcategory);
                    _dbContext.SaveChanges();
                }
            }
        }

        public List<SubCategory> GetAllSubCategories()
        {
            var subcategories = _dbContext.SubCategories.ToList();
            return subcategories.ToList();
        }

        public SubCategory GetSubCategoryById(Guid id)
        {
            var _subcategory = _dbContext.SubCategories.Where(x => x.SubCategoryId == id).SingleOrDefault();
            return _subcategory;
        }

        public void UpdateSubCategory(Guid id, SubCategory subcategory)
        {
            SubCategory subCategory = _dbContext.SubCategories.Where(x => x.SubCategoryId == id).SingleOrDefault();
            if(subCategory!=null)
            {
                subCategory.SubCategoryName = subcategory.SubCategoryName;
                subCategory.Description = subcategory.Description;
                subCategory.ModifiedBy = "supritha";
                subCategory.ModifiedOn = DateTime.Now;
            }
            _dbContext.SaveChanges();
        }
    }
}