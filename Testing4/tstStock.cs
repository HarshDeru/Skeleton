
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
            clsStock AnStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AnStock);
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
            AnStock.ProductName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ProductName, TestData);
        }
        [TestMethod]
        public void ProductQuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            int TestData = 0;
            //assign the data to the property
            AnStock.ProductQuantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ProductQuantity, TestData);
        }
        [TestMethod]
        public void ProductShippedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStock.ProductShipped = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ProductShipped, TestData);
        }

        [TestMethod]
        public void Product_PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            double TestData = 0.00;
            //assign the data to the property
            AnStock.ProductPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ProductPrice, TestData);
        }
        [TestMethod]
        public void Product_AvailabliltyPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStock.ProductAvailablilty = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ProductAvailablilty, TestData);
        }

        [TestMethod]

        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ProductId = 5;
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
            Int32 ProductId = 5;
            //invoke the method
            Found = AnStock.Find(ProductId);
            //check the product id
            if (AnStock.ProductID != 5)
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
            Int32 ProductId = 5;
            //invoke the method
            Found = AnStock.Find(ProductId);
            //check the product id
            if (AnStock.ProductName != "The North Face Size L")
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
            Int32 ProductId = 5;
            //invoke the method
            Found = AnStock.Find(ProductId);
            //check the product id
            if (AnStock.ProductQuantity != 30)
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
            Int32 ProductId = 5;
            //invoke the method
            Found = AnStock.Find(ProductId);
            //check the product id
            if (AnStock.ProductPrice != 45.9900)
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
            Int32 ProductId = 5;
            //invoke the method
            Found = AnStock.Find(ProductId);
            //check the product id
            if (AnStock.ProductShipped != Convert.ToDateTime("15/02/2022 00:00:00"))
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
            Int32 ProductId = 5;
            //invoke the method
            Found = AnStock.Find(ProductId);
            //check the product id
            if (AnStock.ProductAvailablilty != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
    }
}
