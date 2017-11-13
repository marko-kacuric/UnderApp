using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderAppTests.Pages;

namespace UnderTests.HistoryPageTests
{
    [TestClass]
    public class StatusFilterDriverCanceled_5_065_ : TestBase
    {
        [TestMethod]
        public void _5_065_StatusFilterDriverCanceled()
        {
            Pages.HistoryPage.GoTo();
            Pages.HistoryPage.LogInAndNavigateToHistoryPage();

            Pages.HistoryPage.StatusDriverCanceled();
            Pages.HistoryPage.tableContentStatusDriverCanceled();
            Pages.HistoryPage.checkDateFormat();
            Pages.HistoryPage.NextPageStatusDriverCanceled();
        }
    }
}
