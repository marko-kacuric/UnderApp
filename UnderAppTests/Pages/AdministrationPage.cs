using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System;
namespace UnderAppTests.Pages
{
    public class AdministrationPage
    {

        public void GoTo()
        {
            Browser.GoTo("https://agent.under.taxi/#/login", false);
        }

        public void logInAndNavigateToAdministrationPage()
        {
            Pages.Login.LogIn("marko.kacuric@p3-group.com", "Test1!@#$%^&*()_+-=[]{]';:,./|<>`~üöäÄÜÖß");
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-user-header/div/div[2]/div/div[2]/button[5]");
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-user-header/div/div[2]/div/div[2]/button[5]")).Click();
        }


        public void selectCountryGermany()
        {
            Browser.WaitUntilElementIsDisplayed(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-add-edit-driver-modal/div/div/div/div/div[2]/div/div[1]/div[5]/div[1]/under-country-calling-codes/div/button"), 5);
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-add-edit-driver-modal/div/div/div/div/div[2]/div/div[1]/div[5]/div[1]/under-country-calling-codes/div/button")).Click();
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-add-edit-driver-modal/div/div/div/div/div[2]/div/div[1]/div[5]/div[1]/under-country-calling-codes/div/ul/li[1]/div/div/div")).Click();
        }

        public void selectCountrySerbia()
        {
            Thread.Sleep(150);
            Browser.WaitUntilElementIsDisplayed(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-add-edit-driver-modal/div/div/div/div/div[2]/div/div[1]/div[5]/div[1]/under-country-calling-codes/div/button"), 5);
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-add-edit-driver-modal/div/div/div/div/div[2]/div/div[1]/div[5]/div[1]/under-country-calling-codes/div/button")).Click();
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-add-edit-driver-modal/div/div/div/div/div[2]/div/div[1]/div[5]/div[1]/under-country-calling-codes/div/ul/li[2]/div/div/div")).Click();
        }

        public void selectCountrySpain()
        {
            Browser.WaitUntilElementIsDisplayed(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-add-edit-driver-modal/div/div/div/div/div[2]/div/div[1]/div[5]/div[1]/under-country-calling-codes/div/button"), 5);
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-add-edit-driver-modal/div/div/div/div/div[2]/div/div[1]/div[5]/div[1]/under-country-calling-codes/div/button")).Click();
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-add-edit-driver-modal/div/div/div/div/div[2]/div/div[1]/div[5]/div[1]/under-country-calling-codes/div/ul/li[3]/div/div/div")).Click();
        }



        public void openAddDriverModal()
        {
            Browser.WaitUntilElementIsEnabled(By.CssSelector(".add-driver-btn"), 5);
            Browser.Driver.FindElement(By.CssSelector(".add-driver-btn")).Click();
            Browser.WaitUntilElementIsDisplayed(By.CssSelector(".administration-body > under-administration-drivers:nth-child(2) > under-add-edit-driver-modal:nth-child(5) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1)"), 5);
        }

        public void addDriverSuccessful(string firstName, string lastName, string email)
        {
            string domen = "@testemail.com";
            Random rnd = new Random();
            int number = rnd.Next(1, 100);
            int mobileNumberRandom = rnd.Next(1000000, 1000000000);

            var firstNameField = Browser.Driver.FindElement(By.CssSelector("div.col-xs-8:nth-child(1) > div:nth-child(3) > div:nth-child(1) > input:nth-child(1)"));
            var lastNameField = Browser.Driver.FindElement(By.CssSelector("div.col-xs-8:nth-child(1) > div:nth-child(3) > div:nth-child(2) > input:nth-child(1)"));
            var mobileNumberField = Browser.Driver.FindElement(By.CssSelector("div.col-xs-8:nth-child(1) > div:nth-child(5) > div:nth-child(2) > input:nth-child(1)"));
            var emailField = Browser.Driver.FindElement(By.CssSelector("div.row:nth-child(7) > div:nth-child(1) > input:nth-child(1)"));

            firstNameField.SendKeys(firstName + number);
            lastNameField.SendKeys(lastName + number);
            mobileNumberField.SendKeys("" + mobileNumberRandom);
            emailField.SendKeys(email + number + domen);

            clickSaveButtonAddDriver();

            Thread.Sleep(500);
            IWebElement tableTag = Browser.FindElement(By.TagName("table"));

            Assert.IsTrue(tableTag.Text.Contains(firstName + number));
            Assert.IsTrue(tableTag.Text.Contains(lastName + number));
            Assert.IsTrue(tableTag.Text.Contains(email + number + domen));
            Assert.IsTrue(tableTag.Text.Contains("" + mobileNumberRandom));
        }

        public void addDriverCanceled(string firstName, string lastName, string email)
        {
            string domen = "@testemail.com";
            Random rnd = new Random();
            int number = rnd.Next(1, 100);
            int mobileNumberRandom = rnd.Next(1000000, 1000000000);

            var firstNameField = Browser.Driver.FindElement(By.CssSelector("div.col-xs-8:nth-child(1) > div:nth-child(3) > div:nth-child(1) > input:nth-child(1)"));
            var lastNameField = Browser.Driver.FindElement(By.CssSelector("div.col-xs-8:nth-child(1) > div:nth-child(3) > div:nth-child(2) > input:nth-child(1)"));
            var mobileNumberField = Browser.Driver.FindElement(By.CssSelector("div.col-xs-8:nth-child(1) > div:nth-child(5) > div:nth-child(2) > input:nth-child(1)"));
            var emailField = Browser.Driver.FindElement(By.CssSelector("div.row:nth-child(7) > div:nth-child(1) > input:nth-child(1)"));

            firstNameField.SendKeys(firstName + number);
            lastNameField.SendKeys(lastName + number);
            mobileNumberField.SendKeys("" + mobileNumberRandom);
            emailField.SendKeys(email + number + domen);

            clickCancelButtonAddDriver();

            Thread.Sleep(500);
            IWebElement tableTag = Browser.FindElement(By.TagName("table"));

            Assert.IsFalse(tableTag.Text.Contains(firstName + number));
            Assert.IsFalse(tableTag.Text.Contains(lastName + number));
            Assert.IsFalse(tableTag.Text.Contains(email + number + domen));
            Assert.IsFalse(tableTag.Text.Contains("" + mobileNumberRandom));

        }

        public void addDriverEmpty(string firstName, string lastName, string email)
        {

            var firstNameField = Browser.Driver.FindElement(By.CssSelector("div.col-xs-8:nth-child(1) > div:nth-child(3) > div:nth-child(1) > input:nth-child(1)"));
            var lastNameField = Browser.Driver.FindElement(By.CssSelector("div.col-xs-8:nth-child(1) > div:nth-child(3) > div:nth-child(2) > input:nth-child(1)"));
            var mobileNumberField = Browser.Driver.FindElement(By.CssSelector("div.col-xs-8:nth-child(1) > div:nth-child(5) > div:nth-child(2) > input:nth-child(1)"));
            var emailField = Browser.Driver.FindElement(By.CssSelector("div.row:nth-child(7) > div:nth-child(1) > input:nth-child(1)"));

            firstNameField.SendKeys(firstName);
            lastNameField.SendKeys(lastName);
            mobileNumberField.SendKeys("");
            emailField.SendKeys(email);
        }

        public void clickSaveButtonAddDriver()
        {
            Browser.Driver.FindElement(By.CssSelector(".under-save")).Click();
        }

        public void clickCancelButtonAddDriver()
        {
            Browser.Driver.FindElement(By.CssSelector(".administration-body > under-administration-drivers:nth-child(2) > under-add-edit-driver-modal:nth-child(5) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(3) > button:nth-child(1)")).Click();
        }



        public void openEditDriverModal()
        {
            Browser.WaitUntilElementIsEnabled(By.CssSelector(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4)"), 10);
            Browser.Driver.FindElement(By.CssSelector(".table > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4)")).Click();
            Browser.WaitUntilElementIsDisplayed(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-add-edit-driver-modal/div/div/div/div"), 5);
        }

        public void editDriverSuccessfuly(string firstName, string lastName)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 100);

            var firstNameField = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-add-edit-driver-modal/div/div/div/div/div[2]/div[1]/div[1]/div[3]/div[1]/input"));
            var lastNameField = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-add-edit-driver-modal/div/div/div/div/div[2]/div[1]/div[1]/div[3]/div[2]/input"));

            firstNameField.Clear();
            firstNameField.SendKeys(firstName + number);
            lastNameField.Clear();
            lastNameField.SendKeys(lastName + number);

            editDriverClickSaveButton();

            Thread.Sleep(500);
            IWebElement tableTag = Browser.FindElement(By.TagName("table"));

            Assert.IsTrue(tableTag.Text.Contains(firstName + number), "Driver edit not completed successfuly, edited info not displayed in table!");
            Assert.IsTrue(tableTag.Text.Contains(lastName + number), "Driver edit not completed successfuly, edited info not displayed in table!");
        }

        public void editDriverClickSaveButton()
        {
            Browser.Driver.FindElement(By.CssSelector(".under-save")).Click();
        }

        public void editDriverCancelEdit(string firstName, string lastName)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 100);

            var firstNameField = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-add-edit-driver-modal/div/div/div/div/div[2]/div[1]/div[1]/div[3]/div[1]/input"));
            var lastNameField = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-add-edit-driver-modal/div/div/div/div/div[2]/div[1]/div[1]/div[3]/div[2]/input"));

            firstNameField.Clear();
            firstNameField.SendKeys(firstName + number);
            lastNameField.Clear();
            lastNameField.SendKeys(lastName + number);

            editDriverClickCancelButton();

            Thread.Sleep(500);
            IWebElement tableTag = Browser.FindElement(By.TagName("table"));

            Assert.IsFalse(tableTag.Text.Contains(firstName + number), "Edited info has been saved when it should not have been!");
            Assert.IsFalse(tableTag.Text.Contains(lastName + number), "Edited info has been saved when it should not have been!");
        }

        public void editDriverClickCancelButton()
        {
            Browser.Driver.FindElement(By.CssSelector(".edit-footer-settings > button:nth-child(1)")).Click();
        }



        public void cancelResendVerificationEmail()
        {
            Browser.Driver.FindElement(By.CssSelector(".under-clickable-area")).Click();
            Browser.WaitUntilElementIsDisplayed(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-add-edit-driver-modal/under-confirm-modal[3]/div/div/div/div"), 5);
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-add-edit-driver-modal/under-confirm-modal[3]/div/div/div/div/div[3]/button[1]")).Click();
            Thread.Sleep(250);
            editDriverClickCancelButton();
            Assert.IsTrue(Browser.Driver.FindElement(By.CssSelector("button.header-button-active:nth-child(1)")).Displayed);

        }

        public void resendVerificationEmail()
        {
            Browser.Driver.FindElement(By.CssSelector(".under-clickable-area")).Click();
            Browser.WaitUntilElementIsDisplayed(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-add-edit-driver-modal/under-confirm-modal[3]/div/div/div/div"), 5);
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-add-edit-driver-modal/under-confirm-modal[3]/div/div/div/div/div[3]/button[2]")).Click();
            Thread.Sleep(250);
            string actualMessage = Browser.Driver.FindElement(By.CssSelector(".label-warning")).Text;
            string expectedMessage = "Error: Incomplete data sent, Email already verified.";
            Assert.AreEqual(expectedMessage, actualMessage, "Wrong error message displayed!");
            editDriverClickCancelButton();
        }



        public void setStatusBlocked()
        {
            Browser.Driver.FindElement(By.CssSelector(".add-edit-checkbox")).Click();
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-add-edit-driver-modal/under-confirm-modal[2]/div/div/div/div");
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-add-edit-driver-modal/under-confirm-modal[2]/div/div/div/div/div[3]/button[2]")).Click();
            Browser.WaitUntilElementIsDisplayed(By.CssSelector(".under-save"), 10);
            editDriverClickSaveButton();
            openEditDriverModal();
            Browser.WaitUntilElementIsDisplayed(By.CssSelector(".add-edit-checkbox"), 10);            
            var blockedCheckbox = Browser.Driver.FindElement(By.CssSelector(".add-edit-checkbox"));
            Assert.IsTrue(blockedCheckbox.Selected);

        }

        public void uncheckBlockedStatus()
        {
            Browser.Driver.FindElement(By.CssSelector(".add-edit-checkbox")).Click();
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-add-edit-driver-modal/under-confirm-modal[2]/div/div/div/div");
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-add-edit-driver-modal/under-confirm-modal[2]/div/div/div/div/div[3]/button[2]")).Click();
            Browser.WaitUntilElementIsDisplayed(By.CssSelector(".under-save"), 10);
            editDriverClickSaveButton();
            openEditDriverModal();
        }

        public void cancelDriverStatusChange()
        {
            bool getBlockedStatus = Browser.Driver.FindElement(By.CssSelector(".add-edit-checkbox")).Selected;
            Browser.Driver.FindElement(By.CssSelector(".add-edit-checkbox")).Click();
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-add-edit-driver-modal/under-confirm-modal[2]/div/div/div/div/div[3]/button[1]");
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/under-add-edit-driver-modal/under-confirm-modal[2]/div/div/div/div/div[3]/button[1]")).Click();
            bool blockedCheckbox = Browser.Driver.FindElement(By.CssSelector(".add-edit-checkbox")).Selected;
            Assert.AreEqual(getBlockedStatus, blockedCheckbox, "Blocked status not is not the same as before canceling status change!");

        }

        public void searchField(string text)
        {
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-administration/div/div/div[2]/div[2]/under-administration-drivers/div[1]/div[1]/under-search/div/div[1]/input");
            var searchField = Browser.Driver.FindElement(By.CssSelector(".under-search-input"));
            searchField.SendKeys(text);           
        }

    }
}
