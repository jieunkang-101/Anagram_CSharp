using System;
using System.Collections.Generic;

namespace Anagram.Models
{
  public class Anagrams
  {
    public string Word { get; set; }
    public static List<Anagrams> _inputList { get; set; }= new List<Anagrams>{ };

    public Anagrams(string word, List<Anagrams> inputList)
    {
      Word = word;
      _inputList = inputList;
    }

    public static string CheckWord(string word)
    {
      char[] wordArr = word.ToCharArray();
      Array.Sort(wordArr); 
      string result = string.Join("", wordArr);
      return result;

      // string newString = "";

      // foreach(string character in wordArr)
      // {
      //   newString += character;
      // }
      // return newString;
    }

  }
}