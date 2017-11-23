using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderAppTests.Pages;
using OpenQA.Selenium;
using UnderAppTests;
using System.Threading;

namespace UnderTests.__5f___AdministrationPageTests
{
    [TestClass]
    public class DriversNameAndEmailSorting_5_086_ : TestBase
    {
        [TestMethod]
        public void _5_086_DriversNameAndEmailSorting()
        {
            Pages.AdministrationPage.GoTo();
            Pages.AdministrationPage.logInAndNavigateToAdministrationPageDrivers();

            //Testing Name sorting 
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/div[2]/div[1]/table/thead/tr/th[1]/span");
            IWebElement tableOrder = Browser.Driver.FindElement(By.TagName("tbody"));
            Thread.Sleep(250);
            string orderBefore = tableOrder.Text;
            var nameSortButton = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/div[2]/div[1]/table/thead/tr/th[1]/span"));
            Assert.IsFalse(nameSortButton.GetAttribute("class").ToString().Contains("active"), "Sorting button is blue before it was clicked.");
            nameSortButton.Click();
            Thread.Sleep(250);
            string orderDescending = tableOrder.Text;
            Assert.IsTrue(nameSortButton.GetAttribute("class").ToString().Contains("bottom"), "Sorting is ascending or inactive when it should be descending.");
            Assert.IsTrue(nameSortButton.GetAttribute("class").ToString().Contains("active"), "Sorting button is not blue when it should be.");
            Assert.AreNotEqual(orderBefore, orderDescending);
            nameSortButton.Click();
            Thread.Sleep(250);
            string orderAscending = tableOrder.Text;
            Assert.IsTrue(nameSortButton.GetAttribute("class").ToString().Contains("top"), "Sorting is descending or inactive when it should be ascending.");
            Assert.IsTrue(nameSortButton.GetAttribute("class").ToString().Contains("active"), "Sorting button is not blue when it should be.");
            Thread.Sleep(250);
            Assert.AreNotEqual(orderBefore, orderAscending);
            Assert.AreNotEqual(orderDescending, orderAscending);

            //Testing Email sorting

            var emailSortButton = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/div[2]/div[1]/table/thead/tr/th[2]/span"));
            Assert.IsFalse(emailSortButton.GetAttribute("class").ToString().Contains("active"), "Sorting button is blue before it was clicked.");
            emailSortButton.Click();
            Thread.Sleep(250);
            string emailOrderDescending = tableOrder.Text;
            Assert.IsFalse(nameSortButton.GetAttribute("class").ToString().Contains("active"), "Sorting button is blue before it was clicked.");
            Assert.IsTrue(emailSortButton.GetAttribute("class").ToString().Contains("bottom"), "Sorting is ascending or inactive when it should be descending.");
            Assert.IsTrue(emailSortButton.GetAttribute("class").ToString().Contains("active"), "Sorting button is not blue when it should be.");
            Assert.AreNotEqual(orderBefore, emailOrderDescending);
            emailSortButton.Click();
            Thread.Sleep(250);
            string emailOrderAscending = tableOrder.Text;
            Assert.IsTrue(emailSortButton.GetAttribute("class").ToString().Contains("active"), "Sorting button is not blue when it should be.");
            Assert.IsTrue(emailSortButton.GetAttribute("class").ToString().Contains("top"), "Sorting is descending or inactive when it should be ascending.");
            Thread.Sleep(250);
            Assert.AreNotEqual(orderBefore, emailOrderAscending);
            Assert.AreNotEqual(emailOrderDescending, emailOrderAscending);

        }
    }
}
