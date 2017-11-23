using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderAppTests.Pages;

namespace UnderTests.__5f___AdministrationPageTests
{
    [TestClass]

    public class EditAgentCanceled_5_092_ : TestBase
    {
        [TestMethod]
        public void _5_092_EditAgentCanceled()
        {
            Pages.AdministrationPage.GoTo();
            Pages.AdministrationPage.logInAndNavigateToAdministrationPageAgents();
            Pages.AdministrationPage.openEditAgentModal();
            Pages.AdministrationPage.editAgentCanceled();
        }
    }
}
