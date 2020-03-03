using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System.Collections.Generic;
using System;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramsTests : IDisposable
  {

    public void Dispose()
    {
      //Anagrams.ClearAll();
    }

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      List<string> userInputList = new List<string>();
      Anagrams newAnagrams = new Anagrams("test", userInputList);
      Assert.AreEqual(typeof(Anagrams), newAnagrams.GetType());
    }

    [TestMethod]
    public void SortWord_SortWordByAlphabeticlaOrder_SortedWord()
    {
      List<string> userInputList = new List<string>();
      Anagrams newAnagrams = new Anagrams("bread", userInputList);
      string sortedWord = "abder";
      Assert.AreEqual(Anagrams.SortWord("bread"), sortedWord);
    }

    [TestMethod]
    public void CheckAnagrams_CompareWordToList_True()
    {
      List<string> userInputList = new List<string>(){"water","bear","beard"};
      Anagrams newAnagrams = new Anagrams("bread", userInputList);
      Assert.AreEqual(true, Anagrams.CheckAnagrams("bread", userInputList));
    }
  }
}