using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternshipTest.Person;

namespace InternshipTest.Person
{
    //Інтерфейс вводу виводу даних класу Student
    public interface IStudentIO
    {
        //Метод інтерфейсу який зберігає дані
        bool Save(List<Student> students, object config);

        //Метод інтерфейсу який загружає дані в програму
        List<Student> Open(object config);
    }
}
