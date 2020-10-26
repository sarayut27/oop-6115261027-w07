using System;

namespace oop_6115261027_w07
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Nitat", "Ninchawee", 20000, 20, 30, 10);
            Lecturer l1 = new Lecturer("Nitat", "Ninchawee", 20000, 5, 10, 20, 20, 30, 20);
            Staff s1 = new Staff("Nitat", "Ninchawee", 20000, 5, 30, 10, 60);
            Console.WriteLine(p1.ToString());
            Console.WriteLine(l1.ToString());
            Console.WriteLine(s1.ToString());
        }
    }
}
