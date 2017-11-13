using UnderAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using NUnit.Framework;

namespace UnderTests.SetPasswordPageTests
{

    [TestClass]
    [TestCategory("login")]
    public class SpecialCharsPassword_1_04_ : TestBase
    {
        [TestMethod]
        public void _1_04_SpecialCharsPassword()
        {

            Pages.SetPassword.GoTo();
            // Pages.SetPassword.setPasswordFields("test1" + "!@#$%^&*()_+-=[]{]" + "';:,./|<>`~" + "üöä\\ÄÜÖß", "");
            Pages.SetPassword.setPasswordFields("test1" + "!@#$%^&*()_+-=[]{]" + "';:,./|<>`~" + "üöä\\ÄÜÖß", "tetetet1234");
            string passwordAlert = "";
            string alert = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/ng-component/div/div/div[2]/div/div[2]/div[4]/label")).Text;
            NUnit.Framework.Assert.AreEqual(passwordAlert, alert, "Invalid password label not visible when it should be visible.");
        }
    }
}
