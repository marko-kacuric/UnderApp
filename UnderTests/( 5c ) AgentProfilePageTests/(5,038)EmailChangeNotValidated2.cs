using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class EmailChangeNotValidated2_5_038_ : TestBase
    {
        [TestMethod]
        public void _5_038_EmailChangeNotValidated2()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();

            Pages.AgentProfilePage.enterEmail("marko.kacuric@gmail.com");
            Pages.AgentProfilePage.saveChanges();
            Pages.AgentProfilePage.changeEmailModalVisible();
            Pages.AgentProfilePage.changeEmailPassword("Test1!@#$%^&*()_+-=[]{]';:,./|<>`~üöäÄÜÖß");
            Pages.AgentProfilePage.changeEmailValidatePassword();
            Pages.DashboardPage.LogOut();

            Pages.Login.LogIn("marko.kacuric@gmail.com", "Test1!@#$%^&*()_+-=[]{]';:,./|<>`~üöäÄÜÖß");
            Browser.WaitUntilElementIsDisplayed(By.XPath("/html/body/under-agent/under-login/div/under-modal-dialog[3]/div/div/div/div"), 5);
            string expectedMsg = "Email is not validated";
            string actualMsg = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-login/div/under-modal-dialog[3]/div/div/div/div/div[2]/div")).Text;
            Assert.AreEqual(expectedMsg, actualMsg, "Wrong error message displayed, should be Email is not validated.");

            Pages.Login.LogIn("marko.kacuric@p3-group.com", "Test1!@#$%^&*()_+-=[]{]';:,./|<>`~üöäÄÜÖß");
            Browser.WaitUntilElementIsDisplayed(By.XPath("/html/body/under-agent/under-login/div/under-modal-dialog[3]/div/div/div/div"), 5);
            string expectedMsg2 = "Wrong email or password is sent.";
            string actualMsg2 = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-login/div/under-modal-dialog[3]/div/div/div/div/div[2]/div")).Text;
            Assert.AreEqual(expectedMsg2, actualMsg2, "Wrong error message displayed, should be Email is not validated.");
        }
    }
}
