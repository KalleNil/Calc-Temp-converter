using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using Individuell_inlämning;

namespace Individuell_inlämning
{
    //easteregg - Fahrenheit och celsius till Rankine
    public class MyEasterEgg
    {
        public decimal CelsiusToRankine(decimal celsius) => celsius * 493.47m;

        public decimal FahrenheitToRankine(decimal fahreinheit) => fahreinheit * 460.67m;
    }
}
