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
      Translate newTranslate = new Translate();
      Assert.AreEqual(typeof(Translate), newTranslate.GetType());
    }
    [TestMethod]
    public void GetNumber_ReturnsNumber_Int()
    {
      int testNumber = 5;
      Translate newTranslate = new Translate();
      int result = newTranslate.Number;
      Assert.AreEqual(testNumber, result);
    }
  }
}