using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_ASP.Net_intro.Models.Home
{
    public class StudentViewModel
    {
        public StudentViewModel()
        {
            Students = new List<Student>();
        }

        public string Class { get; set; }
        public List<Student> Students { get; set; }
        
    }
}
