using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individuell_inlämning
{
    public class Temperature
    {
        //Något överflödig felhantering eftersom att typen på parametern aldrig kan vara något annat än decimal iom felhanteringen på InputNumber() funktionen.
        /// <summary>
        /// omvandlar celsius till fahrenheit
        /// </summary>
        /// <param name="celsius">Användarens inmatning av celsius</param>
        /// <returns></returns>
        public decimal Celsius(decimal celsius)
        {
            try
            {
                return decimal.Round((celsius * 9) / 5 + 32, 2);
            }
            catch
            {
                Console.WriteLine("Testa igen");
                return Celsius(0);
            }
        }
        /// <summary>
        /// omvandlar celsius till fahrenheit
        /// </summary>
        /// <param name="fahrenheit">Användarens inmatning av farenheit</param>
        /// <returns></returns>
        public decimal FarenToCelsius(decimal fahrenheit)
        {
            try
            {
                return decimal.Round((fahrenheit - 32) * 5 / 9, 2);
            }
            catch
            {
                Console.WriteLine("Testa igen");
                return FarenToCelsius(0);
            }

            
        }
    }
}
