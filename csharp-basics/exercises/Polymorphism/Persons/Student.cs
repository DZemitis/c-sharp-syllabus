using System;

namespace Persons
{
    public class Student : Person
    {
        protected double gpa { get; set; }

        public Student(double gpa, string firstName, string lastName, string address, int id)
        {
            this.gpa = gpa;
            base.lastName = lastName;
            base.address = address;
            base.firstName = firstName;
            base.id = id;
        }

        public new void Display()
        {
            Console.WriteLine($"ID{id} : {firstName} {lastName}, lives on {address} has {gpa}");
        }
    }
}