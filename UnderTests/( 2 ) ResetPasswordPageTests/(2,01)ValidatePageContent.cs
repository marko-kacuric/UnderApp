using UnderAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnderTests.ResetPasswordPageTests
{
    [TestClass]
    public class ValidatePageContent_2_01_ : TestBase
    {
        [TestMethod, TestCategory("ResetPassword")]
        public void _2_01_ValidatePageContent()
        {
            Pages.ResetPassword.GoTo();
            string header = "Reset password";
            string pageHeader = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/under-reset-password/div/div[2]/div/div[2]/div[1]")).Text;
            Assert.AreEqual(header, pageHeader, "Redirected to wrong page, something went wrong!");

        }
    }
}
