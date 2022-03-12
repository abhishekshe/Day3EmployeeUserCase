
using System;

namespace UC6
{
    class Program
    {
        public const int PartTime = 1;
        public const int FullTime = 2;
        public const int EmpRatePerHr = 20;
        public const int NumOfWorkingDays = 2;
        public const int MaxHrsInMonth = 10;


        static void Main(string[] args)
        {
            int empHrs = 0;
            // empWages = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs <= MaxHrsInMonth && totalWorkingDays<NumOfWorkingDays)
            {
                totalWorkingDays++;
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
               // empWages = empHrs * EmpRatePerHr;
                totalEmpHrs += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + " Emp Hrs: "+ empHrs);

            }
            int totalEmpWage = totalEmpHrs * EmpRatePerHr;
            Console.WriteLine("Total Wages:" + totalEmpWage);



        }
    }
}