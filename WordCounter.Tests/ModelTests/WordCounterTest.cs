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
      CountRepeats newWord = new CountRepeats("am", "I am happy, I Am sad, I AM lucky, I aM glad?");

      int expected = 4;

      //Action
      int result = newWord.CountWords();

      //Assert
      Assert.AreEqual(expected, result);
    }
  }
}
