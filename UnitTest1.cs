using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Text;

namespace BookJunction
{
    public class Tests : BaseTest
    {
        [Test]
        public void VerifyBookStoreActions()
        {
            BookJunctionElements elements = new BookJunctionElements(driver);
            elements.googleSearchBox.SendKeys("booknet.co.il");
            elements.googleSearcButton.Click();
            elements.bookStoreLink.Click();
            //Got to https://www.booknet.co.il/
            // go to discounts and
            elements.menuButton.Click();
            elements.topCategories.Click();
            // kids books
            elements.kidsBooks.Click();
            //Select 2 books and add to basket
            elements.cartButtonOne.Click();
            elements.operatorTwo.Click();
            elements.cartButtonTwo.Click();
            elements.operatorsOne.Click();
            //Click next"
            elements.image.Click();
            //Fill fields
            elements.email.SendKeys("israel@finonex.com");
            elements.customerFirstName.SendKeys("Yair");
            elements.customerLastName.SendKeys("Lapid");
            elements.phone.SendKeys("0528222222");
            elements.city.SendKeys("New York");
            elements.street.SendKeys("Balfur");
            elements.homenum.SendKeys("1");
            //Approve terms
            elements.isConfirm.Click();
            //Select shipiing method
            SelectElement selector = new SelectElement(driver.FindElement(By.Id("shipment"), extendedTimeOut));
            selector.SelectByIndex(2);
            //Go to payment page
            elements.fornSubmitButton.Click();
            //Get back to manin page
            driver.Navigate().GoToUrl("https://www.booknet.co.il/");
            elements.topLogo.Click();
            //SearchOption the book 5 ballonns
            var fiveBaloons = "\u05DE\u05E2\u05E9\u05D4 \u05D1\u05D7\u05DE\u05D9\u05E9\u05D4 \u05D1\u05DC\u05D5\u05E0\u05D9\u05DD";
            elements.topSerach.SendKeys(fiveBaloons);
            elements.topSearchImageIcon.Click();
            // add to basket
            elements.cartButtonTwo.Click();
            elements.operatorTwo.Click();
            // go to chart
            //Click next"
            elements.imageSecond.Click();
        }
    }
}