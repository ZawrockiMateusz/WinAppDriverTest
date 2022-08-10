using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace WinAppDriverTest
{
    [TestClass]
    public class UnitTest1 : MozartSession
    {
		[TestMethod]
		public void ChooseDatabase()
		{
            Thread.Sleep(TimeSpan.FromSeconds(3));
            // Choose DataBase
            session.FindElementByName("MozartWinAppDriver").Click();
            session.FindElementByName("Ok").Click();
            Thread.Sleep(2000);

            session.SwitchTo().Window(session.WindowHandles.Last());
            session.FindElementByName("Operator :").SendKeys(Keys.ArrowDown);
            session.FindElementByName("PasswordTextEdit").Click();
            session.FindElementByName("PasswordTextEdit").SendKeys("");
            session.FindElementByName("Zaloguj").Click();
            Thread.Sleep(2000);

            session.SwitchTo().Window(session.WindowHandles.Last());
            session.FindElementByAccessibilityId("cmdOk").Click();
            Thread.Sleep(1000);

            session.SwitchTo().Window(session.WindowHandles.Last());
            session.FindElementByName("Zlecenia").Click();
            Thread.Sleep(2000);
            Assert.IsNotNull(session.FindElementByAccessibilityId("Zlecenia"));
            Thread.Sleep(2000);
        }
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Setup(context);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            TearDown();
        }
    }
}
