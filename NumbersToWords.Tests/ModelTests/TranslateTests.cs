using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using NumbersToWords.Models;
using System;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class TranslateTests
  {
    [TestMethod]
    public void TranslateConstructor_CreatesInstanceofTranslate_Translate()
    {
      Translate newTranslate = new Translate(5);
      Assert.AreEqual(typeof(Translate), newTranslate.GetType());
    }
    [TestMethod]
    public void GetNumber_ReturnsNumber_Int()
    {
      int testNumber = 5;
      Translate newTranslate = new Translate(testNumber);
      int result = newTranslate.Number;
      Assert.AreEqual(testNumber, result);
    }
    [TestMethod]
    public void TranslateNumber_ReturnString_String()
    {
      int testNumber = 10;
      Translate newTranslate = new Translate(testNumber);
      string testString = "ten";
      string result = newTranslate.TranslateNumber();
      Assert.AreEqual(testString, result);
    }
  }
}