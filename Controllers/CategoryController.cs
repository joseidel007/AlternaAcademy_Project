using alterna_academy_project.Data;
using alterna_academy_project.Models;
using alterna_academy_project.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace alterna_academy_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ApplicationDbContext _db;

        public CategoryController(ILogger<CategoryController> logger, ApplicationDbContext db)
        {
            _db = db;
            _logger = logger;
        }


        //Get All Categories
        [HttpGet]
        public ActionResult<IEnumerable<CategoryDto>> GetCategories()
        {
            return Ok(_db.Categories.ToList());

        }

        //Get Category ById

        [HttpGet]
        [Route("{id}")]
/*        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]*/
        public ActionResult<CategoryDto> GetCategoryById(int id)
        {
            if (id == 0)
            {
                _logger.LogError("Error with CategoryId " + id);
                return BadRequest();
            }

            var category = _db.Categories.FirstOrDefault(c => c.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }


        [HttpPost]
        //[Route("AddCategory")]
        public async Task<ActionResult<Category>> AddCategory(Category category)
        {
            _db.Categories.Add(category);
            await _db.SaveChangesAsync();
            return Ok();

        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> DeleteCategory(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }

            var category = _db.Categories.First(c => c.Id == id);

            if(category == null)
            {
                return NotFound();
            }
            _db.Remove(category);
            await _db.SaveChangesAsync();
            return Ok();
        }


    }
}
