using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class ChangePasswordInvalidPassword_5_049_ : TestBase
    {
        [TestMethod]
        public void _5_049_ChangePasswordInvalidPassword()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();
            Pages.AgentProfilePage.changePassword("!@#$! @#1 23213213 ", "Test1234!@", "Test1234!@");

            string expectedErrorLabel = "Password is not valid.";
            string displayedErrorLabel = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-change-password-modal/div/div/div/div[2]/div[3]/div/div[1]/div/label")).Text;

            Assert.AreEqual(expectedErrorLabel, displayedErrorLabel, "Wrong error label displayed, should be password not valid.");
            var sendButton = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-change-password-modal/div/div/div/div[2]/div[3]/div/button"));

            if (sendButton.Enabled)
            {
                Assert.Fail("Send button should be disabled!");
            }
            else
                Assert.AreEqual("","","A-ok!");

                Pages.AgentProfilePage.closeChangePasswordModal();
        }
    }
}
