using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderAppTests.Pages;

namespace UnderTests.HistoryPageTests
{
    [TestClass]
    public class StatusFilterUserCanceled_5_064_ : TestBase
    {
        [TestMethod]
        public void _5_064_StatusFilterUserCanceled()
        {
            Pages.HistoryPage.GoTo();
            Pages.HistoryPage.LogInAndNavigateToHistoryPage();

            Pages.HistoryPage.StatusUserCanceled();
            Pages.HistoryPage.tableContentStatusUserCanceled();
            Pages.HistoryPage.checkDateFormat();
            Pages.HistoryPage.NextPageStatusUserCanceled();
        }
    }
}
