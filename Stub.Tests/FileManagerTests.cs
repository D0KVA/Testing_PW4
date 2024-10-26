using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Stub.Tests
{
    [TestClass]
    public class FileManagerTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            FileManager fileManager = new FileManager();
            Assert.AreEqual(3, fileManager.FindLogFile(1024));
        }
    }
}
