using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class ChangePasswordOldAndNewSame_5_050_ : TestBase
    {
        [TestMethod]
        public void _5_050_ChangePasswordOldAndNewSame()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();
            Pages.AgentProfilePage.changePassword("Test1!@#$%^&*()_+-=[]{]';:,./|<>`~üöäÄÜÖß", "Test1!@#$%^&*()_+-=[]{]';:,./|<>`~üöäÄÜÖß", "Test1!@#$%^&*()_+-=[]{]';:,./|<>`~üöäÄÜÖß");
            Pages.AgentProfilePage.changePasswordSaveButton();
            Thread.Sleep(500);
            string expectedErrorMessage = "New and old password match.";
            string displayedErrorMessage = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-change-password-modal/div/div/div/div[2]/div[1]/div")).Text;

            Assert.AreEqual(expectedErrorMessage, displayedErrorMessage, "Wrong error message displayed, should be old and new passwords match.");

            Pages.AgentProfilePage.closeChangePasswordModal();
        }
    }
}
