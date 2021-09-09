using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VSTempCleaner;

namespace TestTempCleaner
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void AssertPrefetchLength()
        {
            Repository prefetch = new Prefetch();
            int initialPrefetchLength = prefetch.Files;
            prefetch.Delete();
            int currentPrefetchLength = prefetch.Files;

            if (currentPrefetchLength == initialPrefetchLength)
                return;

            Assert.AreNotEqual(initialPrefetchLength, currentPrefetchLength);
        }

        [TestMethod]
        public void AssertUserTempLength() 
        {
            Repository userTemp = new UserTemp();
            int initialUserTempLength = userTemp.Files;
            userTemp.Delete();
            int currentUserTempLength = userTemp.Files;

            if (currentUserTempLength == initialUserTempLength)
                return;

            Assert.AreNotEqual(initialUserTempLength, currentUserTempLength);
        }

        [TestMethod]
        public void AssertWinTempLength() 
        {
            Repository winTemp = new WinTemp();
            int initialWinTempLength = winTemp.Files;
            winTemp.Delete();
            int currentWinTempLength = winTemp.Files;

            if (currentWinTempLength == initialWinTempLength)
                return;

            Assert.AreNotEqual(initialWinTempLength, currentWinTempLength);
        }
        
        [TestMethod]
        public void AssertPrefetchDeletion() 
        {
            int exceptionCode = -1;
            Repository prefetch = new Prefetch();
            int deletionResult = prefetch.Delete();

            if (deletionResult == exceptionCode)
                return;

            Assert.IsFalse(deletionResult == exceptionCode);
        }

        [TestMethod]
        public void AssertUserTempDeletion()
        {
            int exceptionCode = -1;
            Repository userTemp = new UserTemp();
            int deletionResult = userTemp.Delete();

            if (deletionResult == exceptionCode)
                return;

            Assert.IsFalse(deletionResult == exceptionCode);
        }

        [TestMethod]
        public void AssertWinTempDeletion()
        {
            int exceptionCode = -1;
            Repository winTemp = new UserTemp();
            int deletionResult = winTemp.Delete();

            if (deletionResult == exceptionCode)
                return;

            Assert.IsFalse(deletionResult == exceptionCode);
        }
    }
}