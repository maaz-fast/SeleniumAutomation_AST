//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium;
//using System;

//namespace SeleniumAutomation
//{
//    [TestClass]
//    public class UnitTest1
//    {
//        [TestMethod]
//        public void ValidLoginTest()
//        {
//            ChromeDriver driver = new ChromeDriver();
//            driver.Manage().Window.Maximize(); // Will Open Chrom window in Maximize mode
//            driver.Navigate().GoToUrl("https://www.saucedemo.com/"); // Will Navigate to Website
//            driver.FindElement(By.Id("user-name")).SendKeys("standard_user"); // Will Enter Username
//            driver.FindElement(By.Id("password")).SendKeys("secret_sauce"); // Will Enter Password
//            driver.FindElement(By.Id("login-button")).Click(); // Will Click on Login Button
//            string expectedText = "Products";
//            string actualText = driver.FindElement(By.XPath("//span[@class='title']")).Text; // Will Get the Text of Products Page
//            Assert.AreEqual(expectedText, actualText); // Will Compare the Expected and Actual Text
//            driver.Close(); // Will Close the Browser

//        }
//        [TestMethod]
//        public void InvalidLoginTest()
//        {
//            ChromeDriver driver = new ChromeDriver();
//            driver.Manage().Window.Maximize(); // Will Open Chrom window in Maximize mode
//            driver.Navigate().GoToUrl("https://www.saucedemo.com/"); // Will Navigate to Website
//            driver.FindElement(By.Id("user-name")).SendKeys("standard_user"); // Will Enter Username
//            driver.FindElement(By.Id("password")).SendKeys("secret_sauce1"); // Will Enter Password
//            driver.FindElement(By.Id("login-button")).Click(); // Will Click on Login Button
//            string expectedText = "Epic sadface: Username and password do not match any user in this service";
//            string actualText = driver.FindElement(By.XPath("//h3[@data-test='error']")).Text; // Will Get the Text of Error Message
//            Assert.AreEqual(expectedText, actualText); // Will Compare the Expected and Actual Text
//            driver.Close(); // Will Close the Browser    

//        }
//    }
//}
