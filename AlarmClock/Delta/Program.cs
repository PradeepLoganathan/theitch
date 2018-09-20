using System;

namespace Delta
{
    class Program
    {
        static void Main(string[] args)
        {
            Person P1 = new Person("Pradeep", "Loganathan");
            Console.WriteLine(P1.Tostring((a, b) => a + " " + b));
            Console.WriteLine(P1.Tostring((a, b) => b +", " + a));

            P1.Do(a => Console.WriteLine($"{a.FirstName} is running"));
        }
    }
}
