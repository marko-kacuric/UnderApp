using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]

    public class ChooseCountryOptionTwo_5_024_ : TestBase
    {
        [TestMethod]

        public void _5_024_ChooseCountryOptionTwo()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();
            Pages.AgentProfilePage.selectCountrySerbia();
            Pages.AgentProfilePage.saveChanges();
        }
    }
}
