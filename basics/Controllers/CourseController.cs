using basics.Models;
using Microsoft.AspNetCore.Mvc;
namespace basics.Controllers;

public class CourseController : Controller
{
    public IActionResult Index()
    {
        var course = new Course();
        course.Id = 1;
        course.Title = "ASP.NET Core MVC";
        course.Description = "Learn the basics of ASP.NET Core MVC framework.";
        course.Image = "1.jpg";
        return View(course);
    }

      public IActionResult List()
    {
        var courses = new List<Course>
        {
            new Course() { Id = 1, Title = "ASP.NET Core MVC", Description = "Learn the basics of ASP.NET Core MVC framework.", Image="1.jpg" },
            new Course() { Id = 2, Title = "Entity Framework Core", Description = "Introduction to Entity Framework Core for data access.", Image="4.jpg" },
            new Course() { Id = 3, Title = "Razor Pages", Description = "Build dynamic web pages using Razor syntax.", Image="3.jpg" },

        };
        return View("CourseList", courses);
    }



}
