using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventry_test.Edi_test
{
    internal class inventry_test
    {
        [TestCase]
        public void LoginPage()
        {
            //Navigate to the Web Page
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(" https://www.saucedemo.com/");

            //Enter with the UserName
            IWebElement Usernameinput = driver.FindElement(By.Id("user-name"));
            Usernameinput.Clear();
            Usernameinput.SendKeys("standard_user");

            //Enter with the Password
            IWebElement passwordinput = driver.FindElement(By.Id("password"));
            passwordinput.Clear();
            passwordinput.SendKeys("secret_sauce");

            //Clcik on the Login button
            IWebElement loginButton = driver.FindElement(By.Id("login-button"));
            loginButton.Click();
           

            Assert.That(driver.Title, Is.EqualTo("Swag Labs"));
            driver.Quit();
           
        }

    }
}
