using System;
using NUnit.Framework;

namespace TGS.Challenge.Tests
{
    [TestFixture()]
    public class VowelCountTests
    {
        private readonly VowelCount _vowelCount;

        public VowelCountTests()
        {
            this._vowelCount = new VowelCount();
        }

        [Test()]
        public void Value_IsRequired()
        {
            Assert.Throws<ArgumentException>(() => _vowelCount.Count(string.Empty));
        }

        //Original Test:Assert.AreEqual(6, count);
        //this will always fail as the number of characters you pass in is only 5
        //I amended the test to equal the correct amount of characters
        [Test()]
        public void AEIOU_Returns_Correct_Count()
        {
            var count = _vowelCount.Count("AEIOU");

            //Amended value from 6 to 5
            Assert.AreEqual(5, count);
        }

        [Test()]
        public void lmnpqr_Returns_Correct_Count()
        {
            var count = _vowelCount.Count("lmnpqr");

            Assert.AreEqual(0, count);
        }

        //I changed the input of the unit test to the description of the unit test 
        //I believe this was a copy/paste test and the developer forgot to change the input from the previous test
        [Test()]
        public void abcdefghijklmnopqrstuvwxyz_Returns_Correct_Count()
        {
            //Original value
            //var count = _vowelCount.Count("lmnpqr");
            
            //Updated Value based on test description
            var count = _vowelCount.Count("abcdefghijklmnopqrstuvwxyz");
          
            Assert.AreNotEqual(5, count);        
        }

        [Test()]
        public void Howmanycanyoufind_Returns_Correct_Count()
        {
            var count = _vowelCount.Count("How many can you find");

            Assert.AreEqual(6, count);
        }
    }
}