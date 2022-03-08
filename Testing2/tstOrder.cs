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
            //create an instnce of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            int TestData = 0;
            //assign the data to the property
            AnOrder.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }
        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            int TestData = 0;
            //assign the data to the property
            AnOrder.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerId, TestData);
        }
        [TestMethod]
        public void Order_DateTimePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.Order_DateTime = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Order_DateTime, TestData);
        }
        [TestMethod]
        public void Order_DescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AnOrder.Order_Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Order_Description, TestData);
        }
        [TestMethod]
        public void Order_TotalAmountPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            double TestData = 0.00;
            //assign the data to the property
            AnOrder.Order_TotalAmount = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Order_TotalAmount, TestData);
        }
        [TestMethod]
        public void Order_DispatchedPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Order_Dispatched = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Order_Dispatched, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Bollean variale to store the results of the validation 
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //test to see if the result is tru
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Bollean variale to store the results of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the OrderID
            if (AnOrder.OrderId != 21)
            {
                OK = false;
            }
            //test to see if the result is tru
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIdNoFound()
        {
            //create an istance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnOrder.Find(CustomerId);
            //check the CustomerId
            if (AnOrder.CustomerId != 1)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateTimeFound()
        {
            //create an istance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderDateTime = 1;
            //invoke the method
            Found = AnOrder.Find(OrderDateTime);
            //check if the CustomerId
            if (AnOrder.Order_DateTime != Convert.ToDateTime("10/10/2010"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FindOrderDescriptionFound()
        {
            //create an instance of staff class
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //bolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int OrderDescription = 1;
            //invoke the methods
            Found = AnOrder.Find(OrderDescription);
            //check the staff fullname
            if (AnOrder.Order_Description != "Nike t-shirt, Size S")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDispatchedFound()
        {
            //create an istance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderDispatched = 1;
            //invoke the method
            Found = AnOrder.Find(OrderDispatched);
            //check if the CustomerId
            if (AnOrder.Order_Dispatched != true)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderTotalAmountFound()
        {
            //create an istance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderTotalAmount = 1;
            //invoke the method
            Found = AnOrder.Find(OrderTotalAmount);
            //check if the CustomerId
            if (AnOrder.Order_TotalAmount != 0000000000)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

    }
}
