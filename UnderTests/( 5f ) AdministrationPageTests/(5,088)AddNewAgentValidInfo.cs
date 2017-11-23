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

    public class AddNewAgentValidInfo_5_088_ : TestBase
    {
        [TestMethod]
        public void _5_088_AddNewAgentValidInfo()
        {
            Pages.AdministrationPage.GoTo();
            Pages.AdministrationPage.logInAndNavigateToAdministrationPageAgents();
            Pages.AdministrationPage.openAddAgentModal();
            Pages.AdministrationPage.addAgentSuccessful();

            
        }
    }
}
