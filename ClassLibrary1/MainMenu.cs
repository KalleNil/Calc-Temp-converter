using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individuell_inlämning
{
    public class MainMenu
    {
       
        UserInputs input = new();

        //Menyval för matematiska uträkningar eller temperaturomvandling
        public void StartMenu()
        {
            CalculationMenu calculationMenu = new();
            TemperatureMenu temperatureMenu = new();

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("1: För att göra en uträkning av två tal");
            Console.WriteLine("2: För att omvandla Celsius till Fahrenheit eller tvärtom");
            Console.WriteLine("----------------------------------------------------------");


            switch (input.InputChoice())
            {
                case "1":
                    calculationMenu.Calculations();
                    break;
                case "2":
                    temperatureMenu.TemperatureConvertion();
                    break;
                case "xyzzy":
                    Console.WriteLine(input.EasterEgg());
                    StartMenu();
                    break;
                case "quit":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}
