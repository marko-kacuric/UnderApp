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
    public class AddDriverEmptyInputFields_5_072_ : TestBase
    {
        [TestMethod]

        public void _5_072_AddDriverEmptyInputFields()
        {
            Pages.AdministrationPage.GoTo();
            Pages.AdministrationPage.logInAndNavigateToAdministrationPageDrivers();
            Pages.AdministrationPage.openAddDriverModal();
            Pages.AdministrationPage.selectCountrySpain();
            Pages.AdministrationPage.addDriverEmpty("", "", "");
            Assert.IsFalse(UnderAppTests.Browser.Driver.FindElement(By.CssSelector(".under-save")).Enabled);
            Pages.AdministrationPage.clickCancelButtonAddDriver();

        }
    }
}
