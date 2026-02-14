using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;

namespace SeleniumAutomation
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidLoginTest()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize(); // Will Open Chrom window in Maximize mode
            driver.Navigate().GoToUrl("https://www.saucedemo.com/"); // Will Navigate to Website
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user"); // Will Enter Username
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce"); // Will Enter Password
            driver.FindElement(By.Id("login-button")).Click(); // Will Click on Login Button
            string expectedText = "Products";
            string actualText = driver.FindElement(By.XPath("//span[@class='title']")).Text; // Will Get the Text of Products Page
            Assert.AreEqual(expectedText, actualText); // Will Compare the Expected and Actual Text
            driver.Close(); // Will Close the Browser

        }
        [TestMethod]
        public void InvalidLoginTest()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize(); // Will Open Chrom window in Maximize mode
            driver.Navigate().GoToUrl("https://www.saucedemo.com/"); // Will Navigate to Website
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user"); // Will Enter Username
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce1"); // Will Enter Password
            driver.FindElement(By.Id("login-button")).Click(); // Will Click on Login Button
            string expectedText = "Epic sadface: Username and password do not match any user in this service";
            string actualText = driver.FindElement(By.XPath("//h3[@data-test='error']")).Text; // Will Get the Text of Error Message
            Assert.AreEqual(expectedText, actualText); // Will Compare the Expected and Actual Text
            driver.Close(); // Will Close the Browser    

        }

        [TestMethod]
        public void ErrorMessageTest()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize(); // Will Open Chrom window in Maximize mode
            driver.Navigate().GoToUrl("https://www.saucedemo.com/"); // Will Navigate to Website
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user"); // Will Enter Username
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce"); // Will Enter Password
            driver.FindElement(By.Id("login-button")).Click(); // Will Click on Login Button
            string expectedText = "Products";
            string actualText = driver.FindElement(By.XPath("//span[@class='title']")).Text; // Will Get the Text of Products Page
            Assert.AreEqual(expectedText, actualText); // Will Compare the Expected and Actual Text
            driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click(); // Will Click on Menu Button
            driver.FindElement(By.Id("shopping_cart_container")).Click(); // Will Click on Shopping Cart Button
            driver.FindElement(By.Id("checkout")).Click(); // Will Click on Checkout Button
            driver.FindElement(By.CssSelector("#continue")).Click(); // Will Click on Continue Button without Entering any Details
            string expectedErrorMessage = "Error: First Name is required";
            string actualErrorMessage = driver.FindElement(By.XPath("//h3[@data-test='error']")).Text; // Will Get the Text of Error Message
            Assert.AreEqual(expectedErrorMessage, actualErrorMessage); // Will Compare the Expected and Actual Text
            driver.Close(); // Will Close the Browser
        }

        [TestMethod]
        public void OrderPlacementTest ()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize(); // Will Open Chrom window in Maximize mode
            driver.Navigate().GoToUrl("https://www.saucedemo.com/"); // Will Navigate to Website
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user"); // Will Enter Username
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce"); // Will Enter Password
            driver.FindElement(By.Id("login-button")).Click(); // Will Click on Login Button
            string expectedText = "Products";
            string actualText = driver.FindElement(By.XPath("//span[@class='title']")).Text; // Will Get the Text of Products Page
            Assert.AreEqual(expectedText, actualText); // Will Compare the Expected and Actual Text
            driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click(); // Will Click on Menu Button
            driver.FindElement(By.Id("shopping_cart_container")).Click(); // Will Click on Shopping Cart Button
            driver.FindElement(By.Id("checkout")).Click(); // Will Click on Checkout Button
            driver.FindElement(By.Id("first-name")).SendKeys("Maaz"); // Will Enter First Name
            driver.FindElement(By.Id("last-name")).SendKeys("Imtiaz"); // Will Enter Last Name
            driver.FindElement(By.Id("postal-code")).SendKeys("75400"); // Will Enter Postal Code)
            driver.FindElement(By.CssSelector("#continue")).Click(); // Will Click on Continue Button without Entering any Details
            driver.FindElement(By.Id("finish")).Click(); // Will Click on Finish Button
            string expectedConfirmationMessage = "Thank you for your order!";
            string actualConfirmationMessage = driver.FindElement(By.XPath("//h2[@class='complete-header']")).Text; // Will Get the Text of Confirmation Message
            Assert.AreEqual(expectedConfirmationMessage, actualConfirmationMessage); // Will Compare the Expected and Actual Text
            driver.Close(); // Will Close the Browser

        }
    }
}
