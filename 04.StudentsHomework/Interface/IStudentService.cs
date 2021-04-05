using _04.StudentsHomework.Models.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04.StudentsHomework.Interface
{
     public interface IStudentService
    {
        IList<StudentViewModel> GetStudents(string firstName, string lastName);

        StudentViewModel GetStudent(int studentNumber);
        

        
    }
}
