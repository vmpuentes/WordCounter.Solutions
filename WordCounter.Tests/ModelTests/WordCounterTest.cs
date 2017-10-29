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
      CountRepeats newWord = new CountRepeats("am", "I am happy, I am sad, I am lucky, I am glad?");

      int expected = 4;

      //Action
      int result = newWord.CountWords();

      //Assert
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void UserInputWord_CountReapeats_TotalCaseSense()
    {
      // Arrange
      CountRepeats newWord = new CountRepeats("am","I am happy, I aM sad, I Am lucky, I AM glad?");

      int expected = 4;

      // Action
      int result = newWord.CountWords();

      // Assert
      Assert.AreEqual(expected, result);
    }
  }
}
