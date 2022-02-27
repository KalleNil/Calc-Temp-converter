using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individuell_inlämning
{

    public class Calculations
    {
        /// <summary>
        /// adderar två tal
        /// </summary>
        /// <param name="num1">vänster term</param>
        /// <param name="num2">höger term</param>
        /// <returns>returnerar summan av termerna</returns>
        public decimal Addition(decimal num1, decimal num2) => num1 + num2;
        /// <summary>
        /// subtraherar två tal
        /// </summary>
        /// <param name="num1">vänster term</param>
        /// <param name="num2">höger term</param>
        /// <returns>returnerar summan av vänster term minus höger term</returns>
        public decimal Subtraction(decimal num1, decimal num2) => num1 - num2;
        /// <summary>
        /// dividerar två tal
        /// </summary>
        /// <param name="num1">täljaren</param>
        /// <param name="num2">nämnaren</param>
        /// <returns>returnerar kvoten</returns>
        public decimal Division(decimal num1, decimal num2) => num1 / num2;

        /// <summary>
        /// multiplicerar två tal
        /// </summary>
        /// <param name="num1">vänster faktor</param>
        /// <param name="num2">höger faktor</param>
        /// <returns>returnerar produkten</returns>
        public decimal Multiplication(decimal num1, decimal num2) => num1 * num2;

    }
}
