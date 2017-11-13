using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnderAppTests.Pages
{
    public class ForgotPasswordPage
    {
        public void GoTo()
        {
            Browser.GoTo("https://agent.under.taxi/#/login", false);

            Browser.WaitForElement("/html/body/under-agent/under-login/div/div[2]/div/div[2]/div[5]/a");
            Browser.Driver.FindElement(By.LinkText("Forgot password?")).Click();
        }

        public void isAtAppropriatePage()
        {
            Browser.WaitForElement("/html/body/under-agent/under-forgot-password/div/div[2]/div/div[2]/div[1]");
            IWebElement forgotPasswordHeader = Browser.Driver.FindElement(By.CssSelector(".under-forgot-password-title"));
            string expectedHeaderTitle = "Forgot password";
            Assert.IsTrue(forgotPasswordHeader.Text.Contains(expectedHeaderTitle));
            IWebElement textUnderTitle = Browser.Driver.FindElement(By.CssSelector(".under-forgot-password-sub-title"));
            string expectedTextUnderTitle = "In form below enter your account email and press reset.";
            Assert.IsTrue(textUnderTitle.Text.Contains(expectedTextUnderTitle));
        }

        public void forgotPassword(string email)
        {
            
            Browser.WaitForElement("/html/body/under-agent/under-forgot-password/div/div[2]/div/div[2]/div[3]/input");
            var emailField = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-forgot-password/div/div[2]/div/div[2]/div[3]/input"));
            emailField.SendKeys(email);
        }

        public void resetPasswordButton()
        {
            Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-forgot-password/div/div[2]/div/div[2]/div[4]/div[2]/button")).Click();
        }

        public void isUserRedirectedToLogin()
        {
            Browser.WaitForElement("/html/body/under-agent/under-login/div/div[2]/div/div[2]/div[1]");
            string header = "Taxi agent login";
            string pageHeaderLogin = Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-login/div/div[2]/div/div[2]/div[1]")).Text;
            Assert.AreEqual(header, pageHeaderLogin, "Redirected to wrong page, something went wrong!");
        }

    }
}
