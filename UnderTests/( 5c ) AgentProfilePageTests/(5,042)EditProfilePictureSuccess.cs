using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class EditProfilePictureSuccess_5_042_ : TestBase
    {
        [TestMethod]
        public void _5_042_EditProfilePictureSuccess()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();
            Pages.AgentProfilePage.deleteProfileImage();
            Thread.Sleep(1500);
            string afterDelete = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[2]/div/under-profile-image/div/div")).GetAttribute("style");
            Pages.AgentProfilePage.editProfileImage();
            Thread.Sleep(2000);
            string afterUpload = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[2]/div/under-profile-image/div/div")).GetAttribute("style");

            Assert.AreNotEqual(afterDelete, afterUpload, "Image not uploaded, something went wrong!");
        }
    }
}
