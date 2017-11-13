using UnderAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnderTests.LoginPageTests
{
    [TestClass]
    public class ValidEmailEmptyPassword_3_07_ : TestBase
    {
        [TestMethod]
        public void _3_07_ValidEmailEmptyPassword()
        {
            Pages.Login.GoTo();
            Pages.Login.LogIn("marko.kacuric@p3-group.com", "");

            UnderAppTests.Browser.WaitForElement("/html/body/under-agent/under-login/div/under-modal-dialog[3]/div/div/div/div/div[2]");
            string alertTitle = "Please enter valid password.";
            string alertMsg = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-login/div/under-modal-dialog[2]/div/div/div/div/div[2]/div")).Text;
            Assert.AreEqual(alertTitle, alertMsg, "Wrong error message is presented.");
        }
    }
}
