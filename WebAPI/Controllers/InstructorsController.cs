using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InstructorsController : Controller
    {
        IInstructorService _instructorService;
        public InstructorsController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _instructorService.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest();
        }
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var result = _instructorService.GetByInstructorId(id);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest();
        }
        [HttpPost("add")]

        public ActionResult Add(Instructor ınstructor)
        {
            var result = _instructorService.Add(ınstructor);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]

        public ActionResult Update(Instructor ınstructor)
        {
            var result = _instructorService.Update(ınstructor);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]

        public ActionResult Delete(Instructor ınstructor)
        {
            var result = _instructorService.Delete(ınstructor);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
