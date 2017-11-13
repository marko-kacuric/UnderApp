using UnderAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnderTests.ResetPasswordPageTests
{
    [TestClass]
    public class SuccessfulPasswordSet_2_08_ : TestBase
    {
        [TestMethod, TestCategory("ResetPassword")]
        public void _2_08_SuccessfulPasswordSet()
        {
            Pages.ResetPassword.GoTo();
            Pages.ResetPassword.resetPasswordFields("Test1234", "Test1234");
            string passwordAlert = "";
            string confirmPasswordAlert = "";
            string alert1 = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/under-reset-password/div/div[2]/div/div[2]/div[4]/label")).Text;
            Assert.AreEqual(passwordAlert, alert1, "Invalid password label visible, when it should NOT be visible.");
            string alert2 = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/under-reset-password/div/div[2]/div/div[2]/div[5]/label")).Text;
            Assert.AreEqual(confirmPasswordAlert, alert2, "Invalid password label visible, when it should NOT be visible.");

            bool sendButtonStatus = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/under-reset-password/div/div[2]/div/div[2]/div[7]/div[2]/button")).Enabled;
            Assert.IsTrue(sendButtonStatus, "Send button is disabled, it should be enabled.");

            //UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/under-reset-password/div/div[2]/div/div[2]/div[7]/div[2]/button")).Click();

            Pages.SuccessChange.GoTo();
            Pages.SuccessChange.isAtAppropriatePage();
            Pages.SuccessChange.loginPageButton();

            UnderAppTests.Browser.WaitForElement("/html/body/under-agent/under-login/div/div[2]/div/div[2]/div[1]");
            string agentLoginText = "Taxi agent login";
            string loginText = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-login/div/div[2]/div/div[2]/div[1]")).Text;
            Assert.AreEqual(agentLoginText, loginText, "Go to Login Page button after password reset did NOT lead to appropriate page.");

            // Link for success change pass: https://under.taxi/#/success/reset-password/taxi_agent
        }
    }
}
