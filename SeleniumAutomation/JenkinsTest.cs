using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumAutomation
{
    [TestClass]
    public class UnitTest1
    {
        ChromeDriver driver;

        [TestInitialize]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            options.AddArgument("--disable-gpu");
            options.AddArgument("--no-sandbox");

            driver = new ChromeDriver(options);
        }

        [TestMethod]
        public void ValidLoginTest()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();

            string actualText = driver.FindElement(By.ClassName("title")).Text;
            Assert.AreEqual("Products", actualText);
        }

        [TestMethod]
        public void InvalidLoginTest()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce1");
            driver.FindElement(By.Id("login-button")).Click();

            string actualText =
                driver.FindElement(By.XPath("//h3[@data-test='error']")).Text;

            Assert.AreEqual(
                "Epic sadface: Username and password do not match any user in this service",
                actualText);
        }

        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
