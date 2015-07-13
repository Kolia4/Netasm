using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Netasm;
using Tests.Applications;

namespace Tests
{
    [TestClass]
    public class Netasm_Debug
    {
        [TestMethod]
        public void Debug()
        {
            var compiler = new Compiler(new Program());
        }
    }
}
