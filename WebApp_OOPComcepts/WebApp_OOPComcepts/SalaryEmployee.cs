using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPComcepts
{
    public class SalaryEmployee : Employee
    {
        #region Propieties

        public decimal Salary { get; set; }

        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{ base.ToString()}\n\t" +
                   $"Salary.........{GetValueToPay():C2}";
        }

        #endregion
    }
}
