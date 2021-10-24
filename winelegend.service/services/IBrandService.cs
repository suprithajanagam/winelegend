using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winelegend.models;

namespace winelegend.service.services
{
    public interface IBrandService
    {
        void CreateBrand(Brand brand);
        List<Brand> GetAllBrands();
        Brand GetBrandById(Guid id);
        void UpdateBrand(Guid id, Brand brand);
        void DeletBrand(Guid id);
    }
}
