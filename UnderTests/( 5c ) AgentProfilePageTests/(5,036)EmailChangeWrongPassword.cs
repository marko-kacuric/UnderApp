using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnderAppTests;
using UnderAppTests.Pages;


namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class EmailChangeWrongPassword_5_036_ : TestBase
    {
        [TestMethod]
        public void _5_036_EmailChangeWrongPassword()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();

            string emailBeforeChange = Pages.AgentProfilePage.getEmailText();
            Pages.AgentProfilePage.enterEmail("marko.kacuric@gmail.com");
            Pages.AgentProfilePage.saveChanges();
            Pages.AgentProfilePage.changeEmailModalVisible();
            Pages.AgentProfilePage.changeEmailPassword("Test1!@#$%^&*()_+-=[]{]';:,./|<>`~üöäÄÜÖß123123");
            Pages.AgentProfilePage.changeEmailValidatePassword();
            Pages.AgentProfilePage.changeEmailWrongPasswordMessageDisplayed();
            Pages.AgentProfilePage.closeChangeEmailModal();

            string emailAfterChange = Pages.AgentProfilePage.getEmailText();
            Assert.AreEqual(emailBeforeChange, emailAfterChange, "Wrong email displayed!");

            Pages.DashboardPage.LogOut();      
        }
    }
}
