using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPComcepts
{
    public class BaseCommissionEmployee : CommissionEmployee 
    {
        #region Propieties

        public decimal Base { get; set; }

        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            // return Sales * (decimal)CommissionPercentaje/100 + Base; Esta bien pero como debemos de reutilizar codigo lo mejor es 
            //                                                          madar a llamar el metodo padre que ya nos hace esta operacion.
            return base.GetValueToPay() + Base; 
        }

        public override string ToString()
        {
            return $"{ base.ToString()}\n\t" +
                    $"Base...............................{Base:C2}\n\t" +
                    $"Total Value To Pay.................{GetValueToPay():C2}\n\t";
        }

        #endregion
    }
}
