using System;

namespace Delta
{
    class Person
    {
        public readonly string FirstName;
        public readonly string LastName;

        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }        

        public string Tostring(Func<string, string, string> NameFormatter)
        {
            return NameFormatter(FirstName, LastName);
        }

        public void Do(Action<Person> action)
        {
            action(this); 
        }
    }
}
