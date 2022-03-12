using System;

namespace EmployeeWages
{
    class program
    {
        static void Main(string[] args)
        {
            int FullTime = 1;
            int EmpRate = 20;

            int empHours = 0;
            int empWage = 0;

            Random random = new Random();

            int emCheck = random.Next(0, 2);
            if (emCheck == FullTime)
            {
                empHours = 8;
            }
            else
            {
                empHours = 0;
            }
            empWage = empHours * EmpRate;
            Console.WriteLine("EmpWage: " + empWage);



        }
    }
}