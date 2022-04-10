using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.Order_DateTime = DateTime.Now.Date;
            TestItem.Order_Description = "some clothes";
            TestItem.Order_TotalAmount = 1;
            TestItem.Order_Dispatched = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrdersList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrdersList, TestList);
        }



        [TestMethod]
        public void ThisOrdersPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestOrders = new clsOrder();
            //set the propertis of the test object
            TestOrders.OrderId = 1;
            TestOrders.CustomerId = 1;
            TestOrders.Order_DateTime = DateTime.Now.Date;
            TestOrders.Order_Description = "some clothes";
            TestOrders.Order_TotalAmount = 1;
            TestOrders.Order_Dispatched = true;
            //assign the data to the property
            AllOrders.ThisOrder = TestOrders;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrders);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.Order_DateTime = DateTime.Now.Date;
            TestItem.Order_Description = "some clothes";
            TestItem.Order_TotalAmount = 1;
            TestItem.Order_Dispatched = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrdersList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrdersList, TestList);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimayKey = 0;
            //set it properties
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.Order_DateTime = DateTime.Now.Date;
            TestItem.Order_Description = "some clothes";
            TestItem.Order_TotalAmount = 1;
            TestItem.Order_Dispatched = true;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimayKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimayKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimayKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
    }
}
