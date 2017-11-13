using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Globalization;
using System.Threading;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.HistoryPageTests
{
    [TestClass]
    public class PaymentFilterAll_5_058_ : TestBase
    {
        [TestMethod]
        public void _5_058_PaymentFilterAll()
        {
            Pages.HistoryPage.GoTo();
            Pages.HistoryPage.LogInAndNavigateToHistoryPage();

            Pages.HistoryPage.PaymentAll();
            Thread.Sleep(150);

            Pages.HistoryPage.tableContentPaymentAll();
            Pages.HistoryPage.checkDateFormat();
            Pages.HistoryPage.NextPage();
            Thread.Sleep(150);

        }
    }
}
