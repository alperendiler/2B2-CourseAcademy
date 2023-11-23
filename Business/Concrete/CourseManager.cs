using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
		public IDataResult<List<Course>> GetAll()
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(), Messages.CourseListed); 
        }

        public IDataResult<List<CourseDetailDto>> GetByCourseDetails()
        {
            return new SuccessDataResult<List<CourseDetailDto>>(_courseDal.GetCourseDetails(), Messages.DetailsListed);
        }
		public IDataResult<List<Course>> GetByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(c => c.CategoryId == categoryId));
        }

		public IDataResult<Course> GetById(int courseId)
		{
			return new SuccessDataResult<Course>(_courseDal.Get(c => c.CourseId == courseId));
		}

		public IDataResult<Course> Get(int courseId)
		{
			return new SuccessDataResult<Course>(_courseDal.Get(c => c.CourseId == courseId));
		}

		[ValidationAspect(typeof(CourseValidator))]
		public IResult Add(Course course)
		{
			_courseDal.Add(course);
			return new SuccessResult(Messages.CourseAdded);
		}

		public IResult Update(Course course)
		{
			_courseDal.Update(course);
			return new SuccessResult(Messages.CourseUpdated);
		}

		public IResult Delete(Course course)
		{
			_courseDal.Delete(course);
			return new SuccessResult(Messages.CourseDeleted);
		}
	}
}
