using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramChecker.Models;
using System.Collections.Generic;
using System;

namespace AnagramChecker.Tests
{

    [TestClass]

    public class anagramTests
    {

        [TestMethod]

        public void AnagramConstructor_CreatesInstanceOfAnagram_Anagram()
        {
            Anagram newAnagram = new Anagram();
            Assert.AreEqual(typeof(Anagram), newAnagram.GetType());
        }

        [TestMethod]
        public void IsAnagram()

        {
            string inputtedWordOne = "Listen";
            string inputtedWordTwo = "Silent";
            Anagram newAnagram = new Anagram();


            bool result = newAnagram.IsAnagram(inputtedWordOne, inputtedWordTwo); Assert.IsTrue(result);

        }

        [TestMethod]
        [DataRow("cat", "hat", false)]
        [DataRow("cat", "act", true)]
        [DataRow("cat", "cat", true)]
        [DataRow("cat", "at", false)]
        [DataRow("cat", "fact", false)]
        public void TestingAnagram_Functionality_Anagram(string a, string b, bool expected)
        {
            Anagram anagram = new Anagram();
            bool result = anagram.IsAnagram(a, b);
            Assert.AreEqual(expected, result);
        }
    }





}
