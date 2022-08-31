using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookJunction
{
    public class BookJunctionElements
    {
        public int defaultTimeOut;
        public int extendedTimeOut;
        private IWebDriver driver;
        public BookJunctionElements(IWebDriver driver)
        {
            defaultTimeOut = 10;
            extendedTimeOut = 50;
            this.driver = driver;
        }
        public IWebElement googleSearchBox => driver.FindElement(By.Name("q"), extendedTimeOut);
        public IWebElement googleSearcButton => driver.FindElement(By.Name("btnK"), extendedTimeOut);
        public IWebElement bookStoreLink => driver.FindElement(By.XPath("//span[text()='https://www.booknet.co.il/']"), extendedTimeOut);
        public IWebElement menuButton => driver.FindElement(By.ClassName("menu"), extendedTimeOut);

        public IWebElement topCategories => driver.FindElement(By.Id("top-categories"), extendedTimeOut)
            .FindElement(By.XPath("//li[@data-id='250']/a"));

        // kids books
        public IWebElement kidsBooks => driver.FindElement(By.Id("sub-categories-container"), defaultTimeOut)
            .FindElement(By.ClassName("sub-categories-inner")).
            FindElements(By.ClassName("sub-cat-title")).First();
        
        //Select 2 books and add to basket
        public IWebElement cartButtonOne => driver.FindElements(By.ClassName("cart-btn2"), extendedTimeOut).First();
        public IWebElement operatorsOne => driver.FindElements(By.ClassName("oprs"), extendedTimeOut).Last();
        public IWebElement cartButtonTwo => driver.FindElements(By.ClassName("cart-btn2"), extendedTimeOut).ElementAt(1);
        public IWebElement operatorTwo => driver.FindElements(By.ClassName("oprs"), extendedTimeOut).First();
        public IWebElement image => driver.FindElement(By.XPath("//img[@src='https://www.booknet.co.il/Images/Site/Pages/0cfca824-8da8-4c9a-9ee6-65607367b3b3.png']"), extendedTimeOut);
        public IWebElement email => driver.FindElement(By.Id("email"), extendedTimeOut);
        public IWebElement customerFirstName => driver.FindElement(By.Id("customerFirstName"), extendedTimeOut);
        public IWebElement customerLastName => driver.FindElement(By.Id("customerLastName"), extendedTimeOut);
        public IWebElement phone => driver.FindElement(By.Id("phone"), extendedTimeOut);
        public IWebElement city => driver.FindElement(By.Id("city"), extendedTimeOut);
        public IWebElement street => driver.FindElement(By.Id("street"), extendedTimeOut);
        public IWebElement homenum => driver.FindElement(By.Id("homenum"), extendedTimeOut);
        public IWebElement isConfirm => driver.FindElement(By.Id("isConfirm"), extendedTimeOut);
        public IWebElement fornSubmitButton => driver.FindElement(By.Id("form-submit-button"), extendedTimeOut);
        public IWebElement topLogo => driver.FindElement(By.Id("top-logo"), extendedTimeOut);
        public IWebElement topSerach => driver.FindElement(By.Id("top-search"), extendedTimeOut);
        public IWebElement topSearchImageIcon => driver.FindElement(By.Id("top-search-image-icon"), extendedTimeOut);
        public IWebElement imageSecond => driver.FindElement(By.XPath("//img[@src='https://www.booknet.co.il/Images/Site/Pages/0cfca824-8da8-4c9a-9ee6-65607367b3b3.png']"), extendedTimeOut);

    }
}
