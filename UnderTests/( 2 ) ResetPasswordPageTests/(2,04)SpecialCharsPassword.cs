using UnderAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnderTests.ResetPasswordPageTests
{
    [TestClass]
    public class SpecialCharsPassword_2_04_ : TestBase
    {
        [TestMethod, TestCategory("ResetPassword")]
        public void _2_04_SpecialCharsPassword()
        {
            Pages.ResetPassword.GoTo();
            Pages.ResetPassword.resetPasswordFields("test1" + "!@#$%^&*()_+-=[]{]" + "';:,./|<>`~" + "üöä\\ÄÜÖß", "");
            string passwordAlert = "";
            string alert = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/under-reset-password/div/div[2]/div/div[2]/div[4]/label")).Text;
            Assert.AreEqual(passwordAlert, alert, "Invalid password label visible, when it should NOT be visible.");
        }
    }
}