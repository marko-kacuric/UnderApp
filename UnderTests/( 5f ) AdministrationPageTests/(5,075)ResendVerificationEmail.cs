using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderAppTests.Pages;
using OpenQA.Selenium;

namespace UnderTests.AdministrationPage
{
    [TestClass]
    public class ResendVerificationEmail_5_075_ : TestBase
    {
        [TestMethod]

        public void _5_075_ResendVerificationEmail()
        {
            Pages.AdministrationPage.GoTo();
            Pages.AdministrationPage.logInAndNavigateToAdministrationPageDrivers();
            Pages.AdministrationPage.openEditDriverModal();
            Pages.AdministrationPage.resendVerificationEmail();
        }
    }
}
