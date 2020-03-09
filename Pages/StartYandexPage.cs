using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    class StartYandexPage : BasePage
    {
        private IWebElement searchField;
        private IWebElement searchButton;
        private IWebElement entrybutton;
        private IWebElement loginfield;

        public StartYandexPage() { }

        public void FindSomeText(string searchText)
        {
            searchField = InstDriver.GetElement(By.XPath("//*[@id='text']"));
            searchButton = InstDriver.GetElement(By.XPath("//*[@role='button']"));
            searchField.SendKeys(searchText);
            searchButton.Click();
        }

        public void OpenYamail()
        {
            entrybutton = InstDriver.GetElement(By.XPath("/html/body/div[1]/div[1]/div/div[1]/div/a[1]"));
            entrybutton.Click();
            
            loginfield = InstDriver.GetElement(By.XPath("//*[@id='passp - field - login']"));
            //*********
        }

        public void OpenStartYandexPage()
        {
            InstDriver.OpenPage(@"http://yandex.by");
        }
    }
}
