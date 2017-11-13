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
    public class CancelBlockStatusChange_5_079_ : TestBase
    {
        [TestMethod]
        public void _5_079_CancelBlockStatusChange()
        {
            Pages.AdministrationPage.GoTo();
            Pages.AdministrationPage.logInAndNavigateToAdministrationPage();
            Pages.AdministrationPage.openEditDriverModal();
            bool blockedStatus = Browser.Driver.FindElement(By.CssSelector(".add-edit-checkbox")).Selected;

            if (blockedStatus == false)
            {
                Pages.AdministrationPage.setStatusBlocked();
                Pages.AdministrationPage.cancelDriverStatusChange();
            }
            else
                Pages.AdministrationPage.cancelDriverStatusChange();
        }

    }
}
