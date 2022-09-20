using RomanNumeralKata;
using System;
using TechTalk.SpecFlow;

namespace SpecFlow.StepDefinitions
{
    [Binding]
    public class RomanNumeralKataStepDefinitions
    {
        private ScenarioContext _scenarioContext;
        private RomanToNumber _romanToNumber;
        private string _text;

        public RomanNumeralKataStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _romanToNumber = new RomanToNumber();
        }
        
        [Given(@"the roman string is ""([^""]*)""")]
        public void GivenTheRomanCharIs(string text)
        {
            _text = text;
        }

        [When(@"I request of the conversion of char\(s\) into a Number")]
        public void WhenIRequestOfTheConversionOfCharSIntoANumber()
        {
            try
            {
                _scenarioContext["Result"] = _romanToNumber.RomanToInt(_text);
            }
            catch(Exception ex)
            {
                _scenarioContext["Exception"] = ex;
            }
        }

        [Then(@"the result of conversion to Number will be (.*)")]
        public void ThenTheResultOfConversionToNumberWillBe(int number)
        {
            Assert.Equal(number, (int)_scenarioContext["Result"]);
        }


        [Then(@"it throws exception")]
        public void ThenItThrowsException()
        {
            var exception = _scenarioContext["Exception"];
            Assert.NotNull(exception);
        }
    }
}
