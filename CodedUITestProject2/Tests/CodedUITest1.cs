using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;

using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;

using Ranorex;

using Example1.Helpers.Loader;


namespace Example1.Tests
{
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
            
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            MapLoader.Calculator.MainForm.Calculator.N1Button.Click();
            MapLoader.Calculator.MainForm.Calculator.AdditionButton.Click();
            MapLoader.Calculator.MainForm.Calculator.N2Button.Click();
            MapLoader.Calculator.MainForm.Calculator.EquallyButton.Click();
            Assert.AreEqual("3", MapLoader.Calculator.MainForm.Calculator.ResultInput.TextValue);
        }

        [TestInitialize()]
        public void MyTestInitialize()
        {
            Process.Start("calc.exe");
        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            Host.Local.KillApplications("calc.exe");
        }

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }
}
