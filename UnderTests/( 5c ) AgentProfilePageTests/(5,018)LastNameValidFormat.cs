using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class LastNameValidFormat_5_018_ : TestBase
    {
        [TestMethod]
        public void _5_013_FirstNameValidFormat()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();

            Pages.AgentProfilePage.enterLastName("LastNameValidFormat");

            Pages.AgentProfilePage.saveChanges();

            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[1]/div[2]/div[2]/input");

            string inputedText = Pages.AgentProfilePage.getLastNameFieldText();

            if (inputedText == "LastNameValidFormat")
            {
                Assert.AreEqual("", "", "First name format valid, and saved!");
            }
            else
                Assert.Fail("Invalid name format, or name inputed hasn't been saved");
        }

    }
}
