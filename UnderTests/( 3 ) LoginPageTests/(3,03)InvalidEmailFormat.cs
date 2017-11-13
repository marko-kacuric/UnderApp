using UnderAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnderTests.LoginPageTests
{
    [TestClass]
    public class InvalidEmailFormat_3_03_ : TestBase
    {
        [TestMethod]
        public void _3_03_InvalidEmailFormat()
        {
            Pages.Login.GoTo();
            Pages.Login.LogIn("marko.kacuric@p3-group.c", "Test1234!");

            UnderAppTests.Browser.WaitForElement("/html/body/under-agent/under-login/div/under-modal-dialog[3]/div/div/div/div/div[2]");
            string alertTitle = "Please enter valid email";
            string alertMsg = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-login/div/under-modal-dialog[1]/div/div/div/div/div[2]")).Text;
            Assert.AreEqual(alertTitle, alertMsg, "Wrong error message is presented.");
        }

    }
}
