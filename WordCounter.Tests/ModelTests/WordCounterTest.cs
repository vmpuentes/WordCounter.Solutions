using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class ReapeatCounterTest
  {
    [TestMethod]
    public void UserInputWord_CountReapeats_Total()
    {
      //Arrange
      CountUserWords newUserWord = new CountUserWords("Hello", "Hello");
      var expected = 1;

      //Action
      var result = newUserWord.CountWords();

      //Assert
      Assert.AreEqual(expected, result);
      Console.WriteLine(result);
    }
  }
}
