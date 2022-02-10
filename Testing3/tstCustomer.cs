using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void tstInstanceOK()
        {
            clsCustomer customer = new clsCustomer();
            Assert.IsNotNull(customer);
        }
    }
}
