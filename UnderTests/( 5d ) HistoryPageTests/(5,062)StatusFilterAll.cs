using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderAppTests.Pages;

namespace UnderTests.HistoryPageTests
{
    [TestClass]
    public class StatusFilterAll_5_062_ : TestBase 
    {
        [TestMethod]
        public void _5_062_StatusFilterAll()
        {
            Pages.HistoryPage.GoTo();
            Pages.HistoryPage.LogInAndNavigateToHistoryPage();

            Pages.HistoryPage.StatusAll();
            Pages.HistoryPage.tableContentPaymentAll();
            Pages.HistoryPage.checkDateFormat();
            Pages.HistoryPage.NextPage();
        }
    }
}
