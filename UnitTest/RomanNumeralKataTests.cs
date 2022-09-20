using RomanNumeralKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestFixture]
    public class RomanNumeralKataTests
    {
        private RomanToNumber _romanToNumber = new RomanToNumber(); 
        [Test]
        //This test failed first due to my exception not being able to handle multiple digits in a string with a fouled char.
        public void ExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => _romanToNumber.RomanToInt("T"));
            Assert.Throws<ArgumentException>(() => _romanToNumber.RomanToInt("4"));
            Assert.Throws<ArgumentException>(() => _romanToNumber.RomanToInt("$"));
            Assert.Throws<ArgumentException>(() => _romanToNumber.RomanToInt("LL$"));
            Assert.Throws<ArgumentException>(() => _romanToNumber.RomanToInt("ML^"));


        }

        //This test failed first due to me missing to add X into my Dictionary
        [Test]
        public void SimpleRomanCharTest()
        {
            Assert.That(_romanToNumber.RomanToInt("I"), Is.EqualTo(1));
            Assert.That(_romanToNumber.RomanToInt("V"), Is.EqualTo(5));
            Assert.That(_romanToNumber.RomanToInt("X"), Is.EqualTo(10));
            Assert.That(_romanToNumber.RomanToInt("L"), Is.EqualTo(50));
            Assert.That(_romanToNumber.RomanToInt("C"), Is.EqualTo(100));
            Assert.That(_romanToNumber.RomanToInt("D"), Is.EqualTo(500));
            Assert.That(_romanToNumber.RomanToInt("M"), Is.EqualTo(1000));

        }
        [Test]
        public void MultipleDigitsPlusRomanNumbers()
        {
            Assert.That(_romanToNumber.RomanToInt("II"), Is.EqualTo(2));
            Assert.That(_romanToNumber.RomanToInt("II"), Is.Not.EqualTo(3));
            Assert.That(_romanToNumber.RomanToInt("VI"), Is.EqualTo(6));
            Assert.That(_romanToNumber.RomanToInt("VI"), Is.Not.EqualTo(7));
            Assert.That(_romanToNumber.RomanToInt("VV"), Is.EqualTo(10));
            Assert.That(_romanToNumber.RomanToInt("VV"), Is.Not.EqualTo(11));

            Assert.That(_romanToNumber.RomanToInt("XI"), Is.EqualTo(11));
            Assert.That(_romanToNumber.RomanToInt("XV"), Is.EqualTo(15));
            Assert.That(_romanToNumber.RomanToInt("XX"), Is.EqualTo(20));

            Assert.That(_romanToNumber.RomanToInt("LI"), Is.EqualTo(51));
            Assert.That(_romanToNumber.RomanToInt("LV"), Is.EqualTo(55));
            Assert.That(_romanToNumber.RomanToInt("LX"), Is.EqualTo(60));
            Assert.That(_romanToNumber.RomanToInt("LL"), Is.EqualTo(100));


            Assert.That(_romanToNumber.RomanToInt("CI"), Is.EqualTo(101));
            Assert.That(_romanToNumber.RomanToInt("CV"), Is.EqualTo(105));
            Assert.That(_romanToNumber.RomanToInt("CX"), Is.EqualTo(110));
            Assert.That(_romanToNumber.RomanToInt("CL"), Is.EqualTo(150));
            Assert.That(_romanToNumber.RomanToInt("CC"), Is.EqualTo(200));


            Assert.That(_romanToNumber.RomanToInt("DI"), Is.EqualTo(501));
            Assert.That(_romanToNumber.RomanToInt("DV"), Is.EqualTo(505));
            Assert.That(_romanToNumber.RomanToInt("DX"), Is.EqualTo(510));
            Assert.That(_romanToNumber.RomanToInt("DL"), Is.EqualTo(550));
            Assert.That(_romanToNumber.RomanToInt("DC"), Is.EqualTo(600));
            Assert.That(_romanToNumber.RomanToInt("DD"), Is.EqualTo(1000));


            Assert.That(_romanToNumber.RomanToInt("MI"), Is.EqualTo(1001));
            Assert.That(_romanToNumber.RomanToInt("MV"), Is.EqualTo(1005));
            Assert.That(_romanToNumber.RomanToInt("MX"), Is.EqualTo(1010));
            Assert.That(_romanToNumber.RomanToInt("ML"), Is.EqualTo(1050));
            Assert.That(_romanToNumber.RomanToInt("MC"), Is.EqualTo(1100));
            Assert.That(_romanToNumber.RomanToInt("MD"), Is.EqualTo(1500));
            Assert.That(_romanToNumber.RomanToInt("MM"), Is.EqualTo(2000));




        }
        [Test]
        public void MultipleDigitsMinusRomanNumbers()
        {
            Assert.That(_romanToNumber.RomanToInt("IM"), Is.EqualTo(999));
            Assert.That(_romanToNumber.RomanToInt("VM"), Is.EqualTo(995));
            Assert.That(_romanToNumber.RomanToInt("XM"), Is.EqualTo(990));
            Assert.That(_romanToNumber.RomanToInt("LM"), Is.EqualTo(950));
            Assert.That(_romanToNumber.RomanToInt("CM"), Is.EqualTo(900));
            Assert.That(_romanToNumber.RomanToInt("DM"), Is.EqualTo(500));

            Assert.That(_romanToNumber.RomanToInt("ID"), Is.EqualTo(499));
            Assert.That(_romanToNumber.RomanToInt("VD"), Is.EqualTo(495));
            Assert.That(_romanToNumber.RomanToInt("XD"), Is.EqualTo(490));
            Assert.That(_romanToNumber.RomanToInt("LD"), Is.EqualTo(450));
            Assert.That(_romanToNumber.RomanToInt("CD"), Is.EqualTo(400));

            Assert.That(_romanToNumber.RomanToInt("IC"), Is.EqualTo(99));
            Assert.That(_romanToNumber.RomanToInt("VC"), Is.EqualTo(95));
            Assert.That(_romanToNumber.RomanToInt("XC"), Is.EqualTo(90));
            Assert.That(_romanToNumber.RomanToInt("LC"), Is.EqualTo(50));

            Assert.That(_romanToNumber.RomanToInt("IL"), Is.EqualTo(49));
            Assert.That(_romanToNumber.RomanToInt("VL"), Is.EqualTo(45));
            Assert.That(_romanToNumber.RomanToInt("XL"), Is.EqualTo(40));

            Assert.That(_romanToNumber.RomanToInt("IX"), Is.EqualTo(9));
            Assert.That(_romanToNumber.RomanToInt("VX"), Is.EqualTo(5));

            Assert.That(_romanToNumber.RomanToInt("IV"), Is.EqualTo(4));

        }
    }
}
