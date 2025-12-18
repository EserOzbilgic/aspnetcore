namespace basics.Models 
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();

        static Repository()
        {
            _courses = new List<Course>
            {
            new Course() { Id = 1, Title = "ASP.NET Core MVC", Description = "Learn the basics of ASP.NET Core MVC framework.", Image="1.jpg" },
            new Course() { Id = 2, Title = "Entity Framework Core", Description = "Introduction to Entity Framework Core for data access.", Image="4.jpg" },
            new Course() { Id = 3, Title = "Razor Pages", Description = "Build dynamic web pages using Razor syntax.", Image="3.jpg" },
            new Course() { Id = 4, Title = "Blazor", Description = "Build interactive web UIs using Blazor.", Image="1.jpg" },
            };
        }

        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }

    }
}