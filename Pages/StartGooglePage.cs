using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    public class StartGooglePage : BasePage
    {
        private IWebElement searchField => InstDriver.GetElement(By.XPath("//input[@name = 'q']"));
        private IWebElement loginfield => InstDriver.GetElement(By.XPath("//*[@id='identifierId']"));
        private IWebElement passwordfield => InstDriver.GetElement(By.XPath("//*[@id='recoveryIdentifierId']"));
        private IWebElement linktogmail => InstDriver.GetElement(By.XPath("//*[@id='rso']/div/div/div[1]/div/div/div[1]/a"));
        private IWebElement entrybutton => InstDriver.GetElement(By.XPath("/html/body/div[2]/div[1]/div[4]/ul[1]/li[2]/a"));
        
        private string gmaillogin = "";
        private string gmailpassword = "";


        public StartGooglePage()
        {
            
        }

        public void InputingSearchText(string text)
        {
            searchField.SendKeys(text);
            searchField.SendKeys(Keys.Enter);
        }

        public void LogInGmail()
        {
            linktogmail.Click();
            entrybutton.Click();
            InstDriver.SwitchTab();
            loginfield.SendKeys(gmaillogin);
            loginfield.Submit();
            passwordfield.SendKeys(gmailpassword);
            passwordfield.Submit();

        }

        public void OpenStartGooglePage()
        {
            InstDriver.OpenPage(@"http:\\google.com");
        }
    }
}
