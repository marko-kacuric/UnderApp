using UnderAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnderTests.SetPasswordPageTests
{
    [TestClass]
    public class SpecialCharsConfirmPassword_1_05_ : TestBase
    {
        [TestMethod]
        [TestCategory("login")]
        public void _1_05_SpecialCharsConfirmPassword()
        {
            Pages.SetPassword.GoTo();
            Pages.SetPassword.setPasswordFields("", "test1" + "!@#$%^&*()_+-=[]{]" + "';:,./|<>`~" + "üöä\\ÄÜÖß");
            string passwordAlert = "";
            string alert = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/ng-component/div/div/div[2]/div/div[2]/div[5]/label")).Text;
            Assert.AreEqual(passwordAlert, alert, "Invalid password label visible, when it should NOT be visible.");
        }
    }
}

