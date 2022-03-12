using System;

namespace UC4
{
    class Program
    {
        public const int PartTime = 1;
        public const int FullTime = 2;
        public const int EmpRatePerHr = 20;

        static void Main(string[] args)
        {
            int empHrs = 0;
            int empWages = 0;
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
            Console.WriteLine("emp wages:" + empWages);

        }
    }
}