using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    [TestFixture]
    class TestGoogle : BasePage
    {
        public StartGooglePage startGooglePage;

        public TestGoogle()
        {
            startGooglePage = new StartGooglePage();
        }

        [Test]
        public void Test1FindGoogle()
        {
            startGooglePage.OpenStartGooglePage();
            startGooglePage.InputingSearchText("meow");
        }

        //[Test]
        //public void Test2Find()
        //{
        //    startGooglePage.OpenStartGooglePage();
        //    startGooglePage.InputingSearchText("gmail login");
        //    startGooglePage.LogInGmail();
        //}
    }
}
