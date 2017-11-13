using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]
    public class MobileNumberSixteenDigits_5_030_ : TestBase
    {
        [TestMethod]
        public void _5_030_MobileNumberSixteenDigits()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();

            Pages.AgentProfilePage.enterMobileNumber("123456789012345888888");
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
