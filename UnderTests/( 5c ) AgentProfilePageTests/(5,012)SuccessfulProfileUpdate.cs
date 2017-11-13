using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class SuccessfulProfileUpdate_5_012_ : TestBase
    {
        [TestMethod]

        public void _5_012_SuccessfulProfileUpdate()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();

            Pages.AgentProfilePage.enterFirstName("marko");
            Pages.AgentProfilePage.enterLastName("marko marko");
            Pages.AgentProfilePage.selectCountryGermany();
            Pages.AgentProfilePage.enterMobileNumber("0661234567");
            Pages.AgentProfilePage.enterEmail("marko.kacuric@p3-group.com");

            //Pages.AgentProfilePage.editProfileImage(@"C:\Users\kci\Desktop\UnderAgentProfileImages\gw2-raptor-mount.jpg");

            var buttonStatus = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[2]/button"));

            if (buttonStatus.Enabled)
            {
                buttonStatus.Click();
            }
            else
                Assert.Fail("Save button is disabled, some info may be invalid.");

            Pages.AgentProfilePage.saveChanges();
        }

    }
}
