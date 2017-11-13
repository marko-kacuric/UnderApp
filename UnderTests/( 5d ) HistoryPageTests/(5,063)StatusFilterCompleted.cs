using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderAppTests.Pages;

namespace UnderTests.HistoryPageTests
{
    [TestClass]
    public class StatusFilterCompleted_5_063_ : TestBase
    {
        [TestMethod]
        public void _5_063_StatusFilterCompleted()
        {
            Pages.HistoryPage.GoTo();
            Pages.HistoryPage.LogInAndNavigateToHistoryPage();

            Pages.HistoryPage.StatusCompleted();
            Pages.HistoryPage.tableContentStatusCompleted();
            Pages.HistoryPage.checkDateFormat();
            Pages.HistoryPage.NextPageStatusCompleted();
        }
    }
}
