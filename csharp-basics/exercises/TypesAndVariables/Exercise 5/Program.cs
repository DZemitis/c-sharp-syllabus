using System;
using System.Linq;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string classOne = "English III";
            string classTwo = "Precalculus";
            string classThree = "Music Theory";
            string classFour = "Biotechnology";
            string classFive = "Principles of Technology I";
            string classSix = "Latin II";
            string classSeven = "AP US History";
            string classOneTeacher = "Ms. Lapan";
            string classTwoTeacher = "Mrs. Gideon";
            string classThreeTeacher = "Mr. Davis";
            string classFourTeacher = "Ms. Palmer";
            string classFiveTeacher = "Ms. Garcia";
            string classSixTeacher = "Mrs. Barnett";
            string classSevenTeacher = "Ms. Johannessen";

            Console.WriteLine("+" + String.Concat(Enumerable.Repeat("-", 46)) + "+");
            Console.WriteLine($"| 1 |{classOne,26}|{classOneTeacher,15}|\n| 2 |{classTwo,26}|{classTwoTeacher,15}|\n" +
                              $"| 3 |{classThree,26}|{classThreeTeacher,15}|\n| 4 |{classFour,26}|{classFourTeacher,15}|\n" +
                              $"| 5 |{classFive,26}|{classFiveTeacher,15}|\n| 6 |{classSix,26}|{classSixTeacher,15}|\n" +
                              $"| 7 |{classSeven,26}|{classSevenTeacher,15}|");
            Console.WriteLine("+" + String.Concat(Enumerable.Repeat("-", 46)) + "+");
        }
    }
}
