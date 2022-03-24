
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

        [TestMethod]

        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ProductId = 21;
            //invoke the method
            Found = AnStock.Find(ProductId);
            //test to see if the resuts is true
            Assert.IsTrue(Found);

        }

        [TestMethod]

        public void TestProductIdFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 21;
            //invoke the method
            Found = AnStock.Find(ProductId);
            //check the product id
            if (AnStock.ProductID != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]

        public void TestProductNameFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductName = 21;
            //invoke the method
            Found = AnStock.Find(ProductName);
            //check the product id
            if (AnStock.Product_Name != "Nike T - Shirt Size S")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]

        public void TestProductQuantityFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductQuantity = 21;
            //invoke the method
            Found = AnStock.Find(ProductQuantity);
            //check the product id
            if (AnStock.Product_Quantity != 40)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]

        public void TestProductPriceFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductPrice = 21;
            //invoke the method
            Found = AnStock.Find(ProductPrice);
            //check the product id
            if (AnStock.Product_Price != 24.99)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]

        public void TestProductShippedFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductShipped = 21;
            //invoke the method
            Found = AnStock.Find(ProductShipped);
            //check the product id
            if (AnStock.Product_Shipped != Convert.ToDateTime("12/01/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]

        public void TestProductAvailabilityFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductAvailability = 21;
            //invoke the method
            Found = AnStock.Find(ProductAvailability);
            //check the product id
            if (AnStock.Product_Availablilty != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
    }
}
