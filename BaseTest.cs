using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookJunction
{
    [TestFixture]
    public class BaseTest
    {
        public IWebDriver driver;
        public int defaultTimeOut;
        public int extendedTimeOut;

        [SetUp]
        public void Setup()
        {
            defaultTimeOut = 1000;
            extendedTimeOut = 5000;
            driver = new ChromeDriver("C:\\Payer\\");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.com/");
            Thread.Sleep(defaultTimeOut);
        }

        [TearDown]
        public void CleanUp()
        {
            Thread.Sleep(defaultTimeOut);
            driver.Close();
            driver.Quit();
        }
    }
}
