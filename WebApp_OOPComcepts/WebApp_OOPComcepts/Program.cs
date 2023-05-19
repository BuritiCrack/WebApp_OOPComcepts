using System;
using System.Collections.Generic;
using System.Data.Common;
using WebApp_OOPComcepts.Helpers;

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

                //Console.WriteLine(salaryEmployee);
                Console.WriteLine("");

                Employee commissionEmployee = new CommissionEmployee()
                {
                    Id = 1,
                    FirstName = "Joaquin",
                    LastName = "Casas",
                    BirthDate = dataObject,
                    HiringDate = dataObject,
                    IsActive = false,
                    CommissionPercentaje = 5,
                    Sales = 10000
                };

                //Console.WriteLine(commissionEmployee);
                Console.WriteLine("");

                Employee hourlyEmployee = new HourlyEmployee()
                {
                    Id = 1,
                    FirstName = "Ramiro",
                    LastName = "Casas",
                    BirthDate = dataObject,
                    HiringDate = dataObject,
                    IsActive = true,
                    Hours = 100,
                    HoursValue = 6500
                };

                //Console.WriteLine(hourlyEmployee);
                Console.WriteLine("");

                CommissionEmployee baseCommissionEmployee = new BaseCommissionEmployee()
                {

                    Id = 1,
                    FirstName = "Alvaro",
                    LastName = "Base",
                    BirthDate = dataObject,
                    HiringDate = dataObject,
                    IsActive = true,
                    CommissionPercentaje = 5,
                    Sales = 100000,
                    Base = 160000
                };
              //  Console.WriteLine(baseCommissionEmployee);
                Console.WriteLine("");

                EmployeeHelper employeeHelper = new EmployeeHelper(salaryEmployee, hourlyEmployee,
                                                                   commissionEmployee, baseCommissionEmployee);
                
                Console.WriteLine($"Total Payroll......{employeeHelper.GetPayrollFromActiveEmpoyees():C2}");
                Console.WriteLine(" ");

                Invoice invoice = new Invoice()
                {
                    Id = 200,
                    Description = "Cilantro",
                    Price = 10,
                    Quantity = 3
                };

                Console.WriteLine(invoice);

            }
            catch (Exception message) 
            {
                  Console.WriteLine(message);

            }

        }
    }
}
