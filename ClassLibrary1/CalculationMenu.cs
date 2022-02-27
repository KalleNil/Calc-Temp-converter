using Individuell_inlämning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CalculationMenu
    {

        /// <summary>
        /// <see cref="Calculations"/>Låter användaren mata in 2 tal och sedan välja räknesätt
        /// </summary>
        public void Calculations()
        {
            UserInputs input = new();
            Calculations calculations = new();

            Console.WriteLine("skriv in ett tal");
            decimal num1 = input.InputNumber(Console.ReadLine()!);
            Console.WriteLine("skriv in ett tal");
            decimal num2 = input.InputNumber(Console.ReadLine()!);
            Console.WriteLine("1: För att addera talen");
            Console.WriteLine("2: För att subtrahera talen");
            Console.WriteLine("3: För att multiplicera talen");
            Console.WriteLine("4: För att dividera talen");

            switch (input.InputChoice())
            {
                case "1":
                    Console.WriteLine($"Svar: {calculations.Addition(num1, num2)}");
                    break;
                case "2":
                    Console.WriteLine($"Svar: {calculations.Subtraction(num1, num2)}");
                    break;
                case "3":
                    Console.WriteLine($"Svar: {calculations.Multiplication(num1, num2)}");
                    break;
                case "4":
                    //låter användaren mata in ett nytt nummer ifall num2 är 0
                    while (num2 == 0)
                    {
                        Console.WriteLine("skriv in ett tal som inte är 0");

                        num2 = input.InputNumber(Console.ReadLine()!);
                    }
                    Console.WriteLine($"Svar: {calculations.Division(num1, num2)}");
                    break;
                case "xyzzy":
                    Console.WriteLine(input.EasterEgg());
                    break;
                case "quit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Du angav inte ett giltigt alternativ");
                    break;


            }
        }
    }
}
