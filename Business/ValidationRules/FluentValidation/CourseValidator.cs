using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
	public class CourseValidator : AbstractValidator<Course>
	{
		public CourseValidator()
		{
			RuleFor(p => p.CourseName).NotEmpty();
			RuleFor(p => p.CourseName).MinimumLength(2);
			RuleFor(p => p.Price).GreaterThan(0);
			RuleFor(p => p.Price).GreaterThanOrEqualTo(1).When(p => p.CategoryId == 2);
			RuleFor(p => p.CourseName).Must(StartWithA);
		}

		private bool StartWithA(string arg)
		{
			return arg.StartsWith("A") || arg.StartsWith('a');
		}
	}
}
