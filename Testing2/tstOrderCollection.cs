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

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Order_Dispatched = true;
            TestItem.CustomerId = 1;
            TestItem.Order_DateTime = DateTime.Now.Date;
            TestItem.Order_Description = "Test Street";
            TestItem.Order_TotalAmount = 45;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //modify the test data
            TestItem.Order_Dispatched = false;
            TestItem.CustomerId = 3;
            TestItem.Order_DateTime = DateTime.Now.Date;
            TestItem.Order_Description = "Another Street";
            TestItem.Order_TotalAmount = 50;
            //set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see ThisOrders matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Order_Dispatched = true;
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.Order_DateTime = DateTime.Now.Date;
            TestItem.Order_Description = "some cloths";
            TestItem.Order_TotalAmount = 50;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //ADD THE RECORD
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delecte the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByDescriptionsMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a blank string (should return all record);
            FilteredOrders.ReportByDescriptions("");
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByDescriptionsNoneFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a blank string (should return all record);
            FilteredOrders.ReportByDescriptions("xxxxxxxxxx");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByDescriptionsTestDataFound()
        {
            //create a instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a post code that doesn't exist
            FilteredOrders.ReportByDescriptions("yyyyyyyyyy");
            //check that the correct number of records are found
            if (FilteredOrders.Count == 2)
            {
                //check that first record is ID 36
                if (FilteredOrders.OrdersList[1].OrderId != 7)
                {
                    OK = false;
                }
                //check that the first record is ID 37
                if (FilteredOrders.OrdersList[1].OrderId != 8)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no record
            Assert.IsTrue(OK);
        }
    }
}
