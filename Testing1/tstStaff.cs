using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void tstInstanceOK()
        {
            clsStaff Staff = new clsStaff();
            Assert.IsNotNull(Staff);
        }
    }
}
