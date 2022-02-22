using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classification
{
    public class SqlRepository
    {
        private List<Student> DumpStudents()
        {
            List<Student> students = new List<Student>();
            var student = new Student()
            {
                Id = 1,
                Firstname = "Luboš",
                Lastname = "Štístko",
                Birthdate = DateTime.Parse("1.1.2000"),
                Grades = new List<Grade>()
            };
            return students;
        }
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            return students;
        }
    }
}
