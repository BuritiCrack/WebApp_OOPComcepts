using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPComcepts.Helpers
{
    internal class EmployeeHelper
    {
        #region Fields
        private Employee _salaryEmployee;
        private Employee _hourlyEmployee;
        private Employee _commissionEmployee;
        private Employee _baseCommissionEmployee;
        #endregion

        #region Methods
        public EmployeeHelper(Employee salaryEmployee, Employee hourlyEmployee,
                              Employee commissionEmployee, Employee baseCommissionEmployee)
        {
            _salaryEmployee = salaryEmployee;
            _hourlyEmployee = hourlyEmployee;
            _commissionEmployee = commissionEmployee;
            _baseCommissionEmployee = baseCommissionEmployee;

        }

        public decimal GetPayrollFromActiveEmpoyees()
        {
            ICollection<Employee> employees = new List<Employee>()
                {
                   _salaryEmployee,
                   _hourlyEmployee,
                   _commissionEmployee,
                   _baseCommissionEmployee,
                };

            decimal payroll = 0;

            foreach (Employee employee in employees)

                if (employee.IsActive == true)
                {
                    {
                        Console.WriteLine(employee);
                        Console.WriteLine(" ");
                        payroll += employee.GetValueToPay();
                    }

                }

            return payroll;
        } 
        #endregion
        
    }
}
