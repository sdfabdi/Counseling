using Application.Interfaces;
using Domain.DTOs;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController( ICategoryService categoryService)
        {
            
            _categoryService = categoryService;
        }

        // GET: api/Category/GetAllCategories
        [HttpGet("GetAllCategories")]
        public async Task<ActionResult<IEnumerable<Category>>> GetAllCategories()
        {
            try
            {
                var categories = await _categoryService.GetAllCategories();
                return Ok(categories);
            }
            catch (InvalidOperationException)
            {
                return NotFound("Record Not Found");
            }
        }

        // GET: api/Category/GetCategoryById/2
        [HttpGet("GetCategoryById/{id}")]
        public async Task<ActionResult<Category>> GetCategoryById(int id)
        {
            try
            {
                var category = await _categoryService.GetCategoryById(id);
                return Ok(category);
            }
            catch (InvalidOperationException)
            {
                return NotFound("Record Not Found");
            }
        }

        // POST: api/Category/CreateCategory
        [HttpPost("CreateCategory")]
        public async Task<ActionResult<CategorySubmitDTO>> CreateCategory([FromBody] CategorySubmitDTO category)
        {
            try
            {
                var cat = await _categoryService.CreateCategory(category);
                return Ok(cat);
            }
            catch (InvalidOperationException)
            {
                return BadRequest("Cannot Create a Category");
            }
        }
    }
}
