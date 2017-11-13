using UnderAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnderTests.LoginPageTests
{
    [TestClass]
    public class EmptyEmailValidPassword__3_05_ : TestBase
    {
        [TestMethod]
        public void _3_05_EmptyEmailValidPassword()
        {
            Pages.Login.GoTo();
            Pages.Login.LogIn("", "Test1234!");

            UnderAppTests.Browser.WaitForElement("/html/body/under-agent/under-login/div/under-modal-dialog[3]/div/div/div/div/div[2]");
            string alertTitle = "Please enter valid email";
            string alertMsg = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-login/div/under-modal-dialog[1]/div/div/div/div/div[2]")).Text;
            Assert.AreEqual(alertTitle, alertMsg, "Wrong error message is presented.");
        }
    }
}
