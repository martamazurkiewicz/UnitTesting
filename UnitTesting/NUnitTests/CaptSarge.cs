using App;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTests
{
    [TestFixture]
    class CaptSarge
    {
        [Test]
        public void AddressTest()
        {
            MainPageViewModel testAd = new MainPageViewModel();
            testAd.Address = "desu";
            testAd.SignIn.Execute(null);
            string output = testAd.AddressOutput;
            Assert.AreEqual(output, "desu");
        }
    }
}
