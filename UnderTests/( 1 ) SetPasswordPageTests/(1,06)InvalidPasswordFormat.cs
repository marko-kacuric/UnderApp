using UnderAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnderTests.SetPasswordPageTests
{
    [TestClass]
    public class InvalidPasswordFormat_1_06_ : TestBase
    {
        [TestMethod]
        public void _1_06_InvalidPasswordFormat()
        {
            Pages.SetPassword.GoTo();
            Pages.SetPassword.setPasswordFields("tes55", "");
            string passwordAlert = "Password is not valid.";
            string alert = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/ng-component/div/div/div[2]/div/div[2]/div[4]/label")).Text;
            Assert.AreEqual(passwordAlert, alert, "Invalid password label not visible when it should be visible.");

            bool sendButtonStatus = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/ng-component/div/div/div[2]/div/div[2]/div[7]/div[2]/button")).Enabled;
            Assert.IsFalse(sendButtonStatus, "Send button not disabled when it should be.");
        }
    }
}
