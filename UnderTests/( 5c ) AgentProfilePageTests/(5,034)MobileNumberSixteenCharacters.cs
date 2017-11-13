using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class MobileNumberSixteenCharacters_5_034_ : TestBase
    {
        [TestMethod]
        public void _5_034_MobileNumberSixteenCharacters()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();
            Pages.AgentProfilePage.enterMobileNumber("123456qwerTY!@#$");

            string inputedNumber = Pages.AgentProfilePage.getMobileTextField();

            Assert.AreEqual("123456qwerTY!@#", inputedNumber, "Number inputed incorrectly, sixteenth digit is shown.");

            Assert.IsTrue((Browser.ElementIsDisplayed(By.CssSelector(".warning-sign"))), "No warning sign when there should be one.");

            var buttonStatus = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[2]/button"));

            Assert.IsFalse(buttonStatus.Enabled, "Warning sign not displayed, save button active, something went wrong.");
        }
    }
}
