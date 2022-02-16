using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void TestMethod1()
        { 
                clsCustomer ACustomer = new clsCustomer();
                Assert.IsNotNull(ACustomer);
            }
        }
    }

