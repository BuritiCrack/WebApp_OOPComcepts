using System;
using System.Data.Common;

namespace WebApp_OOPComcepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("*********************");
                Console.WriteLine("*My first date class*");
                Console.WriteLine("*********************");
                Console.WriteLine("");

                Console.WriteLine("Pleas type the year: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Pleas type the month: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Pleas type the day: ");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");


                var dataObject = new Date( year, month, day);
                Console.WriteLine("The date entered is: " + dataObject);
                Console.WriteLine("");

                Employee salaryEmployee = new SalaryEmployee()
                {
                    Id = 1,
                    FirstName = "Armando",
                    LastName = "Casas",
                    BirthDate = dataObject,
                    HiringDate = dataObject,
                    IsActive = true,
                    Salary = 160000
                };

                Console.WriteLine(salaryEmployee);
                Console.WriteLine("");

                Employee commissionEmployee = new CommissionEmployee()
                {
                    Id = 1,
                    FirstName = "Armando",
                    LastName = "Casas",
                    BirthDate = dataObject,
                    HiringDate = dataObject,
                    IsActive = false,
                    CommissionPercentaje = 5,
                    Sales = 10000
                };

                Console.WriteLine(commissionEmployee);
                Console.WriteLine("");

                Employee hourlyEmployee = new HourlyEmployee()
                {
                    Id = 1,
                    FirstName = "Armando",
                    LastName = "Casas",
                    BirthDate = dataObject,
                    HiringDate = dataObject,
                    IsActive = false,
                    Hours = 5,
                    HoursValue = 6500
                };

                Console.WriteLine(hourlyEmployee);
                Console.WriteLine("");

                CommissionEmployee baseCommissionEmployee = new BaseCommissionEmployee()
                {

                    Id = 1,
                    FirstName = "Armando",
                    LastName = "Base",
                    BirthDate = dataObject,
                    HiringDate = dataObject,
                    IsActive = false,
                    CommissionPercentaje = 5,
                    Sales = 100000,
                    Base = 160000
                };
                Console.WriteLine(baseCommissionEmployee);

            }
            catch (Exception message) 
            {
                  Console.WriteLine(message);

            }

        }
    }
}
