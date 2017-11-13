using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderAppTests.Pages;
using OpenQA.Selenium;
using UnderAppTests;
using System.Threading;

namespace UnderTests.AdministrationPage
{
    [TestClass]
    public class SearchFieldTestCanceled_5_084_ : TestBase
    {
        [TestMethod]
        public void _5_084_SearchFieldTestCanceled()
        {
            Pages.AdministrationPage.GoTo();
            Pages.AdministrationPage.logInAndNavigateToAdministrationPage();
            Pages.AdministrationPage.searchField("t");
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/div[1]/div[1]/under-search/div/div[2]/div");
            var clearTextButton = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/div[1]/div[1]/under-search/div/div[2]/div"));
            Assert.IsTrue(clearTextButton.Displayed);
            Pages.AdministrationPage.searchField("est");
            Pages.AdministrationPage.searchField("Driver");
            Thread.Sleep(500);
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/div[1]/div[1]/under-search/div/div[2]/div")).Click();
            Thread.Sleep(500);
            Assert.IsFalse(clearTextButton.Displayed);
        }
    }
}
