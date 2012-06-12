using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace TestProjectPotz
{
    [TestClass()]
    public class MetodosTest
    {
        private TestContext testContextInstance;
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

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("%PathToWebRoot%\\Potz", "/Potz")]
        [UrlToTest("http://localhost/Potz")]
        public void quantidadePontosTest()
        {
            Metodos_Accessor target = new Metodos_Accessor(); // TODO: Initialize to an appropriate value
            string numeroCupom = "5001234560"; // TODO: Initialize to an appropriate value
            int expected = 500; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.quantidadePontos(numeroCupom);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("%PathToWebRoot%\\Potz", "/Potz")]
        [UrlToTest("http://localhost/Potz")]
        public void quantidadePontosTest2()
        {
            Metodos_Accessor target = new Metodos_Accessor(); // TODO: Initialize to an appropriate value
            string numeroCupom = "5001234560"; // TODO: Initialize to an appropriate value
            int expected = 50; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.quantidadePontos(numeroCupom);
            Assert.AreNotSame(expected, actual);
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("%PathToWebRoot%\\Potz", "/Potz")]
        [UrlToTest("http://localhost/Potz")]
        public void validaDigitoVerificadorTest()
        {
            Metodos_Accessor target = new Metodos_Accessor(); // TODO: Initialize to an appropriate value
            string numeroCupom = "5001234560"; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.validaDigitoVerificador(numeroCupom);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("%PathToWebRoot%\\Potz", "/Potz")]
        [UrlToTest("http://localhost/Potz")]
        public void validaDigitoVerificadorTest2()
        {
            Metodos_Accessor target = new Metodos_Accessor(); // TODO: Initialize to an appropriate value
            string numeroCupom = "5001234567"; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.validaDigitoVerificador(numeroCupom);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("%PathToWebRoot%\\Potz", "/Potz")]
        [UrlToTest("http://localhost/Potz")]
        public void validaQtdeCaracterCupomTest()
        {
            Metodos_Accessor target = new Metodos_Accessor(); // TODO: Initialize to an appropriate value
            string numeroCupom = "500123456-0"; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.validaQtdeCaracterCupom(numeroCupom);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("%PathToWebRoot%\\Potz", "/Potz")]
        [UrlToTest("http://localhost/Potz")]
        public void validaQtdeCaracterCupomTest2()
        {
            Metodos_Accessor target = new Metodos_Accessor(); // TODO: Initialize to an appropriate value
            string numeroCupom = "5001234560"; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.validaQtdeCaracterCupom(numeroCupom);
            Assert.AreNotSame(expected, actual);
        }

        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("%PathToWebRoot%\\Potz", "/Potz")]
        [UrlToTest("http://localhost/Potz")]
        public void validaQuantidadePontosTest()
        {
            Metodos_Accessor target = new Metodos_Accessor(); // TODO: Initialize to an appropriate value
            string numeroCupom = "5001234560"; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.validaQuantidadePontos(numeroCupom);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("%PathToWebRoot%\\Potz", "/Potz")]
        [UrlToTest("http://localhost/Potz")]
        public void validaQuantidadePontosTest2()
        {
            Metodos_Accessor target = new Metodos_Accessor(); // TODO: Initialize to an appropriate value
            string numeroCupom = "0001234560"; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.validaQuantidadePontos(numeroCupom);
            Assert.IsTrue(expected == actual);
        }


        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("%PathToWebRoot%\\Potz", "/Potz")]
        [UrlToTest("http://localhost/Potz")]
        public void DigitoModulo11Test()
        {
            Metodos_Accessor target = new Metodos_Accessor(); // TODO: Initialize to an appropriate value
            string strCupom = "123456"; // TODO: Initialize to an appropriate value
            string expected = "0"; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.DigitoModulo11(strCupom);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("%PathToWebRoot%\\Potz", "/Potz")]
        [UrlToTest("http://localhost/Potz")]
        public void DigitoModulo11Test2()
        {
            Metodos_Accessor target = new Metodos_Accessor(); // TODO: Initialize to an appropriate value
            string strCupom = "123456"; // TODO: Initialize to an appropriate value
            string expected = "1"; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.DigitoModulo11(strCupom);
            Assert.AreNotEqual(expected, actual);
        }
    }
}
