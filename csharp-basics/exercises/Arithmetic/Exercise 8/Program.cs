using System;
using System.Dynamic;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee hourly rate");
            double EmployeeOnePayForHour = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee hours worked");
            double EmployeeHoursWorked = double.Parse(Console.ReadLine());

            double salary = EmployeeOnePayForHour < 8.00 ? double.Parse("Error") : EmployeeHoursWorked * EmployeeOnePayForHour;

            double basePay = EmployeeHoursWorked < 40 ? salary : salary * 1.5;
           
            double totalPay = 0;

            if (EmployeeHoursWorked < 40 || EmployeeHoursWorked > 60)
            {
                double.Parse("error");
            }
            else
            {
                for (int i = 1; i <= 40; i++)
                {
                    totalPay = EmployeeOnePayForHour * i * 1.5;
                }
            }

            Console.WriteLine("Total pay for employee is ${0}", totalPay);
        }   
    }
}
