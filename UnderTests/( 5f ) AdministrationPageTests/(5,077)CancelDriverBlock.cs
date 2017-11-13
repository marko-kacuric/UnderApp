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
    public class CancelDriverBlock_5_077_ : TestBase
    {
        [TestMethod]
        public void _5_077_CancelDriverBlock()
        {
            Pages.AdministrationPage.GoTo();
            Pages.AdministrationPage.logInAndNavigateToAdministrationPage();
            Pages.AdministrationPage.openEditDriverModal();
            bool blockedStatus = Browser.Driver.FindElement(By.CssSelector(".add-edit-checkbox")).Selected;

            if (blockedStatus == true)
            {
                Pages.AdministrationPage.uncheckBlockedStatus();
                Pages.AdministrationPage.cancelDriverStatusChange();
            }
            else
                Pages.AdministrationPage.cancelDriverStatusChange();
        }

    }
}
