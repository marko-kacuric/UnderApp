using UnderAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnderTests.SetPasswordPageTests
{
    [TestClass]
    [TestCategory ("login")]
    public class ValidatePageContent_1_01_ : TestBase
    {
        [TestMethod]
        public void _1_01_ValidatePageContent()
        {
            Pages.SetPassword.GoTo();
            string header = "Set password";
            string pageHeader = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/ng-component/div/div/div[2]/div/div[2]/div[1]")).Text;
            Assert.AreEqual(header, pageHeader, "Redirected to wrong page, something went wrong!");

        }
    }
}
