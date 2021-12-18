using System;

namespace Persons
{
    class Employee : Person
    {
        protected string jobTitle { set; get; }

        public Employee(string jobTitle, string firstName, string lastName, string address, int id)
        {
            this.jobTitle = jobTitle;
            base.lastName = lastName;
            base.address = address;
            base.firstName = firstName;
            base.id = id;
        }


        public new void Display()
        {
            Console.WriteLine($"ID{id} : {firstName} {lastName}, lives on {address}, occupation {jobTitle}");
        }
    }
}