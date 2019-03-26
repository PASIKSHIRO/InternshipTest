namespace InternshipTest
{
  
    public class Knowledge
    {
        public int level = 0;

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
