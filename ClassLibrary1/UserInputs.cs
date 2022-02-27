using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individuell_inlämning
{
    public class UserInputs
    {

        /// <summary>
        ///Låter användaren göra en input
        ///felhantering vid input av en sträng som inte är konverterbar
        /// <param name="userInput"></param>
        /// <returns>ett decimaltal</returns>
        /// </summary>

        public decimal InputNumber(string userInput)
        {
            //Eftersom att testet skall fungera utan någon "mocking" behöver vi använda if satsen för att undvika Console.ReadLine() metoden i testet
            if (userInput == null)
            {
                Console.WriteLine("skriv in ett tal");

                userInput = Console.ReadLine()!;
            }
            if (userInput == "xyzzy")
            {
                Console.WriteLine(EasterEgg());
            }
            else if (userInput == "quit")
            {
                Environment.Exit(0);
            }
            try
            {
                decimal number = Convert.ToDecimal(userInput);
                return number;
            }
            catch
            {
                //returneringen av null gör det möjligt för användaren att mata in en ny sträng på rad 24
                Console.WriteLine("Testa igen");
                return InputNumber(null!);


            } 
        }


        //Låter användaren mata in en sträng
        public string InputChoice() => Console.ReadLine()!;

        //skriver ut våran easteregg sträng
        public string EasterEgg() => "Nothing happens";


    }
}
