using System;
using System.Dynamic;

namespace dyna
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic d = 0;
            float f = 10.032f;
            bool b = false;
            d = d + 10;
            //d = d + "Pradeep:";
            d = d + f;
            d = d + b;
            Console.WriteLine(d);


            dynamic person = new ExpandoObject();
            person.Name = "Pradeep";
            Console.WriteLine(person.Name);
            Console.WriteLine(person.name);
        }
    }
}
