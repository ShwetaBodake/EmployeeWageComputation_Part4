// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace EmployeeWageComputation_Part4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wel_Come to Employee Wage Computation Problem");
            PartTimeEmpWage partTimeEmpWage = new PartTimeEmpWage();
            partTimeEmpWage.CheckPartTimeEmp_Wage();
        }


        public class PartTimeEmpWage
        {
            public void CheckPartTimeEmp_Wage()
            {
                int Wage_Per_Hour = 20;
                int Part_Time_Hour = 8;
                int Full_Time_hour = 2 * Part_Time_Hour;


                Random random = new Random();
                int CheckEmp = random.Next(0, 3);
                if (CheckEmp == 1)
                {
                    Console.WriteLine("Employee is Fulltime Present");
                    int Daily_Wage_Of_Fulltime = Wage_Per_Hour * Full_Time_hour;
                    Console.WriteLine("Daily wage of full time Employee is " + Daily_Wage_Of_Fulltime);

                }
                else if (CheckEmp == 2)
                {
                    Console.WriteLine("Employee is part time present");
                    int Daily_Wage_Of_Parttime = Wage_Per_Hour * Part_Time_Hour;
                    Console.WriteLine("Daily wage of part time Employee is " + Daily_Wage_Of_Parttime);

                }
                else
                {
                    Console.WriteLine("Employee is Absent");
                }

            }
        }


    }
}
