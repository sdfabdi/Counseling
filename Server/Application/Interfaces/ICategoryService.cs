using Domain.DTOs;
using Domain.Model;

namespace Application.Interfaces
{
    public interface ICategoryService
    {
        public Task<IEnumerable<CategoryReadDTO>> GetAllCategories();
        public Task<CategoryReadDTO> GetCategoryById(int id);
        public Task<CategorySubmitDTO> CreateCategory(CategorySubmitDTO category);
    }
}
