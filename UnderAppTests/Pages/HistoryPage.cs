using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace UnderAppTests.Pages
{
    public class HistoryPage
    {

        public void GoTo()
        {
            Browser.GoTo("https://agent.under.taxi/#/login", false);
        }

        public void LogInAndNavigateToHistoryPage()
        {
            Pages.Login.LogIn("marko.kacuric@p3-group.com", "Test1!@#$%^&*()_+-=[]{]';:,./|<>`~üöäÄÜÖß");
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-user-header/div/div[2]/div/div[2]/button[3]");
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-user-header/div/div[2]/div/div[2]/button[3]")).Click();
        }

        public void pickDate_5_053_TC()
        {
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-history/div/div/div[3]/div[1]/div[1]/under-date-range/input");
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-history/div/div/div[3]/div[1]/div[1]/under-date-range/input")).Click();
            IWebElement month = Browser.Driver.FindElement(By.XPath("/html/body/bs-daterangepicker-container/div/div/div/div/bs-days-calendar-view[1]/bs-calendar-layout/div[1]/bs-datepicker-navigation-view/button[2]"));

            do { Browser.Driver.FindElement(By.ClassName("previous")).Click(); } while (!month.Text.Contains("September"));

            Browser.Driver.FindElement(By.XPath("/html/body/bs-daterangepicker-container/div/div/div/div/bs-days-calendar-view[1]/bs-calendar-layout/div[2]/table/tbody/tr[1]/td[7]/span"));
            Browser.Driver.FindElement(By.XPath("/html/body/bs-daterangepicker-container/div/div/div/div/bs-days-calendar-view[2]/bs-calendar-layout/div[2]/table/tbody/tr[5]/td[4]/span")).Click();

        }

        public void pickDate_5_054_TC()
        {
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-history/div/div/div[3]/div[1]/div[1]/under-date-range/input");
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-history/div/div/div[3]/div[1]/div[1]/under-date-range/input")).Click();

        }

        public void pickDate_5_055_TC()
        {
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-history/div/div/div[3]/div[1]/div[1]/under-date-range/input");
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-history/div/div/div[3]/div[1]/div[1]/under-date-range/input")).Click();

        }

        public void pickDate_5_056_TC()
        {
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-history/div/div/div[3]/div[1]/div[1]/under-date-range/input");
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-history/div/div/div[3]/div[1]/div[1]/under-date-range/input")).Click();

        }

        public void pickDate_5_057_TC()
        {
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-history/div/div/div[3]/div[1]/div[1]/under-date-range/input");
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-history/div/div/div[3]/div[1]/div[1]/under-date-range/input")).Click();

        }


        public void PaymentAll()
        {
            Thread.Sleep(200);
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-history/div/div/div[3]/div[1]/div[2]/under-payment-filter/div/button")).Click();
            Thread.Sleep(200);
            Browser.Driver.FindElement(By.CssSelector(".open > ul:nth-child(2) > li:nth-child(1) > a:nth-child(1)")).Click();
        }

        public void PaymentCash()
        {
            Thread.Sleep(200);
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-history/div/div/div[3]/div[1]/div[2]/under-payment-filter/div/button")).Click();
            Thread.Sleep(200);
            Browser.Driver.FindElement(By.CssSelector(".open > ul:nth-child(2) > li:nth-child(2) > a:nth-child(1)")).Click();
        }

        public void PaymentUnder()
        {
            Thread.Sleep(200);
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-history/div/div/div[3]/div[1]/div[2]/under-payment-filter/div/button")).Click();
            Thread.Sleep(200);
            Browser.Driver.FindElement(By.CssSelector(".open > ul:nth-child(2) > li:nth-child(3) > a:nth-child(1)")).Click();
        }

        public void PaymentNoInvoice()
        {
            Thread.Sleep(200);
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-history/div/div/div[3]/div[1]/div[2]/under-payment-filter/div/button")).Click();
            Thread.Sleep(200);
            Browser.Driver.FindElement(By.CssSelector(".open > ul:nth-child(2) > li:nth-child(4) > a:nth-child(1)")).Click();
        }


        public void checkDateFormat()
        {
            string dateValue = "07/20/2017";
            DateTime dt;
            string[] formats = { "mm/dd/yyyy" };
            if (DateTime.TryParseExact(dateValue, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
            {
                Assert.AreEqual("", "", "Date formats valid!");
            }
            else
                Assert.Fail("Invalid date formats, should be mm/dd/yyyy");
        }


        public void NextPage()
        {
            var nextButton = Browser.FindElement(By.CssSelector(".pagination-next > a:nth-child(1)"));
            var lastPage = Browser.FindElement(By.CssSelector(".pagination-last > a:nth-child(1)"));
            nextButton.Click();

            List<IWebElement> pagination = Browser.Driver.FindElements(By.ClassName("page-link")).ToList();
            int pageCount = pagination.Count;

            for (int i = 0; i < pageCount; i++)
            {
                Thread.Sleep(150);
                tableContentPaymentAll();
                checkDateFormat();
                nextButton.Click();
            }
        }

        public void NextPageCash()
        {
            var nextButton = Browser.FindElement(By.CssSelector(".pagination-next > a:nth-child(1)"));
            var lastPage = Browser.FindElement(By.CssSelector(".pagination-last > a:nth-child(1)"));
            nextButton.Click();

            List<IWebElement> pagination = Browser.Driver.FindElements(By.ClassName("page-link")).ToList();
            int pageCount = pagination.Count;

            for (int i = 0; i < pageCount; i++)
            {
                Thread.Sleep(150);
                tableContentPaymentCash();
                checkDateFormat();
                nextButton.Click();
            }
        }

        public void NextPageUnder()
        {
            var nextButton = Browser.FindElement(By.CssSelector(".pagination-next > a:nth-child(1)"));
            var lastPage = Browser.FindElement(By.CssSelector(".pagination-last > a:nth-child(1)"));
            nextButton.Click();

            List<IWebElement> pagination = Browser.Driver.FindElements(By.ClassName("page-link")).ToList();
            int pageCount = pagination.Count;

            for (int i = 0; i < pageCount; i++)
            {
                Thread.Sleep(150);
                tableContentPaymentUnder();
                checkDateFormat();
                nextButton.Click();
            }
        }

        public void NextPageNoInvoice()
        {
            var nextButton = Browser.FindElement(By.CssSelector(".pagination-next > a:nth-child(1)"));
            var lastPage = Browser.FindElement(By.CssSelector(".pagination-last > a:nth-child(1)"));
            nextButton.Click();

            List<IWebElement> pagination = Browser.Driver.FindElements(By.ClassName("page-link")).ToList();
            int pageCount = pagination.Count;

            for (int i = 0; i < pageCount; i++)
            {
                Thread.Sleep(150);
                tableContentPaymentNoInvoice();
                checkDateFormat();
                nextButton.Click();
            }
        }


        public void tableContentPaymentAll()
        {
            IWebElement tag = Browser.Driver.FindElement(By.TagName("table"));

            Thread.Sleep(100);
            Assert.IsTrue(tag.Text.Contains("Cash") | tag.Text.Contains("Under"));
            Assert.IsTrue(tag.Text.Contains("User canceled") | tag.Text.Contains("Driver canceled") | tag.Text.Contains("Completed"));

        }

        public void tableContentPaymentCash()
        {
            IWebElement tag = Browser.Driver.FindElement(By.TagName("table"));

            Thread.Sleep(100);
            Assert.IsTrue(tag.Text.Contains("Cash"));
            Assert.IsFalse(tag.Text.Contains("Under"));
            Assert.IsTrue(tag.Text.Contains("Completed"));
            Assert.IsFalse(tag.Text.Contains("User canceled") | tag.Text.Contains("Driver canceled"));
        }

        public void tableContentPaymentUnder()
        {
            IWebElement tag = Browser.Driver.FindElement(By.TagName("table"));

            Thread.Sleep(100);
            Assert.IsTrue(tag.Text.Contains("Under"));
            Assert.IsFalse(tag.Text.Contains("Cash"));
            Assert.IsTrue(tag.Text.Contains("Completed"));
            Assert.IsFalse(tag.Text.Contains("User canceled") | tag.Text.Contains("Driver canceled"));
        }

        public void tableContentPaymentNoInvoice()
        {
            IWebElement tag = Browser.Driver.FindElement(By.TagName("table"));

            Thread.Sleep(100);
            Assert.IsFalse(tag.Text.Contains("Cash") | tag.Text.Contains("Under"));
            Assert.IsTrue(tag.Text.Contains("Completed"));
            Assert.IsFalse(tag.Text.Contains("User canceled") | tag.Text.Contains("Driver canceled"));
        }


        public void StatusAll()
        {
            Browser.WaitUntilElementIsDisplayed((By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-history/div/div/div[3]/div[1]/div[3]/under-status-filter/div/button")), 5);
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-history/div/div/div[3]/div[1]/div[3]/under-status-filter/div/button")).Click();
            Browser.WaitUntilElementIsDisplayed((By.CssSelector(".dropdown-menu > li:nth-child(1) > a:nth-child(1)")), 5);
            Browser.Driver.FindElement(By.CssSelector(".dropdown-menu > li:nth-child(1) > a:nth-child(1)")).Click();
        }

        public void StatusCompleted()
        {
            Browser.WaitUntilElementIsDisplayed((By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-history/div/div/div[3]/div[1]/div[3]/under-status-filter/div/button")), 5);
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-history/div/div/div[3]/div[1]/div[3]/under-status-filter/div/button")).Click();
            Browser.WaitUntilElementIsDisplayed((By.CssSelector(".dropdown-menu > li:nth-child(1) > a:nth-child(1)")), 5);
            Browser.Driver.FindElement(By.CssSelector(".dropdown-menu > li:nth-child(2) > a:nth-child(1)")).Click();
        }

        public void StatusUserCanceled()
        {
            Browser.WaitUntilElementIsDisplayed((By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-history/div/div/div[3]/div[1]/div[3]/under-status-filter/div/button")), 5);
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-history/div/div/div[3]/div[1]/div[3]/under-status-filter/div/button")).Click();
            Browser.WaitUntilElementIsDisplayed((By.CssSelector(".dropdown-menu > li:nth-child(1) > a:nth-child(1)")), 5);
            Browser.Driver.FindElement(By.CssSelector(".dropdown-menu > li:nth-child(3) > a:nth-child(1)")).Click();
        }

        public void StatusDriverCanceled()
        {
            Browser.WaitUntilElementIsDisplayed((By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-history/div/div/div[3]/div[1]/div[3]/under-status-filter/div/button")), 5);
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-history/div/div/div[3]/div[1]/div[3]/under-status-filter/div/button")).Click();
            Browser.WaitUntilElementIsDisplayed((By.CssSelector(".dropdown-menu > li:nth-child(1) > a:nth-child(1)")), 5);
            Browser.Driver.FindElement(By.CssSelector(".dropdown-menu > li:nth-child(4) > a:nth-child(1)")).Click();
        }


        public void tableContentStatusCompleted()
        {
            IWebElement tag = Browser.Driver.FindElement(By.TagName("table"));

            Thread.Sleep(100);
            Assert.IsTrue(tag.Text.Contains("Cash") | tag.Text.Contains("Under"));
            Assert.IsTrue(tag.Text.Contains("Completed"));
            Assert.IsFalse(tag.Text.Contains("User canceled") | tag.Text.Contains("Driver canceled"));
        }

        public void tableContentStatusUserCanceled()
        {
            IWebElement tag = Browser.Driver.FindElement(By.TagName("table"));

            Thread.Sleep(100);
            Assert.IsFalse(tag.Text.Contains("Cash") | tag.Text.Contains("Under"));
            Assert.IsTrue(tag.Text.Contains("User canceled"));
            Assert.IsFalse(tag.Text.Contains("Completed") | tag.Text.Contains("Driver canceled"));
        }

        public void tableContentStatusDriverCanceled()
        {
            IWebElement tag = Browser.Driver.FindElement(By.TagName("table"));

            Thread.Sleep(100);
            Assert.IsFalse(tag.Text.Contains("Cash") | tag.Text.Contains("Under"));
            Assert.IsTrue(tag.Text.Contains("Driver canceled"));
            Assert.IsFalse(tag.Text.Contains("Completed") | tag.Text.Contains("User canceled"));
        }


        public void NextPageStatusCompleted()
        {
            var nextButton = Browser.FindElement(By.CssSelector(".pagination-next > a:nth-child(1)"));
            var lastPage = Browser.FindElement(By.CssSelector(".pagination-last > a:nth-child(1)"));
            nextButton.Click();

            List<IWebElement> pagination = Browser.Driver.FindElements(By.ClassName("page-link")).ToList();
            int pageCount = pagination.Count;

            for (int i = 0; i < pageCount; i++)
            {
                Thread.Sleep(150);
                tableContentStatusCompleted();
                checkDateFormat();
                nextButton.Click();
            }
        }

        public void NextPageStatusUserCanceled()
        {
            var nextButton = Browser.FindElement(By.CssSelector(".pagination-next > a:nth-child(1)"));
            var lastPage = Browser.FindElement(By.CssSelector(".pagination-last > a:nth-child(1)"));
            nextButton.Click();

            List<IWebElement> pagination = Browser.Driver.FindElements(By.ClassName("page-link")).ToList();
            int pageCount = pagination.Count;

            for (int i = 0; i < pageCount; i++)
            {
                Thread.Sleep(150);
                tableContentStatusUserCanceled();
                checkDateFormat();
                nextButton.Click();
            }
        }

        public void NextPageStatusDriverCanceled()
        {
            var nextButton = Browser.FindElement(By.CssSelector(".pagination-next > a:nth-child(1)"));
            var lastPage = Browser.FindElement(By.CssSelector(".pagination-last > a:nth-child(1)"));
            nextButton.Click();

            List<IWebElement> pagination = Browser.Driver.FindElements(By.ClassName("page-link")).ToList();
            int pageCount = pagination.Count;

            for (int i = 0; i < pageCount; i++)
            {
                Thread.Sleep(150);
                tableContentStatusDriverCanceled();
                checkDateFormat();
                nextButton.Click();
            }
        }
    }
}



//Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-history/div/div/div[3]/div[1]/div[1]/under-date-range/input");
//            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-history/div/div/div[3]/div[1]/div[1]/under-date-range/input")).Click();
//string month = Browser.Driver.FindElement(By.ClassName("current")).Text;
//            if (month == "September" )
//            {
//                Browser.Driver.FindElement(By.XPath("/html/body/bs-daterangepicker-container/div/div/div/div/bs-days-calendar-view[1]/bs-calendar-layout/div[2]/table/tbody/tr[1]/td[7]/span"));
//            }
//            else
//            {
//                Browser.Driver.FindElement(By.ClassName("previous")).Click();
//            }
//            Browser.Driver.FindElement(By.XPath("/html/body/bs-daterangepicker-container/div/div/div/div/bs-days-calendar-view[2]/bs-calendar-layout/div[2]/table/tbody/tr[5]/td[4]/span")).Click();
