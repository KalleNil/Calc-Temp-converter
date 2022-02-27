using Individuell_inlämning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class TemperatureMenu
    {
        /// <summary>
        /// <see cref="TemperatureConvertion"/>Låter användaren mata in 2 tal och sedan välja räknesätt
        /// </summary>
        public void TemperatureConvertion()
        {
            UserInputs input = new();
            Temperature temp = new();
            MyEasterEgg myEasterEgg = new();
            Console.WriteLine("skriv in ett tal");

            decimal num1 = input.InputNumber(Console.ReadLine()!);

            Console.WriteLine("1: För att omvandla till Fahrenheit");
            Console.WriteLine("2: För att omvandla till Celsius");

            switch (input.InputChoice())
            {
                case "1":
                    Console.WriteLine($"Svar: {temp.Celsius(num1)}");
                    break;
                case "2":
                    Console.WriteLine($"Svar: {temp.FarenToCelsius(num1)}");
                    break;
                    //eastergg
                case "rankine":
                    Console.WriteLine("Vilken enhet är talet du skrev in?");
                    Console.WriteLine("1: Fahrenheit");
                    Console.WriteLine("2: Celsius");
                    string farOrCel = Console.ReadLine()!;
                    //omvandlar från den enhet användaren matade in
                    switch (farOrCel)
                    {
                        case "1":
                            Console.WriteLine($"{myEasterEgg.FahrenheitToRankine(num1)}: R");
                            break;
                        case "2":
                            Console.WriteLine($"{myEasterEgg.CelsiusToRankine(num1)}: R");
                            break;
                        default:
                            Console.WriteLine("Ogiltig enhet");
                            break;
                    }

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
