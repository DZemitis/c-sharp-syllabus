using System;
using System.Dynamic;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* An employee gets paid(hours worked) × (base pay), for each hour up to 40 hours.
                 For every hour over 40, they get overtime = (base pay) × 1.5.
                 The base pay must not be less than the minimum wage($8.00 an hour).If it is, print an error.
                 If the number of hours is greater than 60, print an error message.
                 Write a method that takes the base pay and hours worked as parameters, and prints the total pay or an error.
                 Write a main method that calls this method for each of these employees:
 
             Employee    Base Pay    Hours Worked
             Employee 1	$7.50         35
             Employee 2	$8.20         47
             Employee 3	$10.00        73*/
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
