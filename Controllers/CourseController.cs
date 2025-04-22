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
            var kurslar = new List<Course>
            {
                new Course() { Id = 1, Title = "Plaj Resmi", Description = "Günbatımında Plaj Resmi", ImageUrl = "1.jpg" },
                new Course() { Id = 2, Title = "Göl Resmi", Description = "Bir gölün Fotoğrafı", ImageUrl = "2.jpg" },
                new Course() { Id = 3, Title = "Yıldızlı Bir Gece", Description = "Da Vinchi'nin tablosu", ImageUrl = "3.jpg" },
            };
            return View("CourseList", kurslar);
        }

        }

