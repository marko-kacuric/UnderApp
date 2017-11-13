using UnderAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnderAppTests;

namespace UnderTests.ForgotPasswordPageTests
{
    [TestClass]
    public class InvalidEmailFormatReset_4_03_ : TestBase
    {
        [TestMethod]
        public void _4_03_InvalidEmailFormatReset()
        {
            Pages.ForgotPassword.GoTo();
            Pages.ForgotPassword.isAtAppropriatePage();
            Pages.ForgotPassword.forgotPassword("qweqweq@qweqew...com");

            string errorMessage = "Please enter valid email.";
            string errorMessageReset = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-forgot-password/div/div[2]/div/div[2]/div[3]/label")).Text;
            Assert.AreEqual(errorMessage, errorMessageReset, "Error message not displayed when it should be, invalid email format inputed!");

            Assert.IsFalse(Browser.Driver.FindElement(By.CssSelector("div.col-xs-12:nth-child(2) > button:nth-child(1)")).Enabled, "Reset button enabled when it should't be!");
        }
    }
}
