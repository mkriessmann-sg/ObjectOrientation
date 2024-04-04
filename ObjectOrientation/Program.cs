using System.Runtime.CompilerServices;

namespace ObjectOrientation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }


       
    }
    abstract public class Shoseki
    {
        protected string title;
        protected string author;
        protected int copiesAvailable;
   
        abstract public void DisplayInformation();


        public void LendOut()
        {
            this.copiesAvailable = this.copiesAvailable--;
        }

        public void Return() 
        {
            this.copiesAvailable = this.copiesAvailable++;
        }

    }

    public class Hon : Shoseki
    {
        double price;
        
     public override void DisplayInformation()
        {
            Console.WriteLine("Title:" + this.title);
            Console.WriteLine("Author:" + this.author);
            Console.WriteLine("Title:" + this.copiesAvailable);
            Console.WriteLine("Price:" + this.price);
        }
    }

    public class Zasshi : Shoseki
    {
        string item;

        public override void DisplayInformation()
        {
            Console.WriteLine("Title:" + this.title);
            Console.WriteLine("Author:" + this.author);
            Console.WriteLine("Title:" + this.copiesAvailable);
            Console.WriteLine("Price:" + this.item);
        }
    }

    public class Shinbunn : Shoseki
    {
        DateOnly publishedday;
        public override void DisplayInformation()
        {
            Console.WriteLine("Title:" + this.title);
            Console.WriteLine("Author:" + this.author);
            Console.WriteLine("Title:" + this.copiesAvailable);
            Console.WriteLine("Price:" + this.publishedday);
        }

    }
}
