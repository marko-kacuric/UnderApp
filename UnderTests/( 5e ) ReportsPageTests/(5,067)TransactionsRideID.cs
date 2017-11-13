using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderAppTests.Pages;


namespace UnderTests.ReportsPageTests
{
    [TestClass]
    public class TransactionsRideID_5_067_ : TestBase
    {
        [TestMethod]
        public void _5_067_TransactionsRideID()
        {
            Pages.ReportsPage.GoTo();
            Pages.ReportsPage.logInAndNavigateToReportsPage();
            Pages.ReportsPage.openRideID();
            Pages.ReportsPage.waitForRideIdModal();
            Pages.ReportsPage.isFromToDateAndTimeDisplayed();
            Pages.ReportsPage.isGoogleMapDisplayed();
            Pages.ReportsPage.checkLicencePlateFormat();
            Pages.ReportsPage.checkCustomerInfo();
            Pages.ReportsPage.checkPaymentInfo();
            Pages.ReportsPage.checkStatusInfo();
            Pages.ReportsPage.checkDriverInfo();
            Pages.ReportsPage.checkHeaderDate();

        } 
    }
}
