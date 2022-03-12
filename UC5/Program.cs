
using System;

namespace UC4
{
    class Program
    {
        public const int PartTime = 1;
        public const int FullTime = 2;
        public const int EmpRatePerHr = 20;
        public const int NumOfWorkingDays = 2;

        static void Main(string[] args)
        {
            int empHrs = 0;
            int empWages = 0;
            int totalEmpWage = 0;

            for (int day = 0; day < NumOfWorkingDays; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case PartTime:
                        empHrs = 4;
                        break;
                    case FullTime:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                empWages = empHrs * EmpRatePerHr;
                totalEmpWage += empWages;
                Console.WriteLine("emp wages:" + empWages);

            }
            Console.WriteLine("Total Wages:" + totalEmpWage);

          

        }
    }
}