using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class ChangePasswordNotMatching_5_048_ : TestBase
    {
        [TestMethod]
        public void _5_048_ChangePasswordNotMatching()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();
            Pages.AgentProfilePage.changePassword("Test1!@#$%^&*()_+-=[]{]';:,./|<>`~üöäÄÜÖß", "Test1234!!", "Test1234!@");

            string expectedErrorMessage = "Password and confirm password do not match.";
            string displayedErrorMessage = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-change-password-modal/div/div/div/div[2]/div[3]/div/div[4]")).Text;

            Assert.AreEqual(expectedErrorMessage, displayedErrorMessage, "Wrong error message displayed, should be passwords not matching.");

            Pages.AgentProfilePage.closeChangePasswordModal();
                
        }
    }
}
