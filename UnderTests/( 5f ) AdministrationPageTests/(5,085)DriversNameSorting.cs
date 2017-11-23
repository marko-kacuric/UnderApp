using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderAppTests.Pages;
using OpenQA.Selenium;
using UnderAppTests;
using System.Threading;

namespace UnderTests.__5f___AdministrationPageTests
{
    [TestClass]
    public class DriversNameSorting_5_085_ : TestBase
    {
        [TestMethod]
        public void _5_085_DriversNameSorting()
        {
            Pages.AdministrationPage.GoTo();
            Pages.AdministrationPage.logInAndNavigateToAdministrationPageDrivers();

            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/div[2]/div[1]/table/thead/tr/th[1]/span");
            IWebElement tableOrder = Browser.Driver.FindElement(By.TagName("tbody"));
            Thread.Sleep(250);
            string orderBefore = tableOrder.Text;
            var nameSortButton = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/div[2]/div[1]/table/thead/tr/th[1]/span"));
            Assert.IsFalse(nameSortButton.GetAttribute("class").ToString().Contains("active"));
            nameSortButton.Click();
            Thread.Sleep(250);
            string orderDescending = tableOrder.Text;
            Assert.IsTrue(nameSortButton.GetAttribute("class").ToString().Contains("bottom"));
            Assert.IsTrue(nameSortButton.GetAttribute("class").ToString().Contains("active"));
            Assert.AreNotEqual(orderBefore, orderDescending);
            nameSortButton.Click();
            Thread.Sleep(250);
            string orderAscending = tableOrder.Text;
            Assert.IsTrue(nameSortButton.GetAttribute("class").ToString().Contains("top"));
            Assert.IsTrue(nameSortButton.GetAttribute("class").ToString().Contains("active"));
            Thread.Sleep(250);
            Assert.AreNotEqual(orderBefore, orderAscending);
            Assert.AreNotEqual(orderDescending, orderAscending);
        }
    }
}
