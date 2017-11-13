using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnderAppTests.Pages
{
    public class SuccessfulPasswordChangePage
    {
        public void GoTo()
        {
            Browser.GoTo("/#/success/reset-password/taxi_agent");
        }

        public void isAtAppropriatePage()
        {
            Browser.WaitForElement("/html/body/under/ng-component/div/div/div");
            IWebElement successfulChangePageText = Browser.Driver.FindElement(By.CssSelector(".success-title"));            
            string expectedPageHeader = "You have successfully changed you password.";
            Assert.IsTrue(successfulChangePageText.Text.Contains(expectedPageHeader));

        }

        public void loginPageButton()
        {
            Browser.Driver.FindElement(By.CssSelector(".btn")).Click();
        }

    }
}
