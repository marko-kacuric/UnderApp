using UnderAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnderTests.ForgotPasswordPageTests
{
    [TestClass]
    public class ValidEmailReset_4_05_ : TestBase
    {
        [TestMethod]
        public void _4_05_ValidEmailReset()
        {
            Pages.ForgotPassword.GoTo();
            Pages.ForgotPassword.isAtAppropriatePage();
            Pages.ForgotPassword.forgotPassword("marko.kacuric@p3-group.com");
            Pages.ForgotPassword.resetPasswordButton();
            Pages.ForgotPassword.isUserRedirectedToLogin();

        }
    }
}
