// See https://aka.ms/new-console-template for more information
Console.WriteLine("Interest Calculation Program");


double Principle, Rate, Time, Interest;


Console.WriteLine("What is princippal amount of the loan in dollars?");//principle 
Principle = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is interest rate?");//rate
 Rate = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Total interest of loan in years?");//time
Time = Convert.ToInt32(Console.ReadLine());

Interest = Principle * Rate * Time;//equation

Console.WriteLine("Total interest of loan:" + Interest);