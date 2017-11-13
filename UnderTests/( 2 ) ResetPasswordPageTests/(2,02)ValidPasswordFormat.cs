using UnderAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnderTests.ResetPasswordPageTests
{
    [TestClass]
    public class ValidPasswordFormat_2_02_ : TestBase
    {
        [TestMethod, TestCategory("ResetPassword")]
        public void _2_02_ValidPasswordFormat()
        {
            Pages.ResetPassword.GoTo();
            Pages.ResetPassword.resetPasswordFields("Test1234!", "");
            string passwordAlert = "";
            string alert = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/under-reset-password/div/div[2]/div/div[2]/div[4]/label")).Text;
            Assert.AreEqual(passwordAlert, alert, "Invalid password label visible, when it should NOT be visible.");
        }
    }
}
