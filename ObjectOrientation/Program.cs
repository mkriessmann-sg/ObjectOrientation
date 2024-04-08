using System.Globalization;
using System.Runtime.CompilerServices;

namespace ObjectOrientation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hon hon1 = new Hon("Hon1", "Author1", 3, 300);
            Hon hon2 = new Hon("Hon2", "Author2", 4, 200);
            Zasshi zasshi1 = new Zasshi("Zasshi1", "Author1", 15, "Penlight");
            Zasshi zasshi2 = new Zasshi("Zasshi2", "Author3", 4, "Hairbrush");
            Shinbunn shinbunn1 = new Shinbunn("Shinbun1", "Author4", 10, new DateOnly(2024,3,31));
            Shinbunn shinbunn2 = new Shinbunn("Shinbun2", "Author4", 8, new DateOnly(2024, 4, 1));

            List<Shoseki> fullList = new List<Shoseki>();
            fullList.Add(hon1 );
            fullList.Add(hon2);
            fullList.Add(zasshi1);
            fullList.Add(zasshi2);
            fullList.Add(shinbunn1 );
            fullList.Add(shinbunn2);


            foreach(Shoseki s in fullList)
            {
                s.DisplayInformation();
            }
    }
    }
    abstract public class Shoseki
    {
        protected string title;
        protected string author;
        protected int copiesAvailable;

        protected Shoseki(string title, string author, int copiesAvailable)
        {
            this.title = title;
            this.author = author;
            this.copiesAvailable = copiesAvailable;
        }

        abstract public void DisplayInformation();


        public void LendOut()
        {
            this.copiesAvailable--;
        }

        public void Return() 
        {
            this.copiesAvailable++;
        }

    }

    public class Hon : Shoseki
    {
        double price;

        public Hon(string title, string author, int copiesAvailable, double price) : base(title, author, copiesAvailable)
        {
            this.price = price;
        }
        
        
     public override void DisplayInformation()
        {
            Console.WriteLine("Title:" + this.title);
            Console.WriteLine("Author:" + this.author);
            Console.WriteLine("Title:" + this.copiesAvailable);
            Console.WriteLine("Price:" + this.price);
            Console.WriteLine("");
        }
    }

    public class Zasshi : Shoseki
    {
        string item;

        public Zasshi(string title, string author, int copiesAvailable, string item) : base(title, author, copiesAvailable)
        {
            this.item = item;
        }


        public override void DisplayInformation()
        {
            Console.WriteLine("Title:" + this.title);
            Console.WriteLine("Author:" + this.author);
            Console.WriteLine("Title:" + this.copiesAvailable);
            Console.WriteLine("Item:" + this.item);
            Console.WriteLine("");
        }
    }

    public class Shinbunn : Shoseki
    {
        DateOnly publishedday;
        public Shinbunn(string title, string author, int copiesAvailable, DateOnly date) : base(title, author, copiesAvailable)
        {
            this.publishedday = date;
        }

        public override void DisplayInformation()
        {
            Console.WriteLine("Title:" + this.title);
            Console.WriteLine("Author:" + this.author);
            Console.WriteLine("Title:" + this.copiesAvailable);
            Console.WriteLine("Published Day:" + this.publishedday);
            Console.WriteLine("");
        }

    }
}
