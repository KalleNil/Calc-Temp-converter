using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Individuell_inlämning;
using System.IO;
using Xunit;

namespace TestUträkning
{
    public class InputTest
    {
        [Fact]
        //Kollar ifall konverteringen av string till decimal fungerar
        public void UserNumberInput()
        {
            UserInputs userInput = new();
            Assert.Equal(4,userInput.InputNumber("4"));
            Assert.NotEqual(5,userInput.InputNumber("4"));
            Assert.NotEqual(3,userInput.InputNumber("4"));
        }
        [Fact]
        //Säkerställer att det är rätt sträng som returneras
        public void UserInputXyzzy()
        {
            UserInputs userInput = new();
            Assert.Equal("Nothing happens", userInput.EasterEgg());
            Assert.NotEqual("Nothing happen", userInput.EasterEgg());
            Assert.NotEqual("312313", userInput.EasterEgg());
        } 
    }
}
