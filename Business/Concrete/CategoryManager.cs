using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

		public IResult Add(Category category)
		{
			// Business Codes
			_categoryDal.Add(category);
			return new SuccessResult(Messages.CategoryAdded);
		}

		public IResult Delete(Category category)
		{
			_categoryDal.Delete(category);
			return new SuccessResult(Messages.CategoryDeleted);
		}

		public IDataResult<Category> Get(int id)
		{
			return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == id));
		}

		public IDataResult<List<Category>> GetAll()
        {
           return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }
        public IDataResult<Category> GetByCategoryId(int id)
        {
           return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == id));
        }

		public IResult Update(Category category)
		{
			_categoryDal.Update(category);
			return new SuccessResult(Messages.CategoryUpdated);
		}
	}
}
