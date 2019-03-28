using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternshipTest.Person;

namespace InternshipTest.Person
{
    //Метод для реалізації додавання студентів через Файл
    public class StudentsFile : IStudentFile
    {
        
        public List<Student> GetStudents()
        {
            var students = new List<Student>();
            return students;
        }
    }

    //Метод для реалізації додавання студентів через Базу Даних
    public class StudentsDatabase : IStudentFile
    {
        public List<Student> GetStudents()
        {
            var students = new List<Student>();
            return students;
        }
    }
}
