using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void Test1()
        {
                //open browser
                IWebDriver webDriver = new ChromeDriver("C:\\Users\\hp\\Downloads\\chromedriver_win32 ");
                //navigate to site
                webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");

            // identify login
            IWebElement lnklogin = webDriver.FindElement(By.LinkText("Login"));

            //operation
            lnklogin.Click();

           // username
            var txtUserName = webDriver.FindElement(By.Name("UserName"));

           // assretion
            Assert.That(txtUserName.Displayed, Is.True);

            txtUserName.SendKeys("admin");

            webDriver.FindElement(By.Name("Password")).SendKeys("password");

            webDriver.FindElement(By.XPath("//input[@value='Log in']")).Submit();

           IWebElement  lnkEmployeeDetails = webDriver.FindElement(By.LinkText("Employee Details"));

            Assert.That(lnkEmployeeDetails.Displayed, Is.True);
        }
    }
}