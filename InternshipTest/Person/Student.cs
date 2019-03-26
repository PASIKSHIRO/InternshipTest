namespace InternshipTest.Person
{

    public class Student
    {   
        public string name;
        public Knowledge knowledge;

        public Student(string name, int knowledge=0)
        {
            this.name = name;
            this.SetKnowledge(new Knowledge(knowledge));
        }
        
        public void SetKnowledge(Knowledge knowledge)
        {
            this.knowledge = knowledge;
        }
    }
}