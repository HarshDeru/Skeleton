using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instnce of the class we want to create
            clsStock anStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(anStock);
        }
        [TestMethod]
        public void ActivePropertyOK()
        { 
            clsStock anStock = new clsStock();
            Boolean TestData = true;
            anStock.Active = TestData;
            Assert.AreEqual(anStock.Active, TestData);
                }

        [TestMethod]
        public void ProductIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            int TestData = 0;
            //assign the data to the property
            AnStock.ProductID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ProductID, TestData);
        }
        [TestMethod]
        public void Product_NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AnStock.Product_Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.Product_Name, TestData);
        }
        [TestMethod]
        public void ProductQuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            int TestData = 0;
            //assign the data to the property
            AnStock.Product_Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.Product_Quantity, TestData);
        }
        [TestMethod]
        public void ProductShippedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStock.Product_Shipped = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.Product_Shipped, TestData);
        }

        [TestMethod]
        public void Product_PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            double TestData = 0.00;
            //assign the data to the property
            AnStock.Product_Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.Product_Price, TestData);
        }
        [TestMethod]
        public void Product_AvailabliltyPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStock.Product_Availablilty = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.Product_Availablilty, TestData);
        }
    }
}
