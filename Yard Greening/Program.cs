using System;

namespace Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double greeningPerimeter = double.Parse(Console.ReadLine());

            double price = greeningPerimeter * 7.61;

            double discount = price * 0.18;

            double finalPrice = price - discount;

            Console.WriteLine($"The final price is: {finalPrice:f2} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
