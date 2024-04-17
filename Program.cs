
using System.Runtime.InteropServices;

namespace UpCastinBoxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mercedes merc = new Mercedes();
            merc.Door();

            Mercedes mer = new Eclasss(); 
            mer.Wheel();
            if (merc is Cklasss)
            {
                Cklasss ck = (Cklasss)merc;
                ck.Mator();
            } 


            string text=5.ToString();// bu boxing oldu
            int num =Convert.ToInt32(text); // bu da oldu unboxing


            Person ali = new()
            {
                Name = "Alik",
                Surname = "Shukurov",
                Age = 20
            };
        Person shain = new()
        {
            Name = "Shain",
            Surname = "Alizade",
            Age = 20
        };
            Console.WriteLine(ali>shain);

        }
    }class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public static bool operator>(Person left, Person right)
        {
            return left.Age>right.Age;
        }
        public static bool operator <(Person left, Person right)
        {
            return left.Age < right.Age;
        }
        public static bool operator ==(Person left, Person right)
        {
            if(left.Name!=right.Name || left.Surname != right.Surname 
                || left.Age!=right.Age) return false;
            return true;
        }
        public static bool operator !=(Person left, Person right)
        {
            return !(left == right);
        }
    }
}
