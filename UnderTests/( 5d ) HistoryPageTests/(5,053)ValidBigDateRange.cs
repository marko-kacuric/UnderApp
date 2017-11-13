using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderAppTests.Pages;

namespace UnderTests.__5d___HistoryPageTests
{
    [TestClass]
    public class ValidBigDateRange_5_053_ : TestBase
    {
        [TestMethod]
        public void _5_053_ValidBigDateRange()
        {
            Pages.HistoryPage.GoTo();
            Pages.HistoryPage.LogInAndNavigateToHistoryPage();
            Pages.HistoryPage.pickDate_5_053_TC();
        }

    }
}
