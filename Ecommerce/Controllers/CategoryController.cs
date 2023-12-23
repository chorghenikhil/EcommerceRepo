using EcommerceDAL.Models;
using EcommerceService.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    [ApiController]
    [Route("v1/Ecommerce")]
    public class CategoryController : ControllerBase
    {
      
        private readonly ILogger<CategoryController> _logger;

        private readonly ICategoryService _categoryService;

        public CategoryController(ILogger<CategoryController> logger, ICategoryService categoryService)
        {
            _logger = logger;
            _categoryService = categoryService;

        }

        //get

        //add/update

        //delete



        [HttpGet]
        [Route("GetCategory")]
        public async Task<IEnumerable<Category>> Get()
        {
            return await _categoryService.GetCategories();
        }


        [HttpPost]
        [Route("AddCategory")]
        public async Task<bool> Post([FromBody] Category category)
        {
            return await _categoryService.AddCategories(category);
        }

        [HttpPost]
        [Route("UpdateCategory")]
        public async Task<bool> Update([FromBody] Category category)
        {
            return await _categoryService.UpdateCategory(category);
        }

        [HttpPost]
        [Route("DeleteCategory")]
        public async Task<bool> Delete([FromBody] Category category)
        {
            return await _categoryService.DeletCategory(category);
        }

    }
}
