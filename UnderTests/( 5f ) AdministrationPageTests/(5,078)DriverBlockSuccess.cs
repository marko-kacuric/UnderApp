using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderAppTests.Pages;
using OpenQA.Selenium;
using UnderAppTests;

namespace UnderTests.AdministrationPage
{
    [TestClass]
    public class DriverBlockSuccess_5_078_ : TestBase
    {
        [TestMethod]
        public void _5_078_DriverBlockSuccess()
        {
            Pages.AdministrationPage.GoTo();
            Pages.AdministrationPage.logInAndNavigateToAdministrationPage();
            Pages.AdministrationPage.openEditDriverModal();
            var checkboxStatus = Browser.Driver.FindElement(By.CssSelector(".add-edit-checkbox"));
            if (!checkboxStatus.Selected)
            {
                Pages.AdministrationPage.setStatusBlocked();
            }
            else { 
                Pages.AdministrationPage.uncheckBlockedStatus();
            Pages.AdministrationPage.setStatusBlocked();
            }
        }
    }
}
