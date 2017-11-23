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
    public class DeleteDriver_5_082_ : TestBase
    {
        [TestMethod]
        public void _5_082_DeleteDriver()
        {
            Pages.AdministrationPage.GoTo();
            Pages.AdministrationPage.logInAndNavigateToAdministrationPageDrivers();
            Thread.Sleep(150);
            int rowCountBeforeDelete = Browser.Driver.FindElements(By.TagName("tr")).Count;
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/div[2]/div[1]/table/tbody/tr[10]/td[5]")).Click();         
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-confirm-modal/div/div/div/div/div[3]/button[2]")).Click();
            Thread.Sleep(500);
            int rowCountAfterDelete = Browser.Driver.FindElements(By.TagName("tr")).Count;
            Assert.AreNotEqual(rowCountBeforeDelete, rowCountAfterDelete, "User was not deleted!");
          
        }
    }
}
