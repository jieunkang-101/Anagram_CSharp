using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System.Collections.Generic;
using System;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramsTests 
  {
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      List<Anagrams> userInputList = new List<Anagrams>();
      Anagrams newAnagrams = new Anagrams("test", userInputList);
      Assert.AreEqual(typeof(Anagrams), newAnagrams.GetType());
    }
    [TestMethod]
    public void CheckWord_SplitWord_ReturnSplitWord()
    {
      List<Anagrams> userInputList = new List<Anagrams>();
      Anagrams newAnagrams = new Anagrams("bread", userInputList);
      // string[] wordArr = {"b","r","e","a","d"};
      string sortedWord = "abder";
      // foreach (var value in wordArr)
      // {
      //   Console.WriteLine(value);
      // }
      Assert.AreEqual(Anagrams.CheckWord("bread"), sortedWord);
    }
  }
}