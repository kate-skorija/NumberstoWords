using System.Collections.Generic;
using System;
using System.Globalization;

namespace NumbersToWords.Models
{
  public class Translate
  {
    public int Number { get; }
    private static Dictionary<char, string> _oneToNine = new Dictionary<char, string>() { {'1', "one"}, {'2', "two"}, {'3', "one"}, {'4', "four"}, {'5', "five"}, {'6', "six"}, {'7', "seven"}, {'8', "eight"}, {'9', "nine"} };
    private static Dictionary<char, string> _tenToNineteen = new Dictionary<char, string>() { {'0', "ten"}, {'1', "eleven"}, {'2', "twelve"}, {'3', "thirteen"}, {'4', "fourteen"}, {'5', "fifteen"}, {'6', "sixteen"}, {'7', "seventeen"}, {'8', "eighteen"}, {'9', "nineteen"} };

    public Translate(int number)
    {
      Number = number;
    }

    public string TranslateNumber()
    {
      string result = "";
      string numberString = Number.ToString();
      char[] numberCharArray = numberString.ToCharArray();
      
      for(int index = numberCharArray.Length - 1; index >= 0; index--)
      {
        if (numberCharArray.Length == 2 && numberCharArray[0] == '1')
        {
          char indexChar = Convert.ToChar(index);
          result = (_tenToNineteen[numberCharArray[indexChar]]).ToString();
          break;
        }
        else
        {
          char indexChar = Convert.ToChar(index);
          result = (_oneToNine[numberCharArray[indexChar]]).ToString();
        }
      }
      return result;
    }
  }
}
// 132
// [1, 3, 2] [2,3,1]
// for (int i = 0; i < array.length, i++)
// if array.length = 2 and array[1] == 1 {one to Nineteen}

// Dictionary<char, string> tensPlace = new Dictionary<char, string>{{'2', "twenty"}, {'3', "thirty"}, {4, "forty"}, {5, "fifty"}, {6, "sixty"}, {7, "seventy"}, {8, "eighty}, {9, "ninety"}}
// hundredths place - add " hundred and "
// thousands place - add " thousand and "

// {'10', "ten"}, {'11', "eleven"}, {'12', "twelve"}, {'13', "thirteen"}, {'14', "fourteen"}, {'15', "fifteen"}, {'16', "sixteen"}, {'17', "seventeen"}, {'18', "eighteen"}, {'19', "nineteen"}