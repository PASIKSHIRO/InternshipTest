using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution.InterLink
{
    //Клас Інтернатура
    public class Internship
    {
        public string name;
        public List<University> universities = new List<University>();//Список університетів
        public List<Student> Interns = new List<Student>();//Список студентів(інтернів)

        public Internship(string name)
        {
            this.name = name;
        }

        //Метод знаходження середньої оцінки студентів
        public List<Student> GetStudents()
        {
            foreach (var university in universities)
            {
                float avgLevel = 0;

                foreach (var student in university.students)
                    avgLevel += student.knowledge.level;
                avgLevel /= university.students.Count;

                foreach (var student in university.students)
                    if (student.knowledge.level > avgLevel)
                        this.Interns.Add(student);
            }

            return this.Interns;
        }
        
        //Додавання університету
        public void AddUniversity(University university)
        {
            universities.Add(university);
        }
    }
}
