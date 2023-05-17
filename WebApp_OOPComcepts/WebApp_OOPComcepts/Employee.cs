using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPComcepts
{
    public abstract class Employee
    {
        #region Propieties

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Date BirthDate { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }

        #endregion

        #region Methods

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"------EMPLOYEE------\n\t" +
                   $"Id---------------{Id}\n\t" +
                   $"Fist Name--------{FirstName}\n\t" +
                   $"Last Name--------{LastName}\n\t" +
                   $"Birth Date-------{BirthDate}\n\t" +
                   $"Hiring Date------{HiringDate}\n\t" +
                   $"Is Active?-------{IsActive}";
                   
        }

        #endregion
    }
}
