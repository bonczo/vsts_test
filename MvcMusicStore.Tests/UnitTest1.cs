using MvcMusicStore.Controllers;
using System;
using Xunit;

namespace MvcMusicStore.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Test1()
        {
            Assert.Throws<System.TypeInitializationException>(() => { HomeController hm = new HomeController(); });
        }
    }
}
