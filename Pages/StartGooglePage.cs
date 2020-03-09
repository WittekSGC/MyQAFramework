using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    public class StartGooglePage : BasePage
    {
        private IWebElement searchField;
        private IWebElement loginfield;
        private IWebElement passwordfield;
        private IWebElement linktogmail;
        private IWebElement entrybutton;
        private string gmaillogin = "zoludovv@gmail.com";
        private string gmailpassword = "lurame15";


        public StartGooglePage()
        {
            
        }

        public void InputingSearchText(string text)
        {
            searchField = InstDriver.GetElement(By.XPath("//input[@name = 'q']"));
            searchField.SendKeys(text);
            searchField.SendKeys(Keys.Enter);
        }

        public void LogInGmail()
        {
            linktogmail = InstDriver.GetElement(By.XPath("//*[@id='rso']/div/div/div[1]/div/div/div[1]/a"));
            linktogmail.Click();

            entrybutton = InstDriver.GetElement(By.XPath("/html/body/div[2]/div[1]/div[4]/ul[1]/li[2]/a"));
            entrybutton.Click();

            loginfield = InstDriver.GetElement(By.XPath("//*[@id='identifierId']"));
            loginfield.SendKeys(gmaillogin);
            loginfield.Submit();

            passwordfield = InstDriver.GetElement(By.XPath("//*[@id='recoveryIdentifierId']"));
            passwordfield.SendKeys(gmailpassword);
            passwordfield.Submit();
        }

        public void OpenStartGooglePage()
        {
            InstDriver.OpenPage(@"http:\\google.com");
        }
    }
}
