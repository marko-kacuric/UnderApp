using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]

    public class ChooseCountryOptionOne_5_023_ : TestBase
    {
        [TestMethod]

        public void _5_023_ChooseCountryOptionOne()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();
            Pages.AgentProfilePage.selectCountryGermany();
            Pages.AgentProfilePage.saveChanges();
        }
    }
}
