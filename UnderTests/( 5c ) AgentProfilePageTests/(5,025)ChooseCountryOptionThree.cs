using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnderAppTests;
using UnderAppTests.Pages;

namespace UnderTests.AgentProfilePage
{
    [TestClass]

    public class ChooseCountryOptionThree_5_025_ : TestBase
    {
        [TestMethod]

        public void _5_025_ChooseCountryOptionThree()
        {
            Pages.AgentProfilePage.GoTo();
            Pages.AgentProfilePage.LogInAndNavigateToProfilepage();
            Pages.AgentProfilePage.selectCountrySpain();
            Pages.AgentProfilePage.saveChanges();
        }
    }
}
