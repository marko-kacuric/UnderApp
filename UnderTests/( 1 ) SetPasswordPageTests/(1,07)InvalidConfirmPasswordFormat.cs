using UnderAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnderTests.SetPasswordPageTests
{
    [TestClass]
    public class InvalidConfirmPasswordFormat_1_07_ : TestBase
    {
        [TestMethod]
        public void _1_07_InvalidConfirmPasswordFormat()
        {
            Pages.SetPassword.GoTo();
            Pages.SetPassword.setPasswordFields("", "test13");
            string passwordAlert = "Password is not valid.";
            string alert = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/ng-component/div/div/div[2]/div/div[2]/div[5]/label")).Text;
            Assert.AreEqual(passwordAlert, alert, "Invalid password label not visible when it should be visible.");

            bool sendButtonStatus = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/ng-component/div/div/div[2]/div/div[2]/div[7]/div[2]/button")).Enabled;
            Assert.IsFalse(sendButtonStatus, "Send button not disabled when it should be.");
            
        }
    }
}
