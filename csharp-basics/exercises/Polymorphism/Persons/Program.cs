namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * - Create an instant of class Student and an instant of class Employee with proper values for the attributes.
             * - Display the content of each class using Display() method.
             */
            Student student1 = new Student(94, "Janis", "Krumins", "Avotu Iela 46", 13);
            Employee employee1 = new Employee("janitor", "John", "Watson", "Boulevard 2", 14);
            student1.Display();
            employee1.Display();
        }
    }
}