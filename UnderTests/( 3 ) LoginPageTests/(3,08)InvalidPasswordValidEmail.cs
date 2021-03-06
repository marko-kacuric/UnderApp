﻿using UnderAppTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Text.RegularExpressions;
using System.Linq;
using System.Threading;

namespace UnderTests.LoginPageTests
{
    [TestClass]
    public class InvalidPasswordValidEmail_3_08_ : TestBase
    {
        [TestMethod]
        // Password less than 8 characters
        public void _3_08a_InvalidPasswordValidEmail()
        {
            Pages.Login.GoTo();
            Pages.Login.LogIn("marko.kacuric@p3-group.com", "qweeq");

            UnderAppTests.Browser.WaitForElement("/html/body/under-agent/under-login/div/under-modal-dialog[2]/div/div/div/div");
            string alertTitlePassword = "Please enter valid password.";
            string alertMsgPassword = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-login/div/under-modal-dialog[2]/div/div/div/div/div[2]/div")).Text;
            Assert.AreEqual(alertTitlePassword, alertMsgPassword, "Wrong error message is presented.");
        }

        [TestMethod]
        // Password more than 8 characters but only letters
        public void _3_08b_InvalidPasswordValidEmail()
        {
            Pages.Login.GoTo();
            Pages.Login.LogIn("marko.kacuric@p3-group.com", "testTesttestTest");

            UnderAppTests.Browser.WaitForElement("/html/body/under-agent/under-login/div/under-modal-dialog[2]/div/div/div/div");
            string alertTitlePassword = "Please enter valid password.";
            string alertMsgPassword = UnderAppTests.Browser.Driver.FindElement(By.XPath("/html/body/under-agent/under-login/div/under-modal-dialog[2]/div/div/div/div/div[2]/div")).Text;
            Assert.AreEqual(alertTitlePassword, alertMsgPassword, "Wrong error message is presented.");
        }

        [TestMethod]
        //Characters, number and special characters inputed, but invalid password
        public void _3_08c_InvalidPasswordValidEmail()
        {
            Pages.Login.GoTo();
            Pages.Login.LogIn("marko.kacuric@p3-group.com", "testTest1234!@#$");

            UnderAppTests.Browser.WaitForElement("/html/body/under-agent/under-login/div/under-modal-dialog[3]/div/div/div/div");
            string alertTitlePassword = "Wrong email or password is sent.";
            Thread.Sleep(300);
            string alertMsgPassword = UnderAppTests.Browser.Driver.FindElement(By.CssSelector(".under-login > under-modal-dialog:nth-child(8) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1)")).Text;
            Assert.AreEqual(alertTitlePassword, alertMsgPassword, "Wrong error message is presented.");
        }


    }
}
