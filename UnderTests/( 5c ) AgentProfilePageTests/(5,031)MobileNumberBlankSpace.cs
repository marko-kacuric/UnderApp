﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class MobileNumberBlankSpace_5_031_ : TestBase
    {
        [TestMethod]
        public void _5_031_MobileNumberBlankSpace()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();
            Pages.AgentProfilePage.enterMobileNumber(" ");

            Assert.IsTrue((Browser.ElementIsDisplayed(By.CssSelector(".warning-sign"))), "No warning sign when there should be one.");

            var buttonStatus = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[2]/button"));

            Assert.IsFalse(buttonStatus.Enabled, "Warning sign not displayed, save button active, something went wrong.");
        }
    }
}