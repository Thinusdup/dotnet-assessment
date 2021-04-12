using System;
using NUnit.Framework;


namespace TGS.Challenge.Tests
{
    [TestFixture()]
    public class FormatNumberTests
    {
        private readonly FormatNumber _formatNumber;
        
        public FormatNumberTests()
        {
            this._formatNumber = new FormatNumber();
        }

        [Test()]
        public void NegativeNumber_Throws_ArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _formatNumber.Format(-1));
        }

        [Test()]
        public void BiggerThanMaxNumber_Throws_ArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _formatNumber.Format(1000000001));
        }

        [Test()]
        public void Value_1_Returns_ValidString()
        {
            var formatted = _formatNumber.Format(1);

            Assert.AreEqual("1", formatted);
        }

        //Amend test to reflect the correct number as per the unit test description
        [Test()]
        public void Value_10_Returns_ValidString()
        {
            //Original test copy/past from previous test
            //var formatted = _formatNumber.Format(1);

            //Amended the value pass in to 10 as per test description
            var formatted = _formatNumber.Format(10);

            Assert.AreEqual("10", formatted);
        }

        //Amend test to reflect the correct number as per the unit test description
        //Amend AreEqual value to reflect the correct value as per the challenge 
        [Test()]
        public void Value_100_Returns_ValidString()
        {
            //Original test copy/past from previous test
            //var formatted = _formatNumber.Format(1);

            //Amended the value pass in to 100 as per test description
            var formatted = _formatNumber.Format(100);

            //Original test not correct AreEqual stipilated as per the challenge
            //Assert.AreEqual("1,00", formatted);

            //New AreEqual value 100
            Assert.AreEqual("100", formatted);
        }

        //Amend test to reflect the correct number as per the unit test description
        [Test()]
        public void Value_1000_Returns_ValidString()
        {
            //Original test copy/past from previous test
            //var formatted = _formatNumber.Format(1);

            //Amended the value pass in to 1000 as per test description
            var formatted = _formatNumber.Format(1000);

            Assert.AreEqual("1,000", formatted);
        }

        //Amend test to reflect the correct number as per the unit test description
        [Test()]
        public void Value_10000_Returns_ValidString()
        {
            //Original test copy/past from previous test
            //var formatted = _formatNumber.Format(1);

            //Amended the value pass in to 10000 as per test description
            var formatted = _formatNumber.Format(10000);

            Assert.AreEqual("10,000", formatted);
        }

        //Amend test to reflect the correct number as per the unit test description
        [Test()]
        public void Value_100000_Returns_ValidString()
        {
            //Original test copy/past from previous test
            //var formatted = _formatNumber.Format(1);

            //Amended the value pass in to 100000 as per test description
            var formatted = _formatNumber.Format(100000);

            Assert.AreEqual("100,000", formatted);
        }

        //Amend test to reflect the correct number as per the unit test description
        [Test()]
        public void Value_1000000_Returns_ValidString()
        {
            //Original test copy/past from previous test
            //var formatted = _formatNumber.Format(1);

            //Amended the value pass in to 1000000 as per test description
            var formatted = _formatNumber.Format(1000000);

            Assert.AreEqual("1,000,000", formatted);
        }

        //Amend test to reflect the correct number as per the unit test description
        [Test()]
        public void Value_35235235_Returns_ValidString()
        {
            //Original test copy/past from previous test
            //var formatted = _formatNumber.Format(1);

            //Amended the value pass in to 35235235 as per test description
            var formatted = _formatNumber.Format(35235235);

            //Original test not correct AreEqual stipilated as per the challenge
            //Assert.AreEqual("35,2352,35", formatted);

            //New AreEqual value corrected 35,235,235
            Assert.AreEqual("35,235,235", formatted);
        }
    }
}