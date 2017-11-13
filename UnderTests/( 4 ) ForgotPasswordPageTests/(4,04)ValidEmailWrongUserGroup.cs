using UnderAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnderTests.ForgotPasswordPageTests
{
    [TestClass]
    public class ValidEmailWrongUserGroup_4_04_ : TestBase
    {
        [TestMethod]
        public void _4_04_ValidEmailWrongUserGroup()
        {
            Pages.ForgotPassword.GoTo();
            Pages.ForgotPassword.isAtAppropriatePage();
            Pages.ForgotPassword.forgotPassword("marko.kacuric@gmail.com");
            Pages.ForgotPassword.resetPasswordButton();
            Pages.ForgotPassword.isUserRedirectedToLogin();
        }
    }
}
