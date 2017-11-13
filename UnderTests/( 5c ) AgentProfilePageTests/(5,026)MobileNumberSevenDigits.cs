using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class MobileNumberSevenDigits_5_026_ : TestBase
    {
        [TestMethod]

        public void _5_026_MobileNumberSevenDigits()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();

            Pages.AgentProfilePage.enterMobileNumber("1234567");
            Pages.AgentProfilePage.saveChanges();

            string inputedNumber = Pages.AgentProfilePage.getMobileTextField();

            if (inputedNumber == "1234567")
            {
                Assert.AreEqual("", "", "Mobile number format valid, and saved!");
            }
            else
                Assert.Fail("Invalid number format, or number wasn't saved properly.");
        }
    }
}
