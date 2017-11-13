using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class DeleteProfilePhotoSuccess_5_040_ : TestBase
    {
        [TestMethod]
        public void _5_040_DeleteProfilePhotoSuccess()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();
            Pages.AgentProfilePage.deleteProfileImage();
            Thread.Sleep(1000);
            string imageDesc = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[2]/div/under-profile-image/div/div")).GetAttribute("style");
            Pages.AgentProfilePage.editProfileImage();           
            Pages.AgentProfilePage.deleteProfileImage();
            Thread.Sleep(1000);
            string imageDescUpload = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[2]/div/under-profile-image/div/div")).GetAttribute("style");
            Assert.AreEqual(imageDesc,imageDescUpload,"Image not deleted !");

        }
    }
}

