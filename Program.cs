// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace EmployeeWageComputation_Part4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wel_Come to Employee Wage Computation Problem");
            AttendanceCheck x = new AttendanceCheck();
            x.EmpAttendace();
        }

        public class AttendanceCheck
        {
            public void EmpAttendace()
            {
                Random random = new Random();
                int isPresent = random.Next(0, 2);

                //Console.WriteLine(isPresent);
                if (isPresent == 1)
                { Console.WriteLine("Employee is PRESENT"); }
                else
                {
                    Console.WriteLine("Employee is Absent");
                }

            }
        }

    }
}
