using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class ChangePasswordInvalidNewPassword_5_051_ : TestBase
    {
        [TestMethod]
        public void _5_051_ChangePasswordInvalidNewPassword()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();
            Pages.AgentProfilePage.changePassword("Test1!@#$%^&*()_+-=[]{]';:,./|<>`~üöäÄÜÖß", "12 34 !@#$", "12 34 !@#$");

            string expectedErrorLabel = "Password is not valid.";

            string displayedErrorLabelOne = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-change-password-modal/div/div/div/div[2]/div[3]/div/div[2]/div/label")).Text;
            string displayedErrorLabelTwo = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-change-password-modal/div/div/div/div[2]/div[3]/div/div[3]/div/label")).Text;

            Assert.AreEqual(expectedErrorLabel, displayedErrorLabelOne, "Wrong error label displayed, should be password is not valid.");
            Assert.AreEqual(expectedErrorLabel, displayedErrorLabelTwo, "Wrong error label displayed, should be password is not valid.");

            var sendButton = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-change-password-modal/div/div/div/div[2]/div[3]/div/button"));

            if (sendButton.Enabled)
            {
                Assert.Fail("Send button should be disabled!");
            }
            else
                Assert.AreEqual("", "", "A-ok!");

            Pages.AgentProfilePage.closeChangePasswordModal();
        }
    }
}
