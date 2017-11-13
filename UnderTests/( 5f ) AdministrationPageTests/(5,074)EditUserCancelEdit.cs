using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderAppTests.Pages;
using OpenQA.Selenium;

namespace UnderTests.AdministrationPage
{
    [TestClass]
    public class EditUserCancelEdit_5_074_
    {
        [TestMethod]

        public void _5_074_EditUserCancelEdit()
        {
            Pages.AdministrationPage.GoTo();
            Pages.AdministrationPage.logInAndNavigateToAdministrationPage();
            Pages.AdministrationPage.openEditDriverModal();
            Pages.AdministrationPage.editDriverCancelEdit("editedName", "editedLastName");
        }
    }
}
