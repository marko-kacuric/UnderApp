using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class EditProfilePictureSupportedFormat9MB_5_046_ : TestBase
    {
        [TestMethod]
        public void _5_046_EditProfilePictureSupportedFormat9MB()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();
            Thread.Sleep(1000);
            Pages.AgentProfilePage.editProfileImageSizeExceeded();
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-user-image-upload-modal/div/div/div/div[2]/div[1]/under-user-image-upload/div/div/div[1]");
            string expectedErrorMessage = "Error: Image size is exceeding file upload limit";

            string displayedErrorMessage = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-user-image-upload-modal/div/div/div/div[2]/div[1]/under-user-image-upload/div/div/div[1]")).Text;

            Assert.AreEqual(expectedErrorMessage, displayedErrorMessage, "Wrong error message displayed for size limit!");
        }
    }
}
