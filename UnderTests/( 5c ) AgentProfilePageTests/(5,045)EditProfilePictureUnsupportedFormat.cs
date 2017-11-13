using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class EditProfilePictureUnsupportedFormat_5_045_ : TestBase
    {
        [TestMethod]
        public void _5_045_EditProfilePictureUnsupportedFormat()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();
            Thread.Sleep(1000);
            Pages.AgentProfilePage.editProfileImageUnsupportedFormat();
            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-user-image-upload-modal/div/div/div/div[2]/div[1]/under-user-image-upload/div/div/div[1]");
            string expectedErrorMessage = "Error: Wrong file type selected.Supported types:.jpg, .jpeg, .gif, .png.";

            string displayedErrorMessage = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-user-image-upload-modal/div/div/div/div[2]/div[1]/under-user-image-upload/div/div/div[1]")).Text;

            Assert.AreEqual(expectedErrorMessage, displayedErrorMessage, "Wrong error message displayed for unsupported format!");

        }
    }
}
