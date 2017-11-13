using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderAppTests.Pages;
using UnderAppTests;
using OpenQA.Selenium;
using System.Threading;

namespace UnderTests.Dashboard_ControlCenter
{
    [TestClass]
    public class InvalidCharactersVehicleID_5_008_ : TestBase
    {

        [TestMethod]
        public void _5_008_InvalidCharactersVehicleID()
        {
            // When conducting Control Center tests, when test is started, tester must wait for Control Center page to load 
            // and send Ride Request notifications by phone app, postman or similar apps for the tests to pass

            Pages.DashboardPage.GoTo();
            Pages.DashboardPage.LogInManagingAdmin();

            Pages.DashboardPage.enterVehicleID("!@#$");
            Pages.DashboardPage.sendVehicleID();
            var errorSymbol = Browser.Driver.FindElement(By.CssSelector(".symbol"));
            Assert.IsTrue(errorSymbol.Displayed, "Error symbol for invalid vehicle ID not displayed when it should be!");
            Thread.Sleep(250);
            Pages.DashboardPage.removeErrorNotification();
            Thread.Sleep(300);

            Pages.DashboardPage.enterVehicleID("%^&*");
            Pages.DashboardPage.sendVehicleID();
            Assert.IsTrue(errorSymbol.Displayed, "Error symbol for invalid vehicle ID not displayed when it should be!");
            Thread.Sleep(250);
            Pages.DashboardPage.removeErrorNotification();
            Thread.Sleep(300);

            Pages.DashboardPage.enterVehicleID("12AR");
            Pages.DashboardPage.sendVehicleID();
            Assert.IsTrue(errorSymbol.Displayed, "Error symbol for invalid vehicle ID not displayed when it should be!");
            Thread.Sleep(250);
            Pages.DashboardPage.removeErrorNotification();
            Thread.Sleep(300);

            Pages.DashboardPage.enterVehicleID("{[]}");
            Pages.DashboardPage.sendVehicleID();
            Assert.IsTrue(errorSymbol.Displayed, "Error symbol for invalid vehicle ID not displayed when it should be!");
            Thread.Sleep(250);
            Pages.DashboardPage.removeErrorNotification();
            Thread.Sleep(300);

            Pages.DashboardPage.enterVehicleID("|?.>");
            Pages.DashboardPage.sendVehicleID();
            Assert.IsTrue(errorSymbol.Displayed, "Error symbol for invalid vehicle ID not displayed when it should be!");
            Thread.Sleep(250);
            Pages.DashboardPage.removeErrorNotification();
            Thread.Sleep(300);

            Pages.DashboardPage.enterVehicleID("<, ~");
            Pages.DashboardPage.sendVehicleID();
            Assert.IsTrue(errorSymbol.Displayed, "Error symbol for invalid vehicle ID not displayed when it should be!");
            Thread.Sleep(250);
            Pages.DashboardPage.removeErrorNotification();
            Thread.Sleep(300);

            Pages.DashboardPage.enterVehicleID("4444");
            Pages.DashboardPage.sendVehicleID();
            Pages.DashboardPage.waitForEmptyRideRequestList();
        }

    }
}