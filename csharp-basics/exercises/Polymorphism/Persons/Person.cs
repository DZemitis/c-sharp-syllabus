using System;

namespace Persons
{
    public class Person
    {
        protected string firstName { get; set; }
        protected string lastName { get; set; }
        protected string address { get; set; }
        protected int id { get; set; }

        public Person(string firstName, string lastName, string address, int id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.id = id;
        }

        public Person()
        {

        }

        public void Display()
        {
            Console.WriteLine($"First name is {firstName}");
            Console.WriteLine($"Last name is {lastName}");
            Console.WriteLine($"Address is {address}");
            Console.WriteLine($"ID is {id}");
        }
    }
}