using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    /// <summary>
    /// Класс для хранения драйвера и управления драйвером
    /// </summary>
    public class Driver
    {
        private IWebDriver driver; //корневой драйвер браузера
        private static Driver driverInstance; //экзмепляр драйвера для работы

        private Driver()
        {
            driver = new ChromeDriver();
        }

        public static Driver GetDriverInstance()
        {
            if (driverInstance == null) driverInstance = new Driver();
            return driverInstance;
        }

        public void OpenPage(string url)
        {
            driver.Url = url;
        }

        public IWebElement GetElement(By locator)
        {

            return driver.FindElement(locator);
        }

        public void SwitchTab()
        {
           
        }

        public void CloseDriver()
        {
            driverInstance.driver.Close();
            //driver.Close();
            //or driver.Quit();
        }
    }
}
