using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Text;

namespace BookJunction
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]        
        public void Setup()
        {
            driver = new ChromeDriver("C:\\Payer\\");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.com/");
            Thread.Sleep(500);
        }

        [TearDown]
        public void CleanUp()
        {
            Thread.Sleep(1000);
            driver.Close();
            driver.Quit();
        }

        [Test]
        public void VerifyBookStoreActions()
        {
            driver.FindElement(By.Name("q")).SendKeys("booknet.co.il");
            Thread.Sleep(500);
            driver.FindElement(By.Name("btnK")).Click();
            driver.FindElement(By.XPath("//span[text()='https://www.booknet.co.il/']")).Click();
            //Got to https://www.booknet.co.il/
            // go to discounts and
            driver.FindElement(By.ClassName("menu")).Click();
            driver.FindElement(By.Id("top-categories")).
                FindElement(By.XPath("//li[@data-id='250']/a")).Click();
            // kids books
            driver.FindElement(By.Id("sub-categories-container")).FindElement(By.ClassName("sub-categories-inner")).
                FindElements(By.ClassName("sub-cat-title")).First().Click();
            //Select 2 books and add to basket
            Thread.Sleep(2000);
            driver.FindElements(By.ClassName("cart-btn2")).First().Click();
            Thread.Sleep(500);
            driver.FindElements(By.ClassName("oprs")).Last().Click();
            Thread.Sleep(500);
            driver.FindElements(By.ClassName("cart-btn2")).ElementAt(1).Click();
            Thread.Sleep(500);
            driver.FindElements(By.ClassName("oprs")).First().Click();
            Thread.Sleep(2000);
            //Click next"
            driver.FindElement(By.XPath("//img[@src='https://www.booknet.co.il/Images/Site/Pages/0cfca824-8da8-4c9a-9ee6-65607367b3b3.png']")).Click();
            Thread.Sleep(2000);
            //Fill fields
            driver.FindElement(By.Id("email")).SendKeys("israel@finonex.com");
            driver.FindElement(By.Id("customerFirstName")).SendKeys("Yair");
            driver.FindElement(By.Id("customerLastName")).SendKeys("Lapid");
            driver.FindElement(By.Id("phone")).SendKeys("0528222222");
            driver.FindElement(By.Id("city")).SendKeys("New York");
            driver.FindElement(By.Id("street")).SendKeys("Balfur");
            driver.FindElement(By.Id("homenum")).SendKeys("1");
            //Approve terms
            driver.FindElement(By.Id("isConfirm")).Click();
            Thread.Sleep(500);
            //Select shipiing method
            SelectElement selector = new SelectElement(driver.FindElement(By.Id("shipment")));
            selector.SelectByIndex(2);
            Thread.Sleep(500);
            //Go to payment page
            driver.FindElement(By.Id("form-submit-button")).Click();
            Thread.Sleep(3000);
            //Get back to manin page
            driver.Navigate().GoToUrl("https://www.booknet.co.il/");
            //driver.FindElement(By.Id("top-logo")).Click();
            Thread.Sleep(2000);
            //SearchOption the book 5 ballonns
            var fiveBaloons = "\u05DE\u05E2\u05E9\u05D4 \u05D1\u05D7\u05DE\u05D9\u05E9\u05D4 \u05D1\u05DC\u05D5\u05E0\u05D9\u05DD";
            driver.FindElement(By.Id("top-search")).SendKeys(fiveBaloons);
            Thread.Sleep(500);
            driver.FindElement(By.Id("top-search-image-icon")).Click();
            Thread.Sleep(1000);
            // add to basket
            driver.FindElements(By.ClassName("cart-btn2")).ElementAt(2).Click();
            Thread.Sleep(1000);
            driver.FindElements(By.ClassName("oprs")).First().Click();
            Thread.Sleep(5000);
            // go to chart
            //Click next"
            driver.FindElement(By.XPath("//img[@src='https://www.booknet.co.il/Images/Site/Pages/0cfca824-8da8-4c9a-9ee6-65607367b3b3.png']")).Click();
            Thread.Sleep(2000);
        }
    }
}