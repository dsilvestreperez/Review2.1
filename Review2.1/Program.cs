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


              Console.WriteLine("What is principal amount of the loan in dollars?"); // the priciple loans you have
              Principle = Convert.ToDouble(Console.ReadLine());//inputing the principle amount you have for

              Console.WriteLine("What is interest rate?");//the percentage of the interest you are getting
              Rate = Convert.ToDouble(Console.ReadLine());//input of your rate percentage but in two of the decemal places to the left


              Console.WriteLine("Total interest of loan in years?");//the amount you re getting thur out the years
              Time = Convert.ToDouble(Console.ReadLine());//the time of the loans you are getting in time

              Interest = Principle * Rate * Time;// the equation fo all the three for the total

              Console.WriteLine("Total interest of loan:" + Interest);//displaying the interest from the equation I but int


        }

    }

}
