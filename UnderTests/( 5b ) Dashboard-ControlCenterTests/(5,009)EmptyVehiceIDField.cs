using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderAppTests.Pages;
using UnderAppTests;
using OpenQA.Selenium;

namespace UnderTests.Dashboard_ControlCenter
{
    [TestClass]
    public class EmptyVehicleIDField_5_009_ : TestBase
    {

        [TestMethod]
        public void _5_009_EmptyVehicleIDField()
        {
            // When conducting Control Center tests, when test is started, tester must wait for Control Center page to load 
            // and send Ride Request notifications by phone app, postman or similar apps for the tests to pass

            Pages.DashboardPage.GoTo();
            Pages.DashboardPage.LogInManagingAdmin();

            Pages.DashboardPage.enterVehicleID("");
            var sendButtonStatus = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-control-center/div/div/div[2]/under-user-request-table/div/div/div[2]/div/under-user-request-table-row/div/div/div[5]/button"));
            Assert.IsTrue(!sendButtonStatus.Enabled, "Send button clickable with empty vehicle ID!");
            }
        }
    }
