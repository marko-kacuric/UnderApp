using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderAppTests.Pages;

namespace UnderTests.__5f___AdministrationPageTests
{
    [TestClass]
    public class AddNewAgentCanceled_5_089_ : TestBase
    { 
        [TestMethod]
        public void _5_089_AddNewAgentCanceled()
        {
            Pages.AdministrationPage.GoTo();
            Pages.AdministrationPage.logInAndNavigateToAdministrationPageAgents();
            Pages.AdministrationPage.openAddAgentModal();
            Pages.AdministrationPage.addAgentCanceled();
        }

    }
}
