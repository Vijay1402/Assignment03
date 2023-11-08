using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNum;
            Console.WriteLine("Enter a string");

            bool isParseable = int.TryParse(Console.ReadLine(), out myNum); 
            //returns a boolean value and makes error handling easier
            if (isParseable)
            {
                Console.WriteLine(" Converted integer is: \t" + myNum);
                Console.WriteLine("Multiplication result: \t" + (myNum * 5));
            }
            else { Console.WriteLine("The number entered by is not parse able"); }

            try
            {
                Console.WriteLine("Enter a string with decimal value");
                double myvar = Convert.ToDouble(Console.ReadLine()); //convert supports conversion of certain values that parse method can not type cast
                Console.WriteLine("Covnerted Decimal is " + myvar);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! " + ex.Message);
            }

            try
            {
                Console.WriteLine("Enter a string with decimal value");
                double myvar1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Parsed decimal is " + myvar1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! " + ex.Message);
            }
            
            try
            {
                Console.WriteLine("Enter a string with date");
                DateTime myvar2 = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Converted date is " + myvar2);
                Console.WriteLine("After subtracting one month " + myvar2.AddMonths(-1));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! " + ex.Message);
            }
            try
            {
                Console.WriteLine("Enter a time span");
                TimeSpan myvar3 = TimeSpan.Parse(Console.ReadLine());
                Console.WriteLine("Converted time span is " + myvar3);
                TimeSpan addTime = new TimeSpan(0, 1, 0, 0);
                myvar3 = myvar3.Add(addTime);
                Console.WriteLine("After adding one hour " + myvar3);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! " + ex.Message);
            }
            finally
            {
                Console.WriteLine("End of Program!"); Console.ReadKey();
            }


            Console.ReadKey();

        }
    }
}
