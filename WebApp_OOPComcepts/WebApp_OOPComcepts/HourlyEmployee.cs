using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPComcepts
{
    public class HourlyEmployee : Employee
    {
        #region Propieties

        public float Hours { get; set; }
        public decimal HoursValue { get; set; }

        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            return HoursValue * (decimal)Hours;
        }

        public override string ToString()
        {
            return $"{ base.ToString()}\n\t" +
                    $"Hours...............{Hours}\n\t" +
                    $"HoursValue..........{HoursValue}\n\t" +
                    $"Value To Pay........{GetValueToPay():C2}\n\t";
        }

        #endregion
    }
}
