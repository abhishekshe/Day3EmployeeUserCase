using System;

namespace EmployeePresence
{
    class program
    {
        static void Main(string[] args)
        {
            int FullTime = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == FullTime)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is not present");
            }

        }
    }
}