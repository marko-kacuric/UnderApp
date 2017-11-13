using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class MobileNumberFifteenDigits_5_027_ : TestBase
    {
        [TestMethod]

        public void _5_027_MobileNumberFifteenDigits()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();

            Pages.AgentProfilePage.enterMobileNumber("123456789012345");
            Pages.AgentProfilePage.saveChanges();

            string inputedNumber = Pages.AgentProfilePage.getMobileTextField();

            if (inputedNumber == "123456789012345")
            {
                Assert.AreEqual("", "", "Mobile number format valid, and saved!");
            }
            else
                Assert.Fail("Invalid number format, or number wasn't saved properly.");
        }
    }
}
