using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.HistoryPageTests
{
    [TestClass]
    public class PaymentFilterCash_5_059_ : TestBase
    {
        [TestMethod]
        public void _5_059_PaymentFilterCash()
        {
            Pages.HistoryPage.GoTo();
            Pages.HistoryPage.LogInAndNavigateToHistoryPage();

            Pages.HistoryPage.PaymentCash();
            Thread.Sleep(150);

            Pages.HistoryPage.tableContentPaymentCash();
            Pages.HistoryPage.checkDateFormat();
            Pages.HistoryPage.NextPageCash();
            Thread.Sleep(150);
        }
    }
}
