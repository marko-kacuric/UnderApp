using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class EmailChangedTwiceSuccessful_5_039_ : TestBase
    {
        [TestMethod]
        public void _5_039_EmailChangedTwiceSuccessful()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();

            string emailBeforeChange = Pages.AgentProfilePage.getEmailText();
            Pages.AgentProfilePage.enterEmail("marko.kacuric@gmail.com");
            Pages.AgentProfilePage.saveChanges();
            Pages.AgentProfilePage.changeEmailModalVisible();
            Pages.AgentProfilePage.changeEmailPassword("Test1!@#$%^&*()_+-=[]{]';:,./|<>`~üöäÄÜÖß");
            Pages.AgentProfilePage.changeEmailValidatePassword();

            Pages.AgentProfilePage.enterEmail("marko.kacuric@p3-group.com");
            Pages.AgentProfilePage.saveChanges();
            Pages.AgentProfilePage.changeEmailModalVisible();
            Pages.AgentProfilePage.changeEmailPassword("Test1!@#$%^&*()_+-=[]{]';:,./|<>`~üöäÄÜÖß");
            Pages.AgentProfilePage.changeEmailValidatePassword();
            string emailAfterChange = Pages.AgentProfilePage.getEmailText();

            Assert.AreEqual(emailBeforeChange, emailAfterChange, "Not the email expected, test flow went wrong!");
            Pages.DashboardPage.LogOut();

            Thread.Sleep(10000);

            Pages.Login.LogIn("marko.kacuric@p3-group.com" , "Test1!@#$%^&*()_+-=[]{]';:,./|<>`~üöäÄÜÖß");

        }
    }
}
