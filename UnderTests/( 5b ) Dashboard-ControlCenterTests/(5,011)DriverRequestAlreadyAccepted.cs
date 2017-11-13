using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderAppTests.Pages;
using UnderAppTests;
using OpenQA.Selenium;

namespace UnderTests.Dashboard_ControlCenter
{
    [TestClass]
    public class DriverRequestAlreadyAccepted_5_011_ : TestBase
    {

        [TestMethod]
        public void _5_011_DriverRequestAlreadyAccepted()
        {

            // When conducting Control Center tests, when test is started, tester must wait for Control Center page to load 
            // and send Ride Request notifications by phone app, postman or similar apps for the tests to pass

            Pages.DashboardPage.GoTo();
            Pages.DashboardPage.LogInManagingAdmin();

            Pages.DashboardPage.enterVehicleID("8383");
            Pages.DashboardPage.sendVehicleID();
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-control-center/div/div/div[2]/under-user-request-table/div/div/div[1]/under-assign-requests-error-notification/div/under-assign-requests-error-notification-row/div/div/div[2]");
            string errorMessage = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-control-center/div/div/div[2]/under-user-request-table/div/div/div[1]/under-assign-requests-error-notification/div/under-assign-requests-error-notification-row/div/div/div[2]")).Text;
            string expectedMessage = "Vehicle 8383 driver not available.";
            Assert.AreEqual(expectedMessage, errorMessage, "Invalid error message, should be driver not available!");
            Pages.DashboardPage.removeErrorNotification();
            Pages.DashboardPage.enterVehicleID("4444");
            Pages.DashboardPage.sendVehicleID();
            Pages.DashboardPage.waitForEmptyRideRequestList();
        }

    }
}
