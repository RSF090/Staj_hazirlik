using basics.Models;
using Microsoft.AspNetCore.Mvc;


namespace basics.Controllers;

    public class CourseController : Controller
    {
            public IActionResult Index()
            {
        var kurs = new Course
        {
            Id = 1,
            Title = "Resim",
            Description = "Resim Çizimi",

        };
        

        return View(kurs);
            }
             public IActionResult Details()
            {
        var kurs = new Course
        {
            Id = 1,
            Title = "Resim",
            Description = "Güzel bir plaj resim",
            ImageUrl = "1.jpg",
        };
        

        return View(kurs);
            }
      public IActionResult List()
        {
            return View("CourseList",Repository.Courses);
        }

        }

