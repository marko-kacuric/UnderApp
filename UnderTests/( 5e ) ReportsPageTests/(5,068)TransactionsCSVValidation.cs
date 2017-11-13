using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnderAppTests.Pages;

namespace UnderTests.ReportsPageTests
{
    [TestClass]
    public class TransactionsCSVValidation_5_068_ : TestBase
    {
        [TestMethod]
        public void _5_068_TransactionsCSVValidation()
        {
            Pages.ReportsPage.GoTo();
            Pages.ReportsPage.logInAndNavigateToReportsPage();
            Thread.Sleep(100);
            Pages.ReportsPage.exportTableToCSV();
        }

    }
}
