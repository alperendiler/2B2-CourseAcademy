using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
internal class Program
{
    private static void Main(string[] args)
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        Category category = new Category { CategoryName = "Frontend" };
        Console.WriteLine(categoryManager.Add(category).Message);
        Console.WriteLine(categoryManager.Update(category).Message);
        Console.WriteLine(categoryManager.Delete(category).Message);
        Console.WriteLine(categoryManager.Get(105).Data.CategoryName);
        Console.WriteLine(categoryManager.GetByCategoryId(1).Data.CategoryName);
        
        InstructorManager instructorManager = new InstructorManager(new EfInstructorDal());
        Instructor instructor = new Instructor { InstructorName = "Tolga", InstructorSurname = "Kayış", CategoryId = 1 };
        Console.WriteLine(instructorManager.Add(instructor).Message);
		Console.WriteLine(instructorManager.Update(instructor).Message);
		Console.WriteLine(instructorManager.Delete(instructor).Message);
		Console.WriteLine(instructorManager.Get(2).Data.InstructorName);
        Console.WriteLine(instructorManager.GetByInstructorId(1).Data.InstructorSurname);

        CourseManager courseManager = new CourseManager(new EfCourseDal());
        Course course = new Course { CategoryId = 1, CourseName = "Java", Price = 99 };
        Console.WriteLine(courseManager.Add(course).Message);
		Console.WriteLine(courseManager.Update(course).Message);
		Console.WriteLine(courseManager.Delete(course).Message);
		Console.WriteLine(courseManager.Get(2).Data.CourseName);
        Console.WriteLine(courseManager.GetById(1).Data.CourseName);
        foreach (var c in courseManager.GetByCategoryId(3).Data)
        {
            Console.WriteLine(c.CourseName);
        }
    }
}