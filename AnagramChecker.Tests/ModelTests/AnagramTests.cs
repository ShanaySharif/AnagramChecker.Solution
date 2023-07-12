using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramChecker.Models;
using System.Collections.Generic;
using System;

namespace AnagramChecker.Tests
{

    [TestClass]

    public class vocabTests
    {

        [TestMethod]
    
        public void VocabConstructor_CreatesInstanceOfVocab_Vocab()
        {
            Vocab newVocab = new Vocab();
            Assert.AreEqual(typeof(Vocab), newVocab.GetType());
        }

        [TestMethod]
        public void IsAnagram()

        {
          string inputtedWordOne = "Listen";
          string inputtedWordTwo = "Silent";
          Vocab newVocab = new Vocab();

          //Assert
          bool result = newVocab.IsAnagram(inputtedWordOne, inputtedWordTwo);

          Assert.IsTrue(result);
      
        }
    }

}