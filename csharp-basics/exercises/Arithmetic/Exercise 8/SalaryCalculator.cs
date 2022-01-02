using System;

namespace Exercise_8
{
    public class SalaryCalculator
    {
        private int _minimumPay = 8;
        private int _maxHours = 40;

        public decimal Calculate(decimal basePay, decimal hoursWorked)
        {
            if (hoursWorked > 40)
            {
                return Math.Round(basePay * 40 + (decimal) 1.5 * basePay * (hoursWorked - 40), 2);
            }

            return Math.Round(basePay * hoursWorked);
        }
    }
}