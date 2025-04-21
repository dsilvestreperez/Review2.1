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


            double Principle, Rate, Time, Interest;//input the equation


            Console.WriteLine("What is princippal amount of the loan in dollars?");//principle 
            Principle = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is interest rate?");//rate
            Rate = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Total interest of loan in years?");//time
            Time = Convert.ToInt32(Console.ReadLine());

            Interest = Principle * Rate * Time;//equation

            Console.WriteLine("Total interest of loan:" + Interest);// intrest

        }

    }

}
