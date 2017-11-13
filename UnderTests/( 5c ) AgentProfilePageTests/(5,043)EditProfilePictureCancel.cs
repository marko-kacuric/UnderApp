using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using UnderAppTests;
using UnderAppTests.Pages;


namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class EditProfilePictureCancel_5_043_ : TestBase
    {
        [TestMethod]
        public void _5_043_EditProfilePictureCancel()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();
            Thread.Sleep(1000);
            string beforeCancel = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[2]/div/under-profile-image/div/div")).GetAttribute("style");
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[2]/div/div[2]")).Click();
            Thread.Sleep(500);
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-user-image-upload-modal/div/div/div/div[1]/button")).Click();
            Thread.Sleep(1000);
            string afterCancel = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[2]/div/under-profile-image/div/div")).GetAttribute("style");

            Assert.AreEqual(beforeCancel, afterCancel, "Image not the same before and after cancel, something went wrong!");
        }

    }
}
