using System;
using System.Collections.Generic;
using System.Text;
using WebApp_OOPComcepts.Interfaces;

namespace WebApp_OOPComcepts
{
    public class Invoice : IPay
    {
        #region Properties
        public int Id { get; set; }
        public String Description { get; set; }
        public Decimal Price { get; set; }
        public Double Quantity { get; set; }

        #endregion

        #region Methods
        public decimal GetValueToPay()
        {
            return (decimal)Quantity * Price;
        }

        public override string ToString()
        {
            return $"ID................{Id}\n\t" +
                   $"Description ......{Description}\n\t" +
                   $"Price.............{Price:C2}\n\t" +
                   $"Quantity..........{Quantity}\n\t" +
                   $"Total.............{GetValueToPay():C2}";
        }
        #endregion
    }
}