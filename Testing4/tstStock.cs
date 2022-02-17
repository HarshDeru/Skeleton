using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock anStock = new clsStock();
            Assert.IsNotNull(anStock);
        }

        [TestMethod]
        public void ProductIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create some test data to assign to the property
            int TestData = 0;
            //assign the data to the property
            anStock.ProductId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anStock.ProductId, TestData);
        }

        [TestMethod]
        public void ProductNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            anStock.ProductName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anStock.ProductName, TestData);
        }

        [TestMethod]
        public void ProductPricePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create some test data to assign to the property
            Double TestData = 0.00;
            //assign the data to the property
            anStock.ProductPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anStock.ProductPrice, TestData);
        }

        [TestMethod]
        public void ProductQuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create some test data to assign to the property
            int TestData = 0;
            //assign the data to the property
            anStock.ProductQuantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anStock.ProductQuantity, TestData);
        }

        [TestMethod]
        public void ProductShippedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            anStock.ProductShipped = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anStock.ProductShipped, TestData);
        }

        [TestMethod]
        public void ProductAvailabilityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            anStock.ProductAvailability = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anStock.ProductAvailability, TestData);
        }
    }
}
