using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnderAppTests;
using UnderAppTests.Pages;


namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class FirstNameEmptyField_5_015_ : TestBase
    {
        [TestMethod]

        public void _5_015_FirstNameEmptyField()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();
            Pages.AgentProfilePage.enterFirstName(" ");
            Pages.AgentProfilePage.saveChanges();

            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[1]/div[2]/div[1]/input");

            var firstNameField = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[1]/div[2]/div[1]/input"));
            firstNameField.SendKeys("M");
            firstNameField.SendKeys(Keys.Backspace);
            firstNameField.SendKeys(Keys.Backspace);
            firstNameField.SendKeys(Keys.Backspace);

            Assert.IsTrue((Browser.ElementIsDisplayed(By.CssSelector(".warning-sign"))), "No warning sign!" );

            var buttonStatus = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[2]/button"));

            Assert.IsFalse(buttonStatus.Enabled, "Warning sign not displayed, save button active, something went wrong.");
        }
    }
}

