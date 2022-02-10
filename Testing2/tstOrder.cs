using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOk()
        {

            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }
    }
}
