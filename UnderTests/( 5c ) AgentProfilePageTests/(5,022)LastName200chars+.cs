using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class LastName200chars__5_022_ : TestBase
    {
        [TestMethod]

        public void _5_022_LastName200chars()
        {

            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();

            Pages.AgentProfilePage.enterLastName("TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123TestTest123");

            Pages.AgentProfilePage.saveChanges();

            string expectedErrorMessage = "Last name in bad format or does not exist";
            By incompleteDataModal = By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-error-modal/under-modal-dialog/div/div/div/div/div[2]");
            Browser.WaitUntilElementIsDisplayed(incompleteDataModal, 3);

            string displayedErrorMessage = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-agent-dashboard/div/div[2]/div/div/div/under-profile/under-error-modal/under-modal-dialog/div/div/div/div/div[2]")).Text;

            Assert.AreEqual(expectedErrorMessage, displayedErrorMessage, "No error message shown, or invalid error message shown.");
        }

    }
}
