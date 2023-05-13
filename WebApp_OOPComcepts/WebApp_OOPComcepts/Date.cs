using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace WebApp_OOPComcepts
{
    public class Date
    {
        
        #region Fields

        private int _year;
        private int _month;
        private int _day;

        #endregion

        #region Methods

        public Date(int year, int month, int day)
        {
            _year = CheckYear(year);
            _month = CheckMonth(month);
            _day = CheckDay(day,month,year);
        }

        private int CheckYear(int year)
        {
            if (year > 1900) 
            {
                return year;
            }
            throw new YearExeption("The year is invalid");
        }

        private int CheckDay(int day, int month, int year)
        {

            if ( month == 2 && day == 29 && IsLeapYear(year)) 
            {
                return day;
            }

            int[] daysPorMonth = {0,31,28,31,30,31,30,31,31,30,31,30,31};

            if (day >= 1 && day <= daysPorMonth[month])
            {
                return day;
            }

            throw new DayExeption("The day in invalid");

        }

        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 00;
        }

        private int CheckMonth(int month)
        {
            if(month >= 1 && month <=12)
                return month;

            throw new MonthExeption("The month is invalid");
        }

        public override string ToString()
        {
                    // Hay tres formas de hacerlo //
                    
            return   $"{_year:0000}/{_month:00}/{_day:00}";           // --> interpolación
                    // String.Format("{0}/{1}/{2}", _year, _month, _day); 
                    // (_year + "/" + _month + "/" + _day); --> concatenación (Gasta mucha memoria)   
        }
        #endregion


    }
}
