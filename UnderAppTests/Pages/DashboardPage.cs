using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;

namespace UnderAppTests.Pages
{
    public class DashboardPage
    {

        public void GoTo()
        {
            Browser.GoTo("https://agent.under.taxi/#/login", false);
        }

        public void LogInManagingAdmin()
        {
            Pages.Login.LogIn("marko.kacuric@p3-group.com", "Test1!@#$%^&*()_+-=[]{]';:,./|<>`~üöäÄÜÖß");
        }

        public void LogInAdmin()
        {
            Pages.Login.LogIn("marko.kacuric@gmail.com", "test1234");
        }

        public void validateDisplayedUsername()
        {
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-user-header/div/div[3]/under-user-profile/div/div/div/button/div[1]/div");
            string profileButtonName = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-user-header/div/div[3]/under-user-profile/div/div/div/button/div[1]/div")).Text;
            string taxiAgentDisplayedName = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[1]/under-side-panel/div/div[4]")).Text;
            Assert.AreEqual(profileButtonName, taxiAgentDisplayedName, "Correct username not displayed in bottom left section!");
            Browser.Driver.FindElement(By.CssSelector(".user-profile-btn")).Click();
            Browser.WaitForElement("/html/body/under-agent/under-user-popover/div/div");
            string usernameDisplayedInProfileModal = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-user-popover/div/div/div[2]/div/div")).Text;
            Assert.AreEqual(taxiAgentDisplayedName, usernameDisplayedInProfileModal, "Wrong username displayed in User Profile modal!");
        }

        public void enterVehicleID(string id)
        {
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-control-center/div/div/div[2]/under-user-request-table/div/div/div[2]/div/under-user-request-table-row/div");
            var vehicleIdField = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-control-center/div/div/div[2]/under-user-request-table/div/div/div[2]/div/under-user-request-table-row/div/div/div[4]/input"));
            vehicleIdField.Clear();
            vehicleIdField.SendKeys(id);
        }

        public void sendVehicleID()
        {
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-control-center/div/div/div[2]/under-user-request-table/div/div/div[2]/div/under-user-request-table-row/div/div/div[5]/button");
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-control-center/div/div/div[2]/under-user-request-table/div/div/div[2]/div/under-user-request-table-row/div/div/div[5]/button")).Click();
            Thread.Sleep(250);
        }

        public void waitForEmptyRideRequestList()
        {          
            string emptyList = "NO RIDE REQUEST";
            Thread.Sleep(1000);
            string actualEmptyList = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-control-center/div/div/div[2]/under-user-request-table/div/div/div[2]/div")).Text;
            Assert.AreEqual(emptyList, actualEmptyList, "NO RIDE REQUEST message not showing, meaning the ride request list is not empty!");
        }

        public void removeErrorNotification()
        {
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-control-center/div/div/div[2]/under-user-request-table/div/div/div[1]/under-assign-requests-error-notification/div/under-assign-requests-error-notification-row/div/div/div[3]/div");
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-control-center/div/div/div[2]/under-user-request-table/div/div/div[1]/under-assign-requests-error-notification/div/under-assign-requests-error-notification-row/div/div/div[3]/div")).Click();
        }

        public void LogOut()
        {
            By profile = By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-user-header/div/div[3]/under-user-profile/div/div/div/button/div[1]/div");
            Browser.WaitUntilElementIsDisplayed(profile, 10);
            Thread.Sleep(1000);
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-user-header/div/div[3]/under-user-profile/div/div/div/button/div[1]/div")).Click();
            Browser.WaitUntilElementIsDisplayed(By.XPath("/html/body/under-agent/under-user-popover/div/div"), 5);
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-user-popover/div/div/div[3]/button")).Click();
        }
    }
}
