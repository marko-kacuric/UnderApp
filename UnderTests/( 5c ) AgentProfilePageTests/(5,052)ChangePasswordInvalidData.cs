using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class ChangePasswordInvalidData_5_052_ : TestBase
    {
        [TestMethod]
        public void _5_052_ChangePasswordInvalidData()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();
            Pages.AgentProfilePage.changePassword("Test1!@#$%^&*()_+-=[]{]';:", "123412341234", "qweqweqweqweqwe");

            string expectedErrorLabel = "Password is not valid.";
            string displayedErrorLabelOne = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-change-password-modal/div/div/div/div[2]/div[3]/div/div[2]/div/label")).Text;
            string displayedErrorLabelTwo = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-change-password-modal/div/div/div/div[2]/div[3]/div/div[3]/div/label")).Text;

            Assert.AreEqual(expectedErrorLabel, displayedErrorLabelOne, "Wrong error label displayed, should be password is not valid.");
            Assert.AreEqual(expectedErrorLabel, displayedErrorLabelTwo, "Wrong error label displayed, should be password is not valid.");

            string expectedErrorMessage = "Password and confirm password do not match.";
            string displayedErrorMessage = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-change-password-modal/div/div/div/div[2]/div[3]/div/div[4]")).Text;

            Assert.AreEqual(expectedErrorMessage, displayedErrorMessage, "Wrong error message displayed, should be passwords not matching.");

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
