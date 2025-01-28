using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementaciones
{
    public class CategoryService : ICategoryService
    {
        private ICategoryDAL _categoryDAL;

        public CategoryService(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }
        public void AddCategory(Category category)
        {
            _categoryDAL.AddCategory(category);
        }

        public void DeleyeCategory(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategories()
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
