using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class ChangePasswordSuccess_5_047_ : TestBase
    {
        [TestMethod]
        public void _5_047_ChangePasswordSuccess()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();
            Pages.AgentProfilePage.changePassword("Test1!@#$%^&*()_+-=[]{]';:,./|<>`~üöäÄÜÖß", "Test1234!", "Test1234!");
            Pages.AgentProfilePage.changePasswordSaveButton();
            Pages.DashboardPage.LogOut();
            Pages.Login.LogIn("marko.kacuric@p3-group.com", "Test1234!");
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-user-header/div/div[2]/div/div[2]/button[2]")).Click();
            Thread.Sleep(500);
            Pages.AgentProfilePage.changePassword("Test1234!", "Test1!@#$%^&*()_+-=[]{]';:,./|<>`~üöäÄÜÖß", "Test1!@#$%^&*()_+-=[]{]';:,./|<>`~üöäÄÜÖß");
            Pages.AgentProfilePage.changePasswordSaveButton();
            Pages.DashboardPage.LogOut();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();
        }
    }
}
