using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class FirstNameBlankSpace_5_016_ : TestBase
    {
        [TestMethod]

        public void _5_016_FirstNameBlankSpace()
        {

            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();

            Pages.AgentProfilePage.enterFirstName(" ");

            Pages.AgentProfilePage.saveChanges();

            Browser.WaitForElement("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/div/div/div[3]/div[1]/div[1]/div[1]/div[2]/div[1]/input");

            string inputedText = Pages.AgentProfilePage.getFirstNameFieldText();

            if (inputedText == " ")
            {
                Assert.AreEqual("", "", "First name format valid, and saved!");
            }
            else
                Assert.Fail("Invalid name format, or name inputed hasn't been saved properly!");
        }
    }
}
