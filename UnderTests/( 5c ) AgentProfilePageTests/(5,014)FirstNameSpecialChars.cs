using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnderAppTests.Pages;


namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class FirstNameSpecialChars_5_014_ : TestBase
    {
        [TestMethod]

        public void _5_014_FirstNameSpecialChars() 
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();

            Pages.AgentProfilePage.enterFirstName("1234567890!@#$%^&*()_+-=[]{}';:,./|<>`~üöäÄÜÖß");

            Pages.AgentProfilePage.saveChanges();

            UnderAppTests.Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[1]/div[2]/div[1]/input");

            string inputedText = Pages.AgentProfilePage.getFirstNameFieldText();

            if (inputedText == "1234567890!@#$%^&*()_+-=[]{}';:,./|<>`~üöäÄÜÖß")
            {
                Assert.AreEqual("", "", "First name format valid, and saved!");
            }
            else
                Assert.Fail("Invalid name format, or name inputed hasn't been saved properly!");
        }
    }
}