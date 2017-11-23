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
    public class EditAgentSuccessful_5_091_ : TestBase
    {
        [TestMethod]
        public void _5_091_EditAgentSuccessful()
        {
            Pages.AdministrationPage.GoTo();
            Pages.AdministrationPage.logInAndNavigateToAdministrationPageAgents();
            Pages.AdministrationPage.openEditAgentModal();
            Pages.AdministrationPage.editAgentSuccessful();
        }

    }
}
