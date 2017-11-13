using UnderAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnderTests
{
    [TestClass]
    public class ValidRideRequest_5_003_ : TestBase
    {
        [TestMethod]
        public void _5_003_ValidRideRequest()
        {
            // When conducting Control Center tests, when test is started, tester must wait for Control Center page to load 
            // and send Ride Request notifications by phone app, postman or similar apps for the tests to pass

            Pages.DashboardPage.GoTo();
            Pages.DashboardPage.LogInManagingAdmin();
            Pages.DashboardPage.enterVehicleID("4444");
            Pages.DashboardPage.sendVehicleID();
            Pages.DashboardPage.waitForEmptyRideRequestList();
        }
    }
}


