using Application.Interfaces;
using AutoMapper;
using Domain.DTOs;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Services
{
    public class CategoryService: ICategoryService
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public CategoryService(DataContext dataContext, IMapper mapper)
        {
            _mapper = mapper;
            _dataContext = dataContext;
        }
        public async Task<IEnumerable<CategoryReadDTO>> GetAllCategories()
        {
            var categories = await _dataContext.Categories.ToListAsync();
            var readCategories = _mapper.Map<IEnumerable<CategoryReadDTO>>(categories);
            if (readCategories == null)
            {
                throw new InvalidOperationException();
            }
            return readCategories;
        }

        public async Task<CategoryReadDTO> GetCategoryById(int id)
        {
            var category = await _dataContext.Categories.Where(c => c.CategoryID == id).FirstOrDefaultAsync();
            var readCategory = _mapper.Map<CategoryReadDTO>(category);
            if (readCategory == null)
            {
                throw new InvalidOperationException();
            }
            return readCategory;

        }

        public async Task<CategorySubmitDTO> CreateCategory(CategorySubmitDTO category)
        {
            if (category == null)
            {
                throw new InvalidOperationException();
            }
            var submitCategory = _mapper.Map<Category>(category);
            _dataContext.Categories.Add(submitCategory);
            await _dataContext.SaveChangesAsync();

            return category;
        }
    }
}
