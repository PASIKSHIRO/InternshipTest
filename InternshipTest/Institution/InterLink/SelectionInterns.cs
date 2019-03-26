using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution.InterLink
{
    public static class SelectionInterns
    {
        public static List<Student> ChoiceInterns(University university)
        {
            var interns = new List<Student>();
            foreach (var student in university.students)
                if (student.knowledge.level > university.avgLevel)
                    interns.Add(student);
            return interns;
        }
    }
}
