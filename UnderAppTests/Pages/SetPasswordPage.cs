using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnderAppTests.Pages
{
    

    public class SetPasswordPage
    {
        private int pageLoadTimeout = 10;

        public void GoTo()
        {
            Browser.GoTo("/#/validate-email/taxi_agent/267/2wzjakuii5h8o3otttks94nzupnjry36tn81gds5p2pqei62nj?continue=true");
        }

        public bool isAtAppropriatePage()
        {           
            By element = By.ClassName("row.under-reset-password-password-title");
            return Browser.WaitUntilElementIsDisplayed(element, pageLoadTimeout);
        }
        
        public void setPasswordFields(string password, string confirmPassword)
        {

            var passwordField = Browser.Driver.FindElement(By.XPath("/html/body/under/ng-component/div/div/div[2]/div/div[2]/div[4]/input"));
            passwordField.SendKeys(password);

            var confirmPasswordField = Browser.Driver.FindElement(By.XPath("/html/body/under/ng-component/div/div/div[2]/div/div[2]/div[5]/input"));
            confirmPasswordField.SendKeys(confirmPassword);
            
        }

        public void submitButton()
        {
            Browser.Driver.FindElement(By.XPath("/html/body/under/ng-component/div/div/div[2]/div/div[2]/div[7]/div[2]/button")).Click();
        }

    }
}
