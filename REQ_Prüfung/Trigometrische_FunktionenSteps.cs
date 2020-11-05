using System;
using TechTalk.SpecFlow;
using Xunit;

namespace REQ_Prüfung
{
    [Binding]
    public class Trigometrische_FunktionenSteps
    {
        double number, n;
        [Given(@"the first number is PI")]
        public void GivenTheFirstNumberIsPI()
        {
            number = Math.PI;
        }
        
        [When(@"sinus is taken")]
        public void WhenSinusIsTaken()
        {
            n = Math.Sin(number);
        }
        
        [When(@"cosinus is taken")]
        public void WhenCosinusIsTaken()
        {
            n = Math.Cos(number);
        }
        
        [When(@"tangens is taken")]
        public void WhenTangensIsTaken()
        {
            n = Math.Tan(number);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.Equal(p0, n, 5);
        }
    }
}
