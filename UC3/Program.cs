using System;

namespace UC3
{
    class Program
    {
        static void Main(string[] args)
        {
            int PartTime = 1;
            int FullTime = 2;
            int EmpRatePerHr = 20;

            int empHrs = 0;
            int empWages = 0;

            Random random = new Random();

            int empCheck = random.Next(0, 3);

            if (empCheck == PartTime)
            {
                empHrs = 4;
            }
            else if (empCheck == FullTime)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }

            empWages = empHrs * EmpRatePerHr;
            Console.WriteLine("emm Wages:" + empWages);
        }
    }
}
