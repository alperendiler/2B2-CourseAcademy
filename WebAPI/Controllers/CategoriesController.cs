using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("getall")]

        public ActionResult GetAll()
        {
            var result = _categoryService.GetAll();
            if(result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpGet("id")]

        public ActionResult Get(int id)
        {
            var result = _categoryService.GetByCategoryId(id);
            if(result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]

        public ActionResult Add(Category category)
        {
            var result = _categoryService.Add(category);
            if(result.IsSuccess )
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]

        public ActionResult Update(Category category)
        {
            var result = _categoryService.Update(category);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]

        public ActionResult Delete(Category category)
        {
            var result = _categoryService.Delete(category);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
