using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

namespace UnderAppTests.Pages
{
    public class ReportsPage
    {

        public void GoTo()
        {
            Browser.GoTo("https://agent.under.taxi/#/login", false);
        }

        public void logInAndNavigateToReportsPage()
        {
            Pages.Login.LogIn("marko.kacuric@p3-group.com", "Test1!@#$%^&*()_+-=[]{]';:,./|<>`~üöäÄÜÖß");
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-user-header/div/div[2]/div/div[2]/button[4]");
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-user-header/div/div[2]/div/div[2]/button[4]")).Click();
        }

        public void openRideID()
        {
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-reports/div/div/div[2]/div[2]/under-reports-transactions/div[1]/div[1]/table/tbody/tr[2]/td[2]/span");
            Browser.Driver.FindElement(By.XPath("//span[@class='ride-id pointer']")).Click();
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-reports/div/div/div[2]/div[2]/under-reports-transactions/under-history-ride-detail/div/div/div/div");
        }

        public void waitForRideIdModal()
        {
            Browser.WaitUntilElementIsDisplayed(By.CssSelector(".under-ride-detail"), 5);
        }

        public void isFromToDateAndTimeDisplayed()
        {
            string startDate = Browser.FindElement(By.CssSelector(".start-date")).Text;
            string endDate = Browser.FindElement(By.CssSelector(".end-date")).Text;


            string format = "MM/dd/yyyy h:mm";
            DateTime dateTime;

            if (DateTime.TryParseExact(startDate, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
            {
                Assert.AreEqual("", "", "Valid time and date format!");
            }
            else
            {
                Assert.Fail("Wrong date and time formats!");
            }

            if (DateTime.TryParseExact(endDate, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
            {
                Assert.AreEqual("", "", "Valid time and date format!");
            }
            else
            {
                Assert.Fail("Wrong date and time formats!");

            }
        }

        public void isGoogleMapDisplayed()
        {
            var googleMap = Browser.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-reports/div/div/div[2]/div[2]/under-reports-transactions/under-history-ride-detail/div/div/div/div/div[2]/div[1]/div/div/div/div/div[2]"));
            Assert.IsTrue(googleMap.Displayed);
        }

        public void checkLicencePlateFormat()
        {
            string licencePlate = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-reports/div/div/div[2]/div[2]/under-reports-transactions/under-history-ride-detail/div/div/div/div/div[2]/div[3]/div[1]/under-history-ride-driver-detail/div[2]/div[2]/div[3]/div")).Text;
            bool licencePlateFormatValid = Regex.IsMatch(licencePlate, @"[A-Z]{2}[-][0-9]{3}[-][A-Z]{2}");
            if (licencePlateFormatValid)
            {
                Assert.AreEqual("", "", "Licence plate in correct format!");
            }
            else
                Assert.Fail("Licence plate in incorect format or not displayed!");
        }

        public void checkCustomerInfo()
        {
            IWebElement customerLabel = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-reports/div/div/div[2]/div[2]/under-reports-transactions/under-history-ride-detail/div/div/div/div/div[2]/div[3]/div[2]/under-history-ride-user-detail/div[1]/div"));
            Assert.IsTrue(customerLabel.Text.Contains("Customer"));
            Assert.AreNotEqual("", Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-reports/div/div/div[2]/div[2]/under-reports-transactions/under-history-ride-detail/div/div/div/div/div[2]/div[3]/div[2]/under-history-ride-user-detail/div[2]/div[2]/div[1]/div")).Text, "Customer name not visible or empty!");
            Assert.AreNotEqual("", Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-reports/div/div/div[2]/div[2]/under-reports-transactions/under-history-ride-detail/div/div/div/div/div[2]/div[3]/div[2]/under-history-ride-user-detail/div[2]/div[2]/div[2]/div")).Text, "Customer adress not visible or empty!");
            string customerPhoneNumber = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-reports/div/div/div[2]/div[2]/under-reports-transactions/under-history-ride-detail/div/div/div/div/div[2]/div[3]/div[2]/under-history-ride-user-detail/div[2]/div[2]/div[3]/div")).Text;

            bool phoneNumberFormatValid = Regex.IsMatch(customerPhoneNumber, @"^(\(?\+?[0-9]*\)?)?[0-9_\- \(\)]*$");
            if (phoneNumberFormatValid)
            {
                Assert.AreEqual("", "", "Phone number in correct format and displayed!");
            }
            else
                Assert.Fail("Phone number in incorrect format or not displayed!");

        }

        public void checkPaymentInfo()
        {
            IWebElement paymentSection = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-reports/div/div/div[2]/div[2]/under-reports-transactions/under-history-ride-detail/div/div/div/div/div[2]/div[3]/div[3]/under-history-ride-payment-detail"));
            Assert.IsTrue(paymentSection.Text.Contains("Payment"));
            Assert.IsTrue(paymentSection.Text.Contains("Payed with Under") | paymentSection.Text.Contains("Payed with Cash"));
            string paymentAmount = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-reports/div/div/div[2]/div[2]/under-reports-transactions/under-history-ride-detail/div/div/div/div/div[2]/div[3]/div[3]/under-history-ride-payment-detail/div[2]/div")).Text;

            bool paymentAmountFormat = Regex.IsMatch(paymentAmount, @"[1-9]{1,2,3,4,5,6}[\s]" + "RSD");
        }

        public void checkStatusInfo()
        {
            IWebElement statusSection = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-reports/div/div/div[2]/div[2]/under-reports-transactions/under-history-ride-detail/div/div/div/div/div[2]/div[3]/div[4]/under-history-ride-status-detail"));
            Assert.IsTrue(statusSection.Text.Contains("Status"), "Status label not visible!");
            Assert.IsTrue(statusSection.Text.Contains("Completed"), "Completed tag not visible!");
            var checkedSign = Browser.Driver.FindElement(By.CssSelector(".glyphicon-ok"));
            Assert.IsTrue(checkedSign.Displayed, "Check sign not visible!");
        }

        public void checkHeaderDate()
        {
            string headerDate = Browser.Driver.FindElement(By.CssSelector(".under-ride-detail-header-date > strong:nth-child(1)")).Text;

            string format = "MM/dd/yyyy h:mm";
            DateTime dateTime;

            if (DateTime.TryParseExact(headerDate, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
            {
                Assert.AreEqual("", "", "Valid time and date format!");
            }
            else
            {
                Assert.Fail("Wrong date and time formats!");
            }

        }

        //Last to be executed, exits the RideID modal
        public void checkDriverInfo()
        {
            string driverInfo = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-reports/div/div/div[2]/div[2]/under-reports-transactions/under-history-ride-detail/div/div/div/div/div[2]/div[3]/div[1]/under-history-ride-driver-detail/div[2]/div[2]/div[1]/div")).Text;
            string vehicleInfo = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-reports/div/div/div[2]/div[2]/under-reports-transactions/under-history-ride-detail/div/div/div/div/div[2]/div[3]/div[1]/under-history-ride-driver-detail/div[2]/div[2]/div[2]/div")).Text;
            Browser.Driver.FindElement(By.CssSelector("button.close:nth-child(1)")).Click();

            //Get Drivers List
            Thread.Sleep(500);
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-user-header/div/div[2]/div/div[2]/button[5]")).Click();
            Thread.Sleep(500);
            IWebElement drivers = Browser.Driver.FindElement(By.TagName("table"));
            Assert.IsTrue(drivers.Text.Contains(driverInfo));

            //Get Vehicle List
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[1]/div[2]/button[3]")).Click();
            Thread.Sleep(500);
            IWebElement vehicles = Browser.Driver.FindElement(By.TagName("table"));
            Assert.IsTrue(vehicles.Text.Contains(vehicleInfo));
        }

        public void exportTableToCSV()
        {
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-reports/div/div/div[2]/div[2]/under-reports-transactions/div[1]/div[1]/table/thead/tr/th[5]/div")).Click();
            Thread.Sleep(100);
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-reports/div/div/div[2]/div[2]/under-reports-transactions/div[1]/div[1]/table/thead/tr/th[5]/div/div")).Click();
            Thread.Sleep(200);

        }
    }
}

