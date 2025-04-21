using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoledocumation
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Interest Calculation Program");


                double Principle, Rate, Time, Interest; 


              Console.WriteLine("What is principal amount of the loan in dollars?"); 
              Principle = Convert.ToDouble(Console.ReadLine());//string variable for the input principle

              Console.WriteLine("What is interest rate?");//string varialbe for the input rate
              Rate = Convert.ToDouble(Console.ReadLine());


              Console.WriteLine("Total interest of loan in years?");//string variable for the input time
              Time = Convert.ToDouble(Console.ReadLine());

              Interest = Principle * Rate * Time;

              Console.WriteLine("Total interest of loan:" + Interest);//Printing the variable Interest to display the value


        }

    }

}
