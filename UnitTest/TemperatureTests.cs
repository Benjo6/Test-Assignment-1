

using TemperatureKata;

namespace UnitTests
{
    [TestFixture]
    public class TemperatureTests
    {
        private Temperature _temperature = new Temperature();

        [Test]
        public void FahrenheitToCelsiusTest()
        {
            Assert.That(_temperature.FahrenheitToCelsius(320), Is.EqualTo(160));
            Assert.That(160, Is.Not.EqualTo(_temperature.FahrenheitToCelsius(400)));
        }
        [Test]
        public void FahrenheitToCelsiusExceptionTest()
        {
            Assert.Throws<ArgumentException>(()=>_temperature.FahrenheitToCelsius(-500));
        }
        [Test]
        public void FahrenheitToKelvinTest()
        {
            Assert.That(_temperature.FahrenheitToKelvin(320), Is.EqualTo(433.15));
            Assert.That(433.15, Is.Not.EqualTo(_temperature.FahrenheitToKelvin(400)));
        }
        [Test]
        public void FahrenheitToKelvinExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => _temperature.FahrenheitToKelvin(-500));

        }
        [Test]
        public void CelsiusToFahrenheitTest()
        {
            Assert.That(_temperature.CelsiusToFahrenheit(150), Is.EqualTo(302));
            Assert.That(302, Is.Not.EqualTo(_temperature.CelsiusToFahrenheit(160)));
        }
        [Test]
        public void CelsiusToFahrenheitExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => _temperature.CelsiusToFahrenheit(-300));

        }
        [Test]
        public void CelsiusToKelvinTest()
        {
            Assert.That(_temperature.CelsiusToKelvin(150), Is.EqualTo(423.15));
            Assert.That(423.15, Is.Not.EqualTo(_temperature.CelsiusToKelvin(160)));
        }
        [Test]
        public void CelsiusToKelvinExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => _temperature.CelsiusToKelvin(-300));

        }
        [Test]
        public void KelvinToFahrenheitTest()
        {
            Assert.That(_temperature.KelvinToFahrenheit(600), Is.EqualTo(620.33));
            Assert.That(620.33, Is.Not.EqualTo(_temperature.KelvinToFahrenheit(610)));
        }
        [Test]
        public void KelvinToFahrenheitExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => _temperature.KelvinToFahrenheit(-1));

        }
        [Test]
        public void KelvinToCelsiusTest()
        {
            Assert.That(_temperature.KelvinToCelsius(600), Is.EqualTo(326.85));
            Assert.That(326.85, Is.Not.EqualTo(_temperature.KelvinToCelsius(610)));
        }
        [Test]
        public void KelvinToCelsiusExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => _temperature.KelvinToCelsius(-1));

        }

    }
}