using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderAppTests.Pages;

namespace UnderTests.AdministrationPage
{
    [TestClass]
    public class AddDriverCanceled_5_071_ : TestBase
    {
        [TestMethod]
        public void _5_071_AddDriverCanceled()
        {
            Pages.AdministrationPage.GoTo();
            Pages.AdministrationPage.logInAndNavigateToAdministrationPageDrivers();
            Pages.AdministrationPage.openAddDriverModal();
            Pages.AdministrationPage.selectCountrySpain();
            Pages.AdministrationPage.addDriverCanceled("testDriverFirstName", "testDriverLastName", "testdriveremail");
        }
    }
}
