using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winelegend.models;

namespace winelegend.service.services
{
   public interface ICategoryService
    {
        void CreateCategory(Category category);
        List<Category> GetAllCategories();
        Category GetCategoryId(Guid id);
        void UpdateCategory(Guid id, Category category);
        void DeleteCategory(Guid id);

    }
}
