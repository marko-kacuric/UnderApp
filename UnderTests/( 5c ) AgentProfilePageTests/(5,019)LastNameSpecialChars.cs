using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]

    public class LastNameSpecialChars_5_019_ : TestBase
    {
        [TestMethod]
        
        public void _5_019_LastNameSpecialChars()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();

            Pages.AgentProfilePage.enterLastName("1234567890!@#$%^&*()_+-=[]{}';:,./|<>`~üöäÄÜÖß");

            Pages.AgentProfilePage.saveChanges();

            UnderAppTests.Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[1]/div[2]/div[2]/input");

            string inputedText = Pages.AgentProfilePage.getLastNameFieldText();

            if (inputedText == "1234567890!@#$%^&*()_+-=[]{}';:,./|<>`~üöäÄÜÖß")
            {
                Assert.AreEqual("", "", "First name format valid, and saved!");
            }
            else
                Assert.Fail("Invalid name format, or name inputed hasn't been saved properly!");
        }
    }
}
