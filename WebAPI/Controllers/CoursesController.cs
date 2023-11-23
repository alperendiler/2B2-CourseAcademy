using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesController : Controller
    {
        ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {   
            var result = _courseService.GetAll();
            if(result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest();
        }
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var result = _courseService.GetById(id);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest();
        }
        [HttpPost("add")]

        public ActionResult Add(Course course)
        {
            var result = _courseService.Add(course);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]

        public ActionResult Update(Course course)
        {
            var result = _courseService.Update(course);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]

        public ActionResult Delete(Course course)
        {
            var result = _courseService.Delete(course);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
