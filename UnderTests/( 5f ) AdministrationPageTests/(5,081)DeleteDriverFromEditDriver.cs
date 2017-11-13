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
    public class DeleteDriverFromEditDriver_5_081_ : TestBase
    {
        [TestMethod]
        public void _5_081_DeleteDriverFromEditDriver()
        {
            Pages.AdministrationPage.GoTo();
            Pages.AdministrationPage.logInAndNavigateToAdministrationPage();
            Pages.AdministrationPage.openEditDriverModal();
            string firstNameField = Browser.Driver.FindElement(By.CssSelector("div.col-xs-8:nth-child(1) > div:nth-child(3) > div:nth-child(1) > input:nth-child(1)")).Text;
            string emailField = Browser.Driver.FindElement(By.CssSelector("div.row:nth-child(7) > div:nth-child(1) > input:nth-child(1)")).Text;
            Browser.Driver.FindElement(By.CssSelector("button.btn:nth-child(3)")).Click();
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-add-edit-driver-modal/under-confirm-modal[1]/div/div/div/div/div[3]/button[2]");
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-add-edit-driver-modal/under-confirm-modal[1]/div/div/div/div/div[3]/button[2]")).Click();
            Thread.Sleep(500);
            IWebElement tableTag = Browser.Driver.FindElement(By.TagName("table"));
            Assert.IsFalse(tableTag.Text.Contains(firstNameField));
            Assert.IsFalse(tableTag.Text.Contains(emailField));
        }
    }
}
