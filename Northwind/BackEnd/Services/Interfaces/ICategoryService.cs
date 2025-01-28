using Entities.Entities;

namespace BackEnd.Services.Interfaces
{
    public interface ICategoryService
    {
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleyeCategory(int id);
        List<Category> GetCategories();
    }
}
