using System.Collections.Generic;

namespace basics.Models
{
    public class Repository
    {
        private static List<Course> _courses;

  
        static Repository()
        {
            _courses = new List<Course>()
            {
                new Course() { Id = 1, Title = "Plaj Resmi", Description = "Günbatımında Plaj Resmi", ImageUrl = "1.jpg" },
                new Course() { Id = 2, Title = "Göl Resmi", Description = "Bir gölün Fotoğrafı", ImageUrl = "2.jpg" },
                new Course() { Id = 3, Title = "Yıldızlı Bir Gece", Description = "Da Vinci'nin tablosu", ImageUrl = "3.jpg" }
            };
        }

    
        public static List<Course> Courses
        {
            get { return _courses; }
        }
    }
}
