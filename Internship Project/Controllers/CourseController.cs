using Microsoft.AspNetCore.Mvc;
using Internship_Project.Models;
namespace Internship_Project.Controllers
{
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CourseController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var courses = _context.Courses.ToList();
            return View(courses);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Course course)
        {
            if(ModelState.IsValid)
            {
                _context.Courses.Add(course);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var error in ModelState.Values.SelectMany(v=>v.Errors))
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            return View(course);
        }

        //public IActionResult Edit(int id)
        //{
        //    int course=_
        //}
    }
}
