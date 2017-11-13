using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using UnderAppTests.Pages;

namespace UnderTests.HistoryPageTests
{
    [TestClass]
    public class PaymentFilterNoInvoice_5_061_ : TestBase
    {
        [TestMethod]
        public void _5_061_PaymentFilterNoInvoice()
        {
            Pages.HistoryPage.GoTo();
            Pages.HistoryPage.LogInAndNavigateToHistoryPage();

            Pages.HistoryPage.PaymentNoInvoice();
            Thread.Sleep(150);

            Pages.HistoryPage.tableContentPaymentNoInvoice();
            Pages.HistoryPage.checkDateFormat();
            Pages.HistoryPage.NextPageNoInvoice();
            Thread.Sleep(150);
        }
    }
}
