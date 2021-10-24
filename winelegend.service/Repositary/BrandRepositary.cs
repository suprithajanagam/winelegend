using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using winelegend.models;
using winelegend.service.Models;
using winelegend.service.services;

namespace winelegend.service.Repositary
{
    public class BrandRepositary : IBrandService
    {
        private readonly WineLegendContext _dbContext;
        public BrandRepositary()
        {
            this._dbContext = new WineLegendContext();
        }
        public void CreateBrand(Brand brand)
        {
            if(brand!=null)
            {
                _dbContext.Brands.Add(brand);
                _dbContext.SaveChanges();
            }
        }

        public void DeletBrand(Guid id)
        {
            if(id!=null)
            {
                var _brand = _dbContext.Brands.Find(id);
                if(id!=null)
                {
                    _dbContext.Brands.Remove(_brand);
                    _dbContext.SaveChanges();
                }
            }
        }

        public List<Brand> GetAllBrands()
        {
            var brands = _dbContext.Brands.ToList();
            return brands.ToList();
        }

        public Brand GetBrandById(Guid id)
        {
            var brand = _dbContext.Brands.Where(x => x.BrandId == id).SingleOrDefault();
            return brand;
        }

        public void UpdateBrand(Guid id, Brand brand)
        {
            Brand _brand = _dbContext.Brands.Where(x => x.BrandId == id).SingleOrDefault();
            if(_brand!=null)
            {
                _brand.BrandName = brand.BrandName;
                _brand.Description = brand.Description;
                _brand.ModifiedBy = "supritha";
                _brand.ModifiedOn = DateTime.Now;
            }
            _dbContext.SaveChanges();
        }
    }
}