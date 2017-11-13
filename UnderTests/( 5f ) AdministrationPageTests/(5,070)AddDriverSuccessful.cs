using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderAppTests.Pages;

namespace UnderTests.AdministrationPage
{
    [TestClass]
    public class AddDriverSuccessful_5_070_ : TestBase
    {
        [TestMethod]

        public void _5_070_AddDriverSuccessful()
        {
            Pages.AdministrationPage.GoTo();
            Pages.AdministrationPage.logInAndNavigateToAdministrationPage();
            Pages.AdministrationPage.openAddDriverModal();
            Pages.AdministrationPage.selectCountrySerbia();
            Pages.AdministrationPage.addDriverSuccessful("testDriverFirstName","testDriverLastName","testdriveremail");
            
        }
    }
}
