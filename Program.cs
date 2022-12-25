// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace EmployeeWageComputation_Part4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wel_Come to Employee Wage Computation Problem");
            DailyEmpWage_UC2 dailyWage = new DailyEmpWage_UC2();
            dailyWage.DailyWage();
        }


        public class DailyEmpWage_UC2
        {
            public void DailyWage()
            {
                int Wage_per_Hour = 20;
                int Full_Day_Hour = 8;
                Random random = new Random();
                int isPresent = random.Next(0, 2);

                //Console.WriteLine(isPresent);
                if (isPresent == 1)
                {
                    Console.WriteLine("Employee is PRESENT");
                    int DailyWge = Wage_per_Hour * Full_Day_Hour;
                    Console.WriteLine("Daily wage of employee is " + DailyWge);

                }
                else
                {
                    Console.WriteLine("Employee is Absent");
                }


            }
        }

    }
}
