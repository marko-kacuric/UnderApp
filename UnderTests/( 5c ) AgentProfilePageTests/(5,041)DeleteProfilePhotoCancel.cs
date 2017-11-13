using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class DeleteProfilePhotoCancel_5_041_ : TestBase
    {
        [TestMethod]
        public void _5_041_DeleteProfilePhotoCancel()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();
            Pages.AgentProfilePage.deleteProfileImage();
            Thread.Sleep(1500);
            Pages.AgentProfilePage.editProfileImage();
            Thread.Sleep(2000);
            string beforeDelete = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[2]/div/under-profile-image/div/div")).GetAttribute("style");
            Thread.Sleep(1000);
            Pages.AgentProfilePage.cancelProfileImageDelete();
            string afterDeleteCancel = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[2]/div/under-profile-image/div/div")).GetAttribute("style");

            Assert.AreEqual(beforeDelete, afterDeleteCancel, "Image got deleted when it should still be present!");
        }
    }
}
