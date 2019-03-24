using InternshipTest.Person;
using InternshipTest.Institution;
using System.Collections.Generic;

namespace InternshipTest.Institution
{
    //Клас університет
    public class University
    {
        public string name = null;
        public List<Student> students = new List<Student>();

        public University(string name)
        {
            this.name = name;
        }
        //Додавання студентів
        public void AddStudent(Student student)
        {   
            this.students.Add(student);
        }
    }
}
