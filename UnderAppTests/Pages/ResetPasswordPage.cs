using OpenQA.Selenium;

namespace UnderAppTests.Pages
{
    public class ResetPasswordPage
    {
        private int pageLoadTimeout = 10;

        public void GoTo()
        {
            Browser.GoTo("/#/reset-password/taxi_agent/267/6lrq5rrrcer7ycs9b872su3e2u7vb6unebraqiq1z3gvql22cg");
        }

        public bool isAtAppropriatePage()
        {
            By element = By.XPath("//title[contains(text(),'Reset password')]");
            return Browser.WaitUntilElementIsDisplayed(element, pageLoadTimeout);
        }

        public void resetPasswordFields(string password, string confirmPassword)
        {
            var passwordField = Browser.Driver.FindElement(By.XPath("/html/body/under/under-reset-password/div/div[2]/div/div[2]/div[4]/input"));
            passwordField.SendKeys(password);

            var confirmPasswordField = Browser.Driver.FindElement(By.XPath("/html/body/under/under-reset-password/div/div[2]/div/div[2]/div[5]/input"));
            confirmPasswordField.SendKeys(confirmPassword);
        }
        public void submitButton()
        {
            Browser.Driver.FindElement(By.XPath("/html/body/under/under-reset-password/div/div[2]/div/div[2]/div[7]/div[2]/button")).Click();

        }
    }
}
