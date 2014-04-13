using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormsAuthJSONPDemo2;
using FormsAuthJSONPDemo2.Controllers;

namespace FormsAuthDemoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLoginPass()
        {
            AuthController ctrl = new AuthController();
            var results = ctrl.Login("Rich", "testpass");
            Assert.IsNotNull(results);
        }

        [TestMethod]
        public void TestLoginFail()
        {
            AuthController ctrl = new AuthController();
            var results = ctrl.Login("Rich", "testpassXX");
            Assert.IsNull(results);
        }

    }
}
