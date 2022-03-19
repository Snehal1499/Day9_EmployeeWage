using System;

namespace EmployeeWageComputation
{
    public class UC1_EmployeeWage
    {
        //Constants
        public int Is_Full_Time = 1;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation Programe");
            //Computation
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            UC1_EmployeeWage emp = new UC1_EmployeeWage();

            if (empcheck == emp.Is_Full_Time)
            {
                Console.WriteLine("employee is Present");
            }
            else
            {
                Console.WriteLine("employee is Absent");
            }
        }
    }
}

