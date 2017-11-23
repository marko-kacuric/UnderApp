using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderAppTests.Pages;
using UnderAppTests;
using System.Threading;
using OpenQA.Selenium;

namespace UnderTests.__5f___AdministrationPageTests
{
    [TestClass]
    public class AddAgentEmptyInfo_5_090_ : TestBase
    {
        [TestMethod]
        public void _5_090_AddAgentEmptyInfo()
        {
            Pages.AdministrationPage.GoTo();
            Pages.AdministrationPage.logInAndNavigateToAdministrationPageAgents();
            Pages.AdministrationPage.openAddAgentModal();

            var firstNameField = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-agents/under-add-edit-agent-modal/div/div/div/div/div[2]/div/div[1]/div[3]/div[1]/input"));
            var lastNameField = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-agents/under-add-edit-agent-modal/div/div/div/div/div[2]/div/div[1]/div[3]/div[2]/input"));
            var mobileNumberField = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-agents/under-add-edit-agent-modal/div/div/div/div/div[2]/div/div[1]/div[5]/div[2]/input"));
            var emailField = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-agents/under-add-edit-agent-modal/div/div/div/div/div[2]/div/div[1]/div[7]/div/input"));

            Assert.IsTrue(firstNameField.GetAttribute("class").ToString().Contains("warning-sign"));
            Assert.IsTrue(lastNameField.GetAttribute("class").ToString().Contains("warning-sign"));
            Assert.IsTrue(mobileNumberField.GetAttribute("class").ToString().Contains("warning-sign"));
            Assert.IsTrue(emailField.GetAttribute("class").ToString().Contains("warning-sign"));

            var saveButtonStatus = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-agents/under-add-edit-agent-modal/div/div/div/div/div[3]/button[2]"));
            Assert.IsFalse(saveButtonStatus.Enabled);

            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-agents/under-add-edit-agent-modal/div/div/div/div/div[1]/button")).Click();

            Assert.IsTrue(Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[1]")).GetAttribute("class").Contains("administration"));

        }
    }
}
