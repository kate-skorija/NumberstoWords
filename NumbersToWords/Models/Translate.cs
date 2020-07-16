using System.Collections.Generic;
using System;
using System.Globalization;

namespace NumbersToWords.Models
{
  public class Translate
  {
    public int Number { get; }
    private static Dictionary<char, string> _oneToNine = new Dictionary<char, string>() { {'1', "one"}, {'2', "two"}, {'3', "three"}, {'4', "four"}, {'5', "five"}, {'6', "six"}, {'7', "seven"}, {'8', "eight"}, {'9', "nine"} };
    private static Dictionary<char, string> _tenToNineteen = new Dictionary<char, string>() { {'0', "ten"}, {'1', "eleven"}, {'2', "twelve"}, {'3', "thirteen"}, {'4', "fourteen"}, {'5', "fifteen"}, {'6', "sixteen"}, {'7', "seventeen"}, {'8', "eighteen"}, {'9', "nineteen"} };
    private static Dictionary<char, string> _tensPlace = new Dictionary<char, string>() { {'2', "twenty"}, {'3', "thirty"}, {'4', "forty"}, {'5', "fifty"}, {'6', "sixty"}, {'7', "seventy"}, {'8', "eighty"}, {'9', "ninety"} };
    public Translate(int number)
    {
      Number = number;
    }
    //23
    public string TranslateNumber()
    {
      string result = "";
      string numberString = Number.ToString();
      char[] numberCharArray = numberString.ToCharArray();
      
      for(int index = numberCharArray.Length - 1; index >= 0; index--)
      {
        char indexChar = Convert.ToChar(index);
        if (numberCharArray.Length == 2 && numberCharArray[0] == '1')
        {
          result = (_tenToNineteen[numberCharArray[indexChar]]).ToString();
          break;
        }
        else if (numberCharArray.Length == 2 && numberCharArray[0] != '1')
        {
          result += (_tensPlace[numberCharArray[0]] + " " +  _oneToNine[numberCharArray[indexChar]]).ToString();
          break;
        }
        else
        {
          result += (_oneToNine[numberCharArray[indexChar]]).ToString();
        }
      }
      return result;
    }
  }
}