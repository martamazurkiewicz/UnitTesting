using App;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTests
{
    [TestFixture]
    class Sawitom
    {
        [Test]
        public void PhoneNumberTest()
        {
            MainPageViewModel test = new MainPageViewModel();
            string t1 = "213742069";
            test.PhoneNumber = t1;
            test.SignIn.Execute(null);
            Assert.AreEqual(test.PhoneNumberOutput, t1);
        }
    }
}
