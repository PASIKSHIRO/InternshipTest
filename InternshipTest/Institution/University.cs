using InternshipTest.Person;
using InternshipTest.Institution;
using System.Collections.Generic;

namespace InternshipTest.Institution
{
    public class University
    {
        public string name = null;
        public float avgLevel = 0;
        public List<Student> students = new List<Student>();

        public University(string name)
        {
            this.name = name;
        }
        public void AddStudent(Student student)
        {
            this.students.Add(student);
           
            avgLevel = 0; 
            foreach (var st in students)
                avgLevel += st.knowledge.level;
            avgLevel /= this.students.Count;
        }
    }
}
