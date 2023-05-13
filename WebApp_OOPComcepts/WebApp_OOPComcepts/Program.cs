using System;

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
            }
            catch (Exception message) 
            {
                  Console.WriteLine(message);

            }

        }
    }
}
