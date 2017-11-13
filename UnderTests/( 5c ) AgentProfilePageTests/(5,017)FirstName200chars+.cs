using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class FirstName200chars__5_017_ : TestBase
    {
        [TestMethod]

        public void _5_017_FirstName200chars()
        {

            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();

            Pages.AgentProfilePage.enterFirstName("TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123");

            Pages.AgentProfilePage.saveChanges();

            string expectedErrorMessage = "First name in bad format or does not exist";
            By incompleteDataModal = By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-error-modal/under-modal-dialog/div/div/div/div/div[2]/div");
            Browser.WaitUntilElementIsDisplayed(incompleteDataModal, 3);

            string displayedErrorMessage = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-error-modal/under-modal-dialog/div/div/div/div/div[2]/div")).Text;
            
            Assert.AreEqual(expectedErrorMessage, displayedErrorMessage, "No error message shown, or invalid error message shown.");
        }
    }
}
