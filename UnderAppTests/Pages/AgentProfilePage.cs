using OpenQA.Selenium;
using AutoItX3Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System;
using System.IO;
using UnderAppTests.Properties;
using System.Reflection;

namespace UnderAppTests.Pages
{
    public class AgentProfilePage
    {

        public void GoTo()
        {
            Browser.GoTo("https://agent.under.taxi/#/login", false);
        }

        public void LogInAndNavigateToProfilepage()
        {
            Pages.Login.LogIn("marko.kacuric@p3-group.com", "Test1!@#$%^&*()_+-=[]{]';:,./|<>`~üöäÄÜÖß");
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-user-header/div/div[2]/div/div[2]/button[2]");
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-user-header/div/div[2]/div/div[2]/button[2]")).Click();
        }

        public void enterFirstName(string firstName)
        {
            var firstNameField = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[1]/div[2]/div[1]/input"));
            firstNameField.Clear();
            firstNameField.SendKeys(firstName);
        }

        public string getFirstNameFieldText()
        {
            var nameField = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[1]/div[2]/div[1]/input"));
            string firstNameText = nameField.GetAttribute("value").ToString();
            return firstNameText;
        }

        public void enterLastName(string lastName)
        {
            var lastNameField = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[1]/div[2]/div[2]/input"));
            lastNameField.Clear();
            lastNameField.SendKeys(lastName);
        }

        public string getLastNameFieldText()
        {
            var lastNameField = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[1]/div[2]/div[2]/input"));
            string lastNameText = lastNameField.GetAttribute("value").ToString();
            return lastNameText;
        }

        public void selectCountryGermany()
        {
            Browser.WaitUntilElementIsDisplayed(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[1]/div[3]/div[1]/under-country-calling-codes/div/button"), 5);
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[1]/div[3]/div[1]/under-country-calling-codes/div/button")).Click();
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[1]/div[3]/div[1]/under-country-calling-codes/div/ul/li[1]/div/div/div")).Click();
        }

        public void selectCountrySerbia()
        {
            Browser.WaitUntilElementIsDisplayed(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[1]/div[3]/div[1]/under-country-calling-codes/div/button"), 5);
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[1]/div[3]/div[1]/under-country-calling-codes/div/button")).Click();
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[1]/div[3]/div[1]/under-country-calling-codes/div/ul/li[2]/div/div/div")).Click();
        }

        public void selectCountrySpain()
        {
            Browser.WaitUntilElementIsDisplayed(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[1]/div[3]/div[1]/under-country-calling-codes/div/button"), 5);
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[1]/div[3]/div[1]/under-country-calling-codes/div/button")).Click();
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[1]/div[3]/div[1]/under-country-calling-codes/div/ul/li[3]/div/div/div")).Click();
        }

        public void enterMobileNumber(string mobile)
        {
            Browser.WaitUntilElementIsDisplayed(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[1]/div[3]/div[2]/input"), 5);
            var mobileNumberField = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[1]/div[3]/div[2]/input"));
            mobileNumberField.Clear();
            mobileNumberField.SendKeys(mobile);
        }

        public string getMobileTextField()
        {
            var mobileNumberField = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[1]/div[3]/div[2]/input"));
            string mobileFiledText = mobileNumberField.GetAttribute("value");
            return mobileFiledText;
        }

        public void enterEmail(string email)
        {
            var emailField = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[1]/div[4]/div/input"));
            emailField.Clear();
            emailField.SendKeys(email);
        }

        public string getEmailText()
        {
            var emailField = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[1]/div[4]/div/input"));
            string emailFieldText = emailField.GetAttribute("value");
            return emailFieldText;
        }

        public void changeEmailModalVisible()
        {
            Browser.WaitUntilElementIsDisplayed(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-change-email-modal/div/div/div/div[2]/div[2]/div"), 5);
            string changeEmailMsg = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-change-email-modal/div/div/div/div[2]/div[2]/div")).Text;
            Assert.AreEqual("You need to enter password in order to validate email change. Please click close if you do not want to make changes.", changeEmailMsg, "Wrong modal opened for change email");
        }

        public void changeEmailPassword(string password)
        {
            var passwordField = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-change-email-modal/div/div/div/div[2]/div[3]/div/input"));
            passwordField.SendKeys(password);
        }

        public void closeChangeEmailModal()
        {
            By button = By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-change-email-modal/div/div/div/div[3]/button");

            if (Browser.WaitUntilElementIsEnabled(button, 5))
            {
                Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-change-email-modal/div/div/div/div[3]/button")).Click();
            }
            else
                Assert.Fail("Close button not clickable, something went wrong.");
        }

        public void changeEmailValidatePassword()
        {
            var buttonStatus = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-change-email-modal/div/div/div/div[2]/div[4]/div/button"));

            if (buttonStatus.Enabled)
            {
                buttonStatus.Click();
            }
            else
                Assert.Fail("Validate button disabled, password not valid!");
        }

        public bool changeEmailWrongPasswordMessageDisplayed()
        {
            if (Browser.ElementIsDisplayed(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-change-email-modal/div/div/div/div[2]/div[1]/div")))
            {
                return true;
            }
            else
                return false;
        }

        public void changePassword(string currentPassword, string newPassword, string confirmNewPassword)
        {
            Thread.Sleep(500);
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[2]/div/div[2]/div[1]/span")).Click();

            By changePasswordModal = By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-change-password-modal/div/div/div");
            Browser.WaitUntilElementIsDisplayed(changePasswordModal, 3);

            var currentPasswordField = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-change-password-modal/div/div/div/div[2]/div[3]/div/div[1]/div/input"));
            currentPasswordField.SendKeys(currentPassword);

            var newPasswordField = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-change-password-modal/div/div/div/div[2]/div[3]/div/div[2]/div/input"));
            newPasswordField.SendKeys(newPassword);

            var confirmNewPasswordField = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-change-password-modal/div/div/div/div[2]/div[3]/div/div[3]/div/input"));
            confirmNewPasswordField.SendKeys(confirmNewPassword);
        }

        public void changePasswordSaveButton()
        {
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-change-password-modal/div/div/div/div[2]/div[3]/div/button")).Click();
        }

        public void closeChangePasswordModal()
        {
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-change-password-modal/div/div/div/div[1]/button")).Click();
        }
        public void deleteProfileImage()
        {
            Thread.Sleep(1500);
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[2]/div/div[1]")).Click();

            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-confirm-modal/div/div/div/div");

            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-confirm-modal/div/div/div/div/div[3]/button[2]")).Click();
        }

        public void cancelProfileImageDelete()
        {
            
            Browser.WaitUntilElementIsEnabled(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[2]/div/div[1]"), 5);
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[2]/div/div[1]")).Click();

            By deleteModal = By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-confirm-modal/div/div/div/div");
            Browser.WaitUntilElementIsDisplayed(deleteModal, 2);

            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-confirm-modal/div/div/div/div/div[3]/button[1]")).Click();

        }

        public void editProfileImage()
        {
            string startupPath = AppDomain.CurrentDomain.BaseDirectory;
            string path = startupPath + @"\Images\gw2-raptor-mount.jpg";           

            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[2]/div/div[2]")).Click();

            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-user-image-upload-modal/div/div/div");

            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-user-image-upload-modal/div/div/div/div[2]/div[1]/under-user-image-upload/div/div/div/div")).Click();
            Thread.Sleep(1000);

            AutoItX3 addImage = new AutoItX3();
            addImage.WinActive("Open");
            Thread.Sleep(500);
            addImage.Send(path);
            Thread.Sleep(500);
            addImage.Send("{ENTER}");

        }

        public void editProfileImageUnsupportedFormat()
        {
            string startupPath = AppDomain.CurrentDomain.BaseDirectory;
            string path = startupPath + @"\Images\Teammanagement.pptm";

            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[2]/div/div[2]")).Click();

            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-user-image-upload-modal/div/div/div");

            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-user-image-upload-modal/div/div/div/div[2]/div[1]/under-user-image-upload/div/div/div/div")).Click();
            Thread.Sleep(1000);

            AutoItX3 addImage = new AutoItX3();
            addImage.WinActive("Open");
            Thread.Sleep(500);
            addImage.Send(path);
            Thread.Sleep(500);
            addImage.Send("{ENTER}");
        }

        public void editProfileImageSizeExceeded()
        {
            string startupPath = AppDomain.CurrentDomain.BaseDirectory;
            string path = startupPath + @"\Images\road.jpg";

            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[2]/div/div[2]")).Click();

            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-user-image-upload-modal/div/div/div");

            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-user-image-upload-modal/div/div/div/div[2]/div[1]/under-user-image-upload/div/div/div/div")).Click();
            Thread.Sleep(1000);

            AutoItX3 addImage = new AutoItX3();
            addImage.WinActive("Open");
            Thread.Sleep(500);
            addImage.Send(path);
            Thread.Sleep(500);
            addImage.Send("{ENTER}");
        }


        public void editProfileImageFailed()
        {
            string startupPath = AppDomain.CurrentDomain.BaseDirectory;
            string path = startupPath + @"\Images\gw2-raptor-mount.jpg";

            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[2]/div/div[2]")).Click();

            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-user-image-upload-modal/div/div/div");

            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-user-image-upload-modal/div/div/div/div[2]/div[1]/under-user-image-upload/div/div/div/div")).Click();
            Thread.Sleep(1000);

            AutoItX3 addImage = new AutoItX3();
            addImage.WinActive("Open");
            Thread.Sleep(500);
            addImage.Send(path);
            addImage.Send("{ESCAPE}");
            Thread.Sleep(500);

            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-user-image-upload-modal/div/div/div/div[1]/button")).Click();
        }

        public void saveChanges()
        {
            var saveButton = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[2]/button"));
            saveButton.Click();
        }

    }
}


