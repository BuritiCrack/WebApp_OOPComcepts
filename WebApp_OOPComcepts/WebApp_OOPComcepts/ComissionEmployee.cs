using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPComcepts
{
    public class CommissionEmployee : Employee
    {
        #region Propieties

        public double CommissionPercentaje { get; set; }
        public decimal Sales { get; set; }

        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentaje/100;
        }

        public override string ToString()
        {
            return $"{ base.ToString()}\n\t" +
                    $"Commision Percentaje.........{CommissionPercentaje/100:P2}\n\t" +
                    $"Sales........................{Sales:C2}\n\t" +
                    $"Value To Pay.................{GetValueToPay():C2}\n\t";
        }

        #endregion
    }
}
