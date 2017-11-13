using UnderAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnderTests.ResetPasswordPageTests
{
    [TestClass]
    public class DifferentConfirmPassword_2_09_ : TestBase
    {
        [TestMethod, TestCategory("ResetPassword")]
        public void _2_09_LongerConfirmPassword()
        {
            Pages.ResetPassword.GoTo();
            Pages.ResetPassword.resetPasswordFields("Tes34tete12", "Tes3wewe23wewqeqwe23");
            string passwordAlert = "";
            string confirmPasswordAlert = "";
            string alert1 = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/under-reset-password/div/div[2]/div/div[2]/div[4]/label")).Text;
            Assert.AreEqual(passwordAlert, alert1, "Invalid password label visible, when it should NOT be visible.");
            string alert2 = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/under-reset-password/div/div[2]/div/div[2]/div[5]/label")).Text;
            Assert.AreEqual(confirmPasswordAlert, alert2, "Invalid password label visible, when it should NOT be visible.");

            bool sendButtonStatus = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/under-reset-password/div/div[2]/div/div[2]/div[7]/div[2]/button")).Enabled;
            Assert.IsFalse(sendButtonStatus, "Send button not disabled when it should be.");

            string passwordMatch = "Password and confirm password do not match.";
            string passwordMatchAlert = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/under-reset-password/div/div[2]/div/div[2]/div[6]")).Text;
            Assert.AreEqual(passwordMatch, passwordMatchAlert, "Passwords are not matching but no error message is shown.");
        }
    }
}
