using System.Collections.Generic;
namespace NumbersToWords.Models
{
  public class Translate
  {
    public int Number { get; }

    public Translate(int number)
    {
      Number = number;
    }
  }
}
// 132
// [1, 3, 2] [2,3,1]
// for (int i = 0; i < array.length, i++)
// if array.length = 2 and array[1] == 1 {one to Nineteen}

// Dictionary<int, string> tensPlace = new Dictionary<int, string>{{2, "twenty"}, {3, "thirty"}, {4, "forty"}, {5, "fifty"}, {6, "sixty"}, {7, "seventy"}, {8, "eighty}, {9, "ninety"}}
// hundredths place - add " hundred and "
// thousands place - add " thousand and "

// Dictionary<int, string> oneToNineteen = new Dictionary<int, string>{{1, "one"},{2, "two"}{3, "one"}{4, "four"},{5, "five"}{6, "six"}{7, "seven"},{8, "eight"},{9, "nine"},{10, "ten"},{11, "eleven"}{12, "twelve"}{13, "thirteen"},{14, "fourteen"}{15, "fifteen"}{16, "sixteen"},{17, "seventeen"}{18, "eighteen"} {19, "nineteen"}}