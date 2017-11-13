using UnderAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnderTests.SetPasswordPageTests
{
    [TestClass]
    public class DifferentConfirmPassword_1_10_ : TestBase
    {
        [TestMethod]
        public void _1_10_ShorterConfirmPassword()
        {
            Pages.SetPassword.GoTo();
            Pages.SetPassword.setPasswordFields("Test1234!", "Tes14!");
            string passwordAlert = "";
            string confirmPasswordAlert = "Password is not valid.";
            string alert1 = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/ng-component/div/div/div[2]/div/div[2]/div[4]/label")).Text;
            Assert.AreEqual(passwordAlert, alert1, "Invalid password label visible, when it should NOT be visible.");
            string alert2 = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/ng-component/div/div/div[2]/div/div[2]/div[5]/label")).Text;
            Assert.AreEqual(confirmPasswordAlert, alert2, "Invalid password label not visible when it should be visible.");

            bool sendButtonStatus = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/ng-component/div/div/div[2]/div/div[2]/div[7]/div[2]/button")).Enabled;
            Assert.IsFalse(sendButtonStatus, "Send button not disabled when it should be.");

            string passwordMatch = "Password and confirm password do not match.";
            string passwordMatchAlert = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/ng-component/div/div/div[2]/div/div[2]/div[6]")).Text;
            Assert.AreEqual(passwordMatch, passwordMatchAlert, "Passwords are not matching but no error message is shown.");

        }
    }
}
