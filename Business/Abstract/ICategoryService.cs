﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
		IDataResult<List<Category>> GetAll();
		IDataResult<Category> GetByCategoryId(int categoryId);
		IDataResult<Category> Get(int id);
		IResult Add(Category category);
		IResult Update(Category category);
		IResult Delete(Category category);
	}
}
