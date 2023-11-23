using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseService
    {
		IDataResult<List<Course>> GetAll();
		IDataResult<List<Course>> GetByCategoryId(int categoryId);
		IDataResult<List<CourseDetailDto>> GetByCourseDetails();
		IDataResult<Course> GetById(int courseId);
		IDataResult<Course> Get(int courseId);
		IResult Add(Course course);
		IResult Update(Course course);
		IResult Delete(Course course);
    }
}
