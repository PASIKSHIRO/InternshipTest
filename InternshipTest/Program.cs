using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            University university = new University("NULP");
            university.AddStudent(new Student("Andrew Kostenko", knowledge: 85));
            university.AddStudent(new Student("Julia Veselkina", knowledge: 72));
            university.AddStudent(new Student("Maria Perechrest", knowledge: 61));
            university.AddStudent(new Student("Ivan Momot", knowledge: 27));
            university.AddStudent(new Student("Nastya Shelm", knowledge: 66));

            Internship internship = new Internship("Interlink");
            internship.AddUniversity(university);//Додавання університету для інтернатури
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|LIST OF INTERNSHIP'S STUDENTS:|");
            Console.WriteLine("+------------------------------+");
            foreach (var student in internship.GetStudents())
            {
                Console.WriteLine("| - {0,-20} {1,3}   |", student.name, student.knowledge.level);
            }
            Console.WriteLine("+------------------------------+");
            Console.ReadKey();
        }
    }
}
