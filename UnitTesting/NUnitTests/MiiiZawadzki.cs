using NUnit.Framework;
using App;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTests
{
    [TestFixture]
    public class MiiiZawadzki
    {
        [Test]
        public void AgeEqualTest()
        {
            MainPageViewModel mainPageViewModel = new MainPageViewModel();
            mainPageViewModel.Age = "18";
            mainPageViewModel.SignIn.Execute("null");
            Assert.AreEqual(mainPageViewModel.Age, mainPageViewModel.AgeOutput);
        }
    }
}
