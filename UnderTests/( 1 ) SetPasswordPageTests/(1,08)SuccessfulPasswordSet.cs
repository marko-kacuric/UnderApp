using UnderAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnderTests.SetPasswordPageTests
{
    [TestClass]
    public class SuccessfulPasswordSet_1_08_ : TestBase
    {
        [TestMethod]
        public void _1_08_SuccessfulPasswordSet()
        {
            Pages.SetPassword.GoTo();
            Pages.SetPassword.setPasswordFields("Test1234!", "Test1234!");
            string passwordAlert = "";
            string confirmPasswordAlert = "";
            string alert1 = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/ng-component/div/div/div[2]/div/div[2]/div[4]/label")).Text;
            Assert.AreEqual(passwordAlert, alert1, "Invalid password label visible, when it should NOT be visible.");
            string alert2 = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/ng-component/div/div/div[2]/div/div[2]/div[5]/label")).Text;
            Assert.AreEqual(confirmPasswordAlert, alert2, "Invalid password label visible, when it should NOT be visible.");

            bool sendButtonStatus = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/ng-component/div/div/div[2]/div/div[2]/div[7]/div[2]/button")).Enabled;
            Assert.IsTrue(sendButtonStatus, "Send button is disabled, it should be enabled.");

            UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under/ng-component/div/div/div[2]/div/div[2]/div[7]/div[2]/button")).Click();


        }
    }
}
