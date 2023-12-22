using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;

namespace InstabugLoginTest
{
    public class Tests
    {
        private static EdgeDriver? _driver;
        private static readonly TimeSpan _implicitWait = TimeSpan.FromMilliseconds(500);

        private const string _url = "https://www.saucedemo.com/";

        private static IEnumerable<(string userName, string password, string? errorMessage)> LoginCases => [
            // Happy scenario
            ("standard_user", "secret_sauce", null),

            // Locked out user
            ("locked_out_user", "secret_sauce", "Epic sadface: Sorry, this user has been locked out."),

            // Incorrect username
            ("incorrect", "secret_sauce", "Epic sadface: Username and password do not match any user in this service"),

            // Incorrect password
            ("standard_user", "incorrect", "Epic sadface: Username and password do not match any user in this service"),

            // Empty username and password
            (string.Empty, string.Empty, "Epic sadface: Username is required"),

            // Empty username
            (string.Empty, "secret_sauce", "Epic sadface: Username is required"),

            // Empty password
            ("standard_user", string.Empty, "Epic sadface: Password is required"),
        ];

        [SetUp]
        public void Setup()
        {
            _driver = new();
        }

        [Test]
        [TestCaseSource(nameof(LoginCases))]
        public void LoginTest((string userName, string password, string? errorMessage) testCase)
        {
            Assert.That(_driver, Is.Not.Null);

            _driver.Manage().Timeouts().ImplicitWait = _implicitWait;

            _driver.Navigate().GoToUrl(_url);

            _driver.FindElement(By.Id("user-name")).SendKeys(testCase.userName);
            _driver.FindElement(By.Id("password")).SendKeys(testCase.password);
            _driver.FindElement(By.Id("login-button")).Click();

            if (testCase.errorMessage is null)
            {
                Assert.That(_driver.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
            }
            else
            {
                Assert.Multiple(() =>
                {
                    Assert.That(_driver.Url, Is.EqualTo("https://www.saucedemo.com/"));
                    Assert.That(_driver.FindElement(By.ClassName("error-message-container")).Text, Is.EqualTo(testCase.errorMessage));
                });
            }
        }

        [TearDown]
        public void TearDown()
        {
            _driver?.Quit();
        }
    }
}
