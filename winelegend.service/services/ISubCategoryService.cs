using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winelegend.models;

namespace winelegend.service.services
{
    public interface ISubCategoryService
    {
        void CreateSubCategory(SubCategory subcategory);
        List<SubCategory> GetAllSubCategories();
        SubCategory GetSubCategoryById(Guid id);
        void UpdateSubCategory(Guid id, SubCategory subcategory);
        void DeleteSubCategory(Guid id);


    }
}
