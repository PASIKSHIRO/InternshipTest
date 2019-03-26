using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        public string name;

        public List<Student> Interns = new List<Student>();

        public Internship(string name)
        {
            this.name = name;
        }

        public List<Student> GetInterns()
        {
            return this.Interns;
        }
        
        public void AddInternLinst(List<Student> InternLinst)
        {
            Interns.AddRange(InternLinst);
        }
    }
}
