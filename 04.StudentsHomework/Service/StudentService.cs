using _04.StudentsHomework.Interface;
using _04.StudentsHomework.Models.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04.StudentsHomework.Service
{
    public class StudentService : IStudentService
    {
        private IList<StudentViewModel> studentList = new List<StudentViewModel>
        {
            new StudentViewModel() { StudentNumber = 1, FirstName = "John", LastName = "Jones" },
            new StudentViewModel() { StudentNumber = 2, FirstName = "Kiril", LastName = "Gordon" },
            new StudentViewModel() { StudentNumber = 3, FirstName = "Bill", LastName = "Gates" },
            new StudentViewModel() { StudentNumber = 4, FirstName = "Ram", LastName = "Murphy" },
            new StudentViewModel() { StudentNumber = 5, FirstName = "Ron", LastName = "Sullivan" },
            new StudentViewModel() { StudentNumber = 6, FirstName = "Chris", LastName = "Norris" },
            new StudentViewModel() { StudentNumber = 7, FirstName = "Rob", LastName = "Roy" }
        };
        public IList<StudentViewModel> GetStudents(string firstName,string lastName)
        {
            return studentList
               .Where(s => (s.FirstName == firstName || firstName == null)
                   && ((s.LastName == lastName || lastName == null)))
               .ToList();
        }

        public StudentViewModel GetStudent(int studentNumber)
        {
            return studentList.Where(s => s.StudentNumber == studentNumber).FirstOrDefault();
        }
    }
}
