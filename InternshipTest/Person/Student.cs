namespace InternshipTest.Person
{

    //Клас студент
    public class Student
    {   
        public string name;
        public Knowledge knowledge;

        public Student(string name, int knowledge=0)
        {
            this.name = name;
            this.SetKnowledge(new Knowledge(knowledge));
        }
        
        //Метод встановлення оцінки студенту
        public void SetKnowledge(Knowledge knowledge)
        {
            this.knowledge = knowledge;
        }
    }
}