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
  }
}