using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderAppTests.Pages;

namespace UnderTests.Dashboard_ControlCenter
{
    [TestClass]
    public class UserRideRequestTimesOut_5_06_ : TestBase
    {

        [TestMethod]
        public void _5_06_AnotherAgentTakesRideRequest()
        {
            // When conducting Control Center tests, when test is started, tester must wait for Control Center page to load 
            // and send Ride Request notifications by phone app, postman or similar apps for the tests to pass

            Pages.DashboardPage.GoTo();
            Pages.DashboardPage.LogInManagingAdmin();
            Pages.DashboardPage.enterVehicleID("");
            Pages.DashboardPage.waitForEmptyRideRequestList();
        }

    }
}
