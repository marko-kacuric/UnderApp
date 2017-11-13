using UnderAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnderTests.ForgotPasswordPageTests
{
    [TestClass]
    public class UnexistingEmailReset_4_02_ : TestBase
    {
        [TestMethod]

        public void _4_02_UnexistingEmailReset()
        {
            Pages.ForgotPassword.GoTo();
            Pages.ForgotPassword.isAtAppropriatePage();
            Pages.ForgotPassword.forgotPassword("qweqweq@qweqew.com");
            Pages.ForgotPassword.resetPasswordButton();
            Pages.ForgotPassword.isUserRedirectedToLogin();
            
        }
    }
}
