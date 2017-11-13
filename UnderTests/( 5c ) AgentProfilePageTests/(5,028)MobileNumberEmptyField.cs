using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class MobileNumberEmptyField_5_028_ : TestBase
    {
        [TestMethod]
        public void _5_028_MobileNumberEmptyField()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();
            Pages.AgentProfilePage.enterMobileNumber(" ");
            Pages.AgentProfilePage.saveChanges();

            var mobileNumberField = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[1]/div[3]/div[2]/input"));
            mobileNumberField.SendKeys("55");
            mobileNumberField.SendKeys(Keys.Backspace);
            mobileNumberField.SendKeys(Keys.Backspace);
            mobileNumberField.SendKeys(Keys.Backspace);

            Assert.IsTrue((Browser.ElementIsDisplayed(By.CssSelector(".warning-sign"))), "No warning sign when there should be one because of the empty number field");

            var buttonStatus = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[2]/button"));

            Assert.IsFalse(buttonStatus.Enabled, "Warning sign not displayed, save button active, something went wrong.");
        }
    }
}
