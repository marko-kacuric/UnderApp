using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.HistoryPageTests
{
    [TestClass]
    public class PaymentFilterUnder_5_060_ : TestBase
    {
        [TestMethod]
        public void _5_060_PaymentFilterUnder()
        {
            Pages.HistoryPage.GoTo();
            Pages.HistoryPage.LogInAndNavigateToHistoryPage();

            Pages.HistoryPage.PaymentUnder();
            Thread.Sleep(150);

            Pages.HistoryPage.tableContentPaymentUnder();
            Pages.HistoryPage.checkDateFormat();
            Pages.HistoryPage.NextPageUnder();
            Thread.Sleep(150);
        }
    }
}
