using System;
using Exercise_8;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hourly rate: ");
            decimal hourlyRate = decimal.Parse(Console.ReadLine());
            Console.Write("Hours worked: ");
            decimal hoursWorked = decimal.Parse(Console.ReadLine());
            var employee = new SalaryCalculator();
            Console.WriteLine($"Your salary is {employee.SalaryCalc(hourlyRate, hoursWorked)}");
        }
    }
}