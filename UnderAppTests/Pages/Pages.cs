using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;

namespace UnderAppTests.Pages
{
    
    public static class Pages
    {
        private static PagesList GetPage<PagesList>() where PagesList : new()
        {
            var page = new PagesList();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }

        public static LoginPage Login
        {

            get { return GetPage<LoginPage>(); }
        }

        public static SetPasswordPage SetPassword
        {
            get { return GetPage<SetPasswordPage>(); }
        }

        public static ResetPasswordPage ResetPassword
        {
            get { return GetPage<ResetPasswordPage>(); }
        }

        public static ForgotPasswordPage ForgotPassword
        {
            get { return GetPage<ForgotPasswordPage>(); }
        }

        public static SuccessfulPasswordChangePage SuccessChange
        {
            get { return GetPage<SuccessfulPasswordChangePage>(); }
        }

        public static DashboardPage DashboardPage
        {
            get { return GetPage<DashboardPage>(); }
        }

        public static AgentProfilePage AgentProfilePage
        {
            get { return GetPage<AgentProfilePage>(); }
        }

        public static HistoryPage HistoryPage
        {
            get { return GetPage<HistoryPage>(); }
        }

        public static ReportsPage ReportsPage
        {
            get { return GetPage<ReportsPage>(); }
        }

        public static AdministrationPage AdministrationPage
        {
            get { return GetPage<AdministrationPage>(); }
        }
    }
}
