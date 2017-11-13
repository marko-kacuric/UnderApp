﻿using UnderAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnderTests.SetPasswordPageTests
{
    [TestClass]
    [TestCategory("login")]
    public class ValidConfirmPasswordFormat_1_03_ : TestBase
    {
        [TestMethod]
        public void _1_03_ValidConfirmPasswordFormat()
        {
            Pages.SetPassword.GoTo();
            Pages.SetPassword.setPasswordFields("", "Test1234");
            string passwordAlert = "";
            string alert = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/ng-component/div/div/div[2]/div/div[2]/div[5]/label")).Text;
            Assert.AreEqual(passwordAlert, alert, "Invalid password label visible, when it should NOT be visible.");
        }

    }
}
