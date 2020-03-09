using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    [TestFixture]
    class TestYandex : BasePage
    {
        public StartYandexPage startYandexPage;
        public TestYandex()
        {
            startYandexPage = new StartYandexPage();
        }

        [Test]
        public void Test3FindYandex()
        {
            startYandexPage.OpenStartYandexPage();
            startYandexPage.FindSomeText("meow");
        }

        //[Test]
        //public void Test4Yamail()
        //{
        //    startYandexPage.OpenStartYandexPage();
        //    startYandexPage.OpenYamail();
        //}

        [OneTimeTearDown]
        public void Close()
        {
            InstDriver.CloseDriver();
        }
    }
}
