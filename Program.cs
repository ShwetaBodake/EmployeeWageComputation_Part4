// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace EmployeeWageComputation_Part4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wel_Come to Employee Wage Computation Problem");
            WagesForMonth_UC5 WagesForMonth = new WagesForMonth_UC5();
            WagesForMonth.WagesForMonth();
        }


        public class WagesForMonth_UC5
        {
            public void WagesForMonth()
            {
                int Working_Day_For_Month = 20;
                int Is_Part_Time = 2;
                int Is_Full_Time = 1;
                int Emp_Rate_per_Hour = 20;

                int empHours = 0;
                //int empwage = 0;
                int totalempwage = 0;

                Random random = new Random();
                int Checkemp = random.Next(0, 3);

                for (int day = 1; day <= Working_Day_For_Month; day++)
                {
                    switch (Checkemp)
                    {
                        case 1:
                            empHours = 8;
                            break;

                        case 2:
                            empHours = 4;
                            break;

                        default:

                            empHours = 0;
                            break;

                    }
                    int daily_empwage = empHours * Emp_Rate_per_Hour;
                    //int monthly_emp_wage = daily_empwage * Working_Day_For_Month;
                    Console.WriteLine("Daily Employee Wage:-" + daily_empwage);
                    totalempwage += daily_empwage;

                }
                Console.WriteLine("Total Employee wage:-" + totalempwage);

            }
        }



    }
}
