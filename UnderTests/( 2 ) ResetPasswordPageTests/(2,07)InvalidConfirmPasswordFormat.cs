using UnderAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnderTests.ResetPasswordPageTests
{
    [TestClass]
    public class InvalidConfirmPasswordFormat_2_07_ : TestBase
    {
        [TestMethod, TestCategory("ResetPassword")]
        public void _2_07_InvalidConfirmPasswordFormat()
        {
            Pages.ResetPassword.GoTo();
            Pages.ResetPassword.resetPasswordFields("", "test1");
            string passwordAlert = "Password is not valid.";
            string alert = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/under-reset-password/div/div[2]/div/div[2]/div[5]/label")).Text;
            Assert.AreEqual(passwordAlert, alert, "Invalid password label not visible when it should be visible.");

            bool sendButtonStatus = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/under-reset-password/div/div[2]/div/div[2]/div[7]/div[2]/button")).Enabled;
            Assert.IsFalse(sendButtonStatus, "Send button not disabled when it should be.");
        }
    }
}
