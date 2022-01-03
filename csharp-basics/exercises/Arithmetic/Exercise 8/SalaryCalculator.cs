using System;

namespace Exercise_8
{
    public class SalaryCalculator
    {
        private decimal _minHourlyRate = 8;
        private decimal _maxHours = 60;


        public decimal SalaryCalc(decimal hourlyRate, decimal hoursWorked)
        {
            if (hourlyRate < _minHourlyRate)
                throw new Exception("Error, not possible");

            if (hoursWorked > _maxHours)
                throw new Exception("Error, not possible");

            if (hoursWorked > 40)
                return Math.Round(hourlyRate * 40 + (decimal)1.5 * hourlyRate * (hoursWorked - 40), 2);

            return Math.Round(hourlyRate * hoursWorked, 2);
        }
    }
}