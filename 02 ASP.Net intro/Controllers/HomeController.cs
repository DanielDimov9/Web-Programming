using _02_ASP.Net_intro.Models;
using _02_ASP.Net_intro.Models.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _02_ASP.Net_intro.Controllers
{
    public class HomeController : Controller
    {
       
      

        public IActionResult Index()
        {
            return View();
        }


        [Route("/Students/")]
        public IActionResult Students()
        {
            
            StudentViewModel studentsViewModel = new StudentViewModel();

            studentsViewModel.Class = "Web Develompment";

            studentsViewModel.Students.Add(new Student
            {
                FirstName = "John",
                LastName = "Wick",
                StudentNumber = "1"
            });
            studentsViewModel.Students.Add(new Student
            {
                FirstName = "Jane",
                LastName = "Smith",
                StudentNumber = "2"
            });
            studentsViewModel.Students.Add(new Student
            {
                FirstName = "Johny",
                LastName = "Silverhand",
                StudentNumber = "3"
            });

            return View(studentsViewModel);
        }
    }
}
