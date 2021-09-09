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
            Assert.AreNotEqual(initialPrefetchLength, currentPrefetchLength);
        }

        [TestMethod]
        public void AssertUserTempLength() 
        {
            Repository userTemp = new UserTemp();
            int initialUserTempLength = userTemp.Files;
            userTemp.Delete();
            int currentUserTempLength = userTemp.Files;
            Assert.AreNotEqual(initialUserTempLength, currentUserTempLength);
        }

        [TestMethod]
        public void AssertWinTempLength() 
        {
            Repository winTemp = new WinTemp();
            int initialWinTempLength = winTemp.Files;
            winTemp.Delete();
            int currentWinTempLength = winTemp.Files;
            Assert.AreNotEqual(initialWinTempLength, currentWinTempLength);
        }
    }
}