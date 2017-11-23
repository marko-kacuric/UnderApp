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
    public class CancelResendVerificationEmail_5_076_ : TestBase
    {
        [TestMethod]
        public void _5_076_CancelResendVerificationEmail()
        {
            Pages.AdministrationPage.GoTo();
            Pages.AdministrationPage.logInAndNavigateToAdministrationPageDrivers();
            Pages.AdministrationPage.openEditDriverModal();
            Pages.AdministrationPage.cancelResendVerificationEmail();
        }
    }
}
