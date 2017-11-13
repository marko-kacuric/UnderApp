using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderAppTests.Pages;
using UnderAppTests;
using OpenQA.Selenium;

namespace UnderTests.Dashboard_ControlCenter
{
    [TestClass]
    public class InvalidVehicleID_5_007_ : TestBase
    {

        [TestMethod]
        public void _5_007_InvalidVehicleID()
        {
            // When conducting Control Center tests, when test is started, tester must wait for Control Center page to load 
            // and send Ride Request notifications by phone app, postman or similar apps for the tests to pass

            Pages.DashboardPage.GoTo();
            Pages.DashboardPage.LogInManagingAdmin();
            Pages.DashboardPage.enterVehicleID("1234");
            Pages.DashboardPage.sendVehicleID(); 
            var errorSymbol = Browser.Driver.FindElement(By.CssSelector(".symbol"));
            Assert.IsTrue(errorSymbol.Displayed, "Error symbol for invalid vehicle ID not displayed when it should be!");
            Pages.DashboardPage.enterVehicleID("4444");
            Pages.DashboardPage.sendVehicleID();
            Pages.DashboardPage.waitForEmptyRideRequestList();
        }
    }
}