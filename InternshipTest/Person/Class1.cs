using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternshipTest.Person;

namespace InternshipTest.Person
{
    public class Class1 : IStudentManufacturer
    {
        List<Student> IStudentManufacturer.GetStudents()
        {
            throw new NotImplementedException();
        }
    }
}
