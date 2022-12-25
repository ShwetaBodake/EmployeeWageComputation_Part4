// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace EmployeeWageComputation_Part4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wel_Come to Employee Wage Computation Problem");
            RefactorEmpWageComputation WagesTillWorkingDayHour = new RefactorEmpWageComputation();
            WagesTillWorkingDayHour.EmpWageComputation();
        }

        public class RefactorEmpWageComputation
        {
            public void EmpWageComputation()
            {

                int Is_Part_Time = 2;
                int Is_Full_Time = 1;
                int Emp_Wage_Per_Hour = 20;
                int Max_Hours_In_Month = 100;
                int Working_Days_In_Month = 20;



                int empHours = 0;
                int totalEmpHours = 0;
                int totalWorkingDays = 0;

                while (totalEmpHours <= Max_Hours_In_Month && totalWorkingDays < Working_Days_In_Month)
                {
                    totalWorkingDays++;

                    Random random = new Random();
                    int CheckEmp = random.Next(0, 3);

                    switch (CheckEmp)
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
                    totalEmpHours += empHours;
                    Console.WriteLine("Days:- " + totalWorkingDays + "EmpHours:- " + empHours);
                }
                int totalEmpWage = totalEmpHours * Emp_Wage_Per_Hour;
                Console.WriteLine("Total Emp Wage: " + totalEmpWage);
            }
        }




    }
}
