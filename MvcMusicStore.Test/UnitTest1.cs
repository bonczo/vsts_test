using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcMusicStore.Controllers;

namespace MvcMusicStore.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var hm = new HomeController();
            Assert.IsNotNull(hm);
        }
    }
}
