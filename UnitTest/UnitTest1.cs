using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace UnitTest
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        [DataRow("jlarreygue@sciodev.com", true)]
        [DataRow("jlarreygue@sciodev", true)]
        [DataRow("jlarreygue@s@ciodev.com", false)]
        [DataRow("@sciodev.com", false)]
        [DataRow("jlarreygue@sciodev.com.com", true)]
        [DataRow("jlarreyguesciodev.com", false)]
        [DataRow("jlarreygue@", false)]
        [DataRow("jlarrey_gue@sciodev.com", true)]
        [DataRow("jlarreygue@scio_dev.com", true)]

        public void testValidateEmail(String email, bool res)
        {

            var exp_reg = @"^[a-zA-Z0-9_\-\.]{2,}@[a-zA-Z0-9_\-\.]{2,}$";

            Regex regex = new Regex(exp_reg);

            Assert.AreEqual(regex.IsMatch(email), res);
        }
    }
}
