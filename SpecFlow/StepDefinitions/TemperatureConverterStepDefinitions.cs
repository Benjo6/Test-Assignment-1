using System;
using TechTalk.SpecFlow;
using TemperatureKata;

namespace SpecFlow.StepDefinitions
{
    [Binding]
    public class TemperatureConverterStepDefinitions
    {
        private double _fahrenheit = -500;
        private double _celsius = -500;
        private double _kelvin = -500;
        private Temperature _temperature;
        private ScenarioContext _scenarioContext;
        public TemperatureConverterStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _temperature = new Temperature();
        }
        [Given(@"the temperature value is (.*) degrees Fahrenheit")]
        public void GivenTheTemperatureValueIsDegreesFahrenheit(double fahrenheit)
        {
            _fahrenheit = fahrenheit;
        }
        [Given(@"the temperature value is (.*) degrees Celsius")]
        public void GivenTheTemperatureValueIsDegreesCelsius(double celsius)
        {
            _celsius = celsius;
        }

        [Given(@"the temperature value is (.*) degrees Kelvin")]
        public void GivenTheTemperatureValueIsDegreesKelvin(double kelvin)
        {
            _kelvin = kelvin;
        }
        [When(@"I request the conversion of this temperature into Celsius")]
        public void WhenIRequestTheConversionOfThisTemperatureIntoCelsius()
        {
            if(_kelvin != -500)
            {
                try
                {
                    _scenarioContext["KelvinToCelsius"] = _temperature.KelvinToCelsius(_kelvin);
                }
                catch(Exception ex)
                {
                    _scenarioContext["Exception"] = ex;
                }
            }
            else
            {
                try
                {
                    _scenarioContext["FahrenheitToCelsius"] = _temperature.FahrenheitToCelsius(_fahrenheit);
                }
                catch(Exception ex)
                {
                    _scenarioContext["Exception"] = ex;
                }
            }
        }
        [When(@"I request the conversion of this temperature into Kelvin")]
        public void WhenIRequestTheConversionOfThisTemperatureIntoKelvin()
        {
            if(_fahrenheit != -500)
            {
                try
                {
                    _scenarioContext["FahrenheitToKelvin"] = _temperature.FahrenheitToKelvin(_fahrenheit);
                }
                catch (Exception ex)
                {
                    _scenarioContext["Exception"] = ex;
                }
            }
            else
            {
                try
                {
                    _scenarioContext["CelsiusToKelvin"] = _temperature.CelsiusToKelvin(_celsius);
                }
                catch (Exception ex)
                {
                    _scenarioContext["Exception"] = ex;
                }
            }
        }
        [When(@"I request the conversion of this temperature into Fahrenheit")]
        public void WhenIRequestTheConversionOfThisTemperatureIntoFahrenheit()
        {
            if (_celsius != -500)
            {
                try
                {
                    _scenarioContext["CelsiusToFahrenheit"] = _temperature.CelsiusToFahrenheit(_celsius);
                }
                catch (Exception ex)
                {
                    _scenarioContext["Exception"] = ex;
                }
            }
            else
            {
                try
                {
                    _scenarioContext["KelvinToFahrenheit"] = _temperature.KelvinToFahrenheit(_kelvin);
                }
                catch (Exception ex)
                {
                    _scenarioContext["Exception"] = ex;
                }
            }
        }

        [Then(@"the result of conversion to Celsius will be (.*) degrees")]
        public void ThenTheResultOfConversionToCelsiusWillBeDegrees(double celsius)
        {
            if(_kelvin != -500)
            {
                Assert.Equal(celsius, (double)_scenarioContext["KelvinToCelsius"]);
            }
            else
            {
                Assert.Equal(celsius,(double)_scenarioContext["FahrenheitToCelsius"]);

            }
        }

        [Then(@"the result of conversion to Kelvin will be (.*) degrees")]
        public void ThenTheResultOfConversionToKelvinWillBeDegrees(double kelvin)
        {
            if (_fahrenheit != -500)
            {
                Assert.Equal(kelvin, (double)_scenarioContext["FahrenheitToKelvin"]);
            }
            else
            {
                Assert.Equal(kelvin, (double)_scenarioContext["CelsiusToKelvin"]);

            }
        }

       

        [Then(@"the result of conversion to Fahrenheit will be (.*) degrees")]
        public void ThenTheResultOfConversionToFahrenheitWillBeDegrees(double fahrenheit)
        {
            if (_celsius != -500)
            {
                Assert.Equal(fahrenheit, (double)_scenarioContext["CelsiusToFahrenheit"]);

            }
            else
            {
                Assert.Equal(fahrenheit, (double)_scenarioContext["KelvinToFahrenheit"]); 
            }
        }
        [Then(@"it will throw an exception")]
        public void ThenItWillThrowAnException()
        {
            var exception = _scenarioContext["Exception"];
            Assert.NotNull(exception);
        }
    }
}
