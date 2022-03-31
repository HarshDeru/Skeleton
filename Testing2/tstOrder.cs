using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {

        //good test data
        //create some test data to pass to the method
        string OrderDescription = "Nike";
        string OrderDateTime = DateTime.Now.Date.ToString();

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
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the OrderID
            if (AnOrder.OrderId != 1)
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
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the CustomerId
            if (AnOrder.CustomerId != 4)
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
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check if the CustomerId
            if (AnOrder.Order_DateTime != Convert.ToDateTime("02/09/2021 12:03:29"))
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
            Int32 OrderId = 1;
            //invoke the methods
            Found = AnOrder.Find(OrderId);
            //check the staff fullname
            if (AnOrder.Order_Description != "Nike t-shirt, Size M")
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
            Int32 OrderId = 4;
            //invoke the method
            Found = AnOrder.Find(OrderId);
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
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check if the CustomerId
            if (AnOrder.Order_TotalAmount != 24.9900)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid (OrderDateTime, OrderDescription);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderDescription = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(OrderDateTime, OrderDescription);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderDescription = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderDateTime, OrderDescription);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderDescriptionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderDescription = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderDateTime, OrderDescription);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderDescriptionMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderDescription = ""; 
            OrderDescription = OrderDescription.PadRight(49, 'a'); //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderDateTime, OrderDescription);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionNameMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderDescription = ""; 
            OrderDescription = OrderDescription.PadRight(50, 'a'); //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderDateTime, OrderDescription);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderDescription = ""; 
            OrderDescription = OrderDescription.PadRight(51, 'a'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(OrderDateTime, OrderDescription);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderDescription = ""; 
            OrderDescription = OrderDescription.PadRight(25, 's'); //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderDateTime, OrderDescription);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionExtreme()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderDescription = ""; 
            OrderDescription = OrderDescription.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(OrderDateTime, OrderDescription);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateTimeExtremeMin()
        {
            //create an instance of the order class
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the ate is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date to string variableble
            string OrderDateTime = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDateTime, OrderDescription);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderDateTimeMinLessOne()
        {
            //create an instance of the order class
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the ate is less 100 years
            TestDate = TestDate.AddYears(-1);
            //convert the date to string variableble
            string OrderDateTime = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDateTime, OrderDescription);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderDateTimeMin()
        {
            //create an instance of the order class
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date to string variableble
            string OrderDateTime = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDateTime, OrderDescription);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateTimeMinPlusOne()
        {
            //create an instance of the order class
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date to string variableble
            string OrderDateTime = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDateTime, OrderDescription);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateTimeExtremeMax()
        {
            //create an instance of the order class
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(100);
            //convert the date to string variableble
            string OrderDateTime = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDateTime, OrderDescription);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateTimeInvalidData()
        {
            //create an instance of the order class
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //set the Order DateTime to an non date value
            string OrderDateTime = "this is not a date!";
            //invoke the method
            Error = AnOrder.Valid(OrderDateTime, OrderDescription);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
