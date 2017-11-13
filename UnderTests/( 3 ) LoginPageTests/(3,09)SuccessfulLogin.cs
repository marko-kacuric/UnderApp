using UnderAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnderTests.LoginPageTests
{
    [TestClass]
    public class SuccessfulLogin_3_09_ : TestBase
    {
        [TestMethod]
        public void _3_09_SuccessfulLogin()
        {
            string password = "Test1!@#$%^&*()_+-=[]{]';:,./|<>`~üöäÄÜÖß";
            Pages.Login.GoTo();
            Pages.Login.LogIn("marko.kacuric@p3-group.com", password );
            By alertModal = By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[1]/under-side-panel/div/div[2]");
            UnderAppTests.Browser.WaitUntilElementIsDisplayed(alertModal, 3);
            string alertTitle = "TAXI AGENT";
            string alertMsg = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[1]/under-side-panel/div/div[2]")).Text;
            Assert.AreEqual(alertTitle, alertMsg, "Redirected to the wrong page. Something went wrong.");
        }
    }
}
