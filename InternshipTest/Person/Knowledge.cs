namespace InternshipTest
{
    //Клас знання
    public class Knowledge
    {
        public int level = 0;

        //Валідація оцінок студентів
        public Knowledge(int level)
        {   
            if(0 <= level && 100 >= level)
            {
                this.level = level; 
            }
            else
            {
                this.level = 0;
            }
        }
    }
}
