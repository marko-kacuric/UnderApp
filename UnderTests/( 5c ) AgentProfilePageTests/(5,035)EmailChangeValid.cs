using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class EmailChangeValid_5_035_ : TestBase
    {
        [TestMethod]
        public void _5_035_EmailChangeValid()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();

            string emailBeforeChange = Pages.AgentProfilePage.getEmailText();
            Pages.AgentProfilePage.enterEmail("marko.kacuric@gmail.com");
            Pages.AgentProfilePage.saveChanges();
            Pages.AgentProfilePage.changeEmailModalVisible();
            Pages.AgentProfilePage.changeEmailPassword("Test1!@#$%^&*()_+-=[]{]';:,./|<>`~üöäÄÜÖß");
            Pages.AgentProfilePage.changeEmailValidatePassword();
            Pages.DashboardPage.LogOut();

            Pages.Login.LogIn("marko.kacuric@gmail.com", "Test1!@#$%^&*()_+-=[]{]';:,./|<>`~üöäÄÜÖß");
            
        }

    }
}
