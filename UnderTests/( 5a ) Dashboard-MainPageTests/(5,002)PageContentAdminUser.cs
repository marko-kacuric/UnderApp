using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.Dashboard_MainPage
{
    [TestClass]
    public class PageContentAdminUser_5_002_ : TestBase
    {
        [TestMethod]
        public void _5_002_PageContentAdminUser()
        {
            Pages.DashboardPage.GoTo();
            Pages.DashboardPage.LogInAdmin();

            //click on PROFILE button
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-user-header/div/div[2]/div/div[2]/button[2]");
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-user-header/div/div[2]/div/div[2]/button[2]")).Click();
            //click on HISTORY button
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-user-header/div/div[2]/div/div[2]/button[3]");
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-user-header/div/div[2]/div/div[2]/button[3]")).Click();
            //click on REPORTS button, get forbidden 
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-user-header/div/div[2]/div/div[2]/button[4]");
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-user-header/div/div[2]/div/div[2]/button[4]")).Click();
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-reports/div/div/div[2]/div[2]/under-reports-transactions/under-error-modal/under-modal-dialog/div/div/div/div/div[1]/h4/div");
            string alertMsg = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-reports/div/div/div[2]/div[2]/under-reports-transactions/under-error-modal/under-modal-dialog/div/div/div/div/div[1]/h4/div")).Text;
            Assert.AreEqual("FORBIDDEN", alertMsg, "Wrong error message modal displayed!");
            Browser.Driver.FindElement(By.CssSelector("html body.modal-open under-agent under-agent-dashboard div.wrapper div.page-content-wrapper div.container-fluid div.row div.col-md-12 under-reports div.container-fluid.under-container div.row div.col-md-10.reports-container div under-reports-transactions under-error-modal under-modal-dialog div.under-modal.open div.modal.open div.modal-dialog.modal-sm.under-modal-dialog div.modal-content.under-modal-content div.modal-header.under-modal-header button.close.pull-right.under-close")).Click();

            //Confirm Administration button is disabled
            var administrationButton = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-user-header/div/div[2]/div/div[2]/button[5]"));
            Assert.IsFalse(administrationButton.Enabled);

            Pages.DashboardPage.validateDisplayedUsername();
        }

    }
}
