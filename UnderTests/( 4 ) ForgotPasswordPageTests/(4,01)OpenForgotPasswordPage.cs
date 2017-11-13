using UnderAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnderTests.ForgotPasswordPageTests
{
    [TestClass]
    public class OpenForgotPasswordPage_4_01_ : TestBase
    {
        [TestMethod]

        public void _4_01_OpenForgotPasswordPage()
        {
            Pages.ForgotPassword.GoTo();
            Pages.ForgotPassword.isAtAppropriatePage();
            Pages.ForgotPassword.forgotPassword("");
         
        }
    }
}
