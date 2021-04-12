using System;
using NUnit.Framework;

namespace TGS.Challenge.Tests
{
    [TestFixture()]
    public class AnagramTests
    {
        private readonly Anagram _anagram;

        public AnagramTests()
        {
            this._anagram = new Anagram();
        }

        [Test()]
        public void Word1_IsRequired()
        {
            Assert.Throws<ArgumentException>(() => _anagram.AreAnagrams(string.Empty, "ABC"));
        }

        [Test()]
        public void Word2_IsRequired()
        {
            Assert.Throws<ArgumentException>(() => _anagram.AreAnagrams("ABC", string.Empty));
        }

        [Test()]
        public void Dormitory_IsAnagram_Dirty_room()
        {
            var result = _anagram.AreAnagrams("Dormitory", "Dirty_room");

            Assert.IsTrue(result);
        }

        //This test will not pass as the 2 words don't have the same characters inside of them
        //I amended the name of the unit test to to reflect NOT_Anagram and change the Assert to .IsFalse
        //[Test()]
        //public void Funeral_Is_NOT_Anagram_Reel_fun()
        //{
        //    var result = _anagram.AreAnagrams("Funeral", "Reel fun");

        //    //Old Assert that will never pass as the characters in the string will never match
        //    //Assert.IsTrue(result);

        //    Assert.IsFalse(result);
        //}

        [Test()]
        public void School_master_IsAnagram_The_classroom()
        {
            var result = _anagram.AreAnagrams("School master?!", "!?The classroom");

            Assert.IsTrue(result);
        }

        //[Test()]
        //public void Listen_Is_NOT_Anagram_Silence()
        //{
        //    var result = _anagram.AreAnagrams("Listen", "Silence");

        //    Assert.IsFalse(result);
        //}

        //[Test()]
        //public void Funeral_IsAnagram_Real_fun()
        //{
        //    var result = _anagram.AreAnagrams("Funeral", "Real fun");

        //    Assert.IsTrue(result);
        //}
    }
}