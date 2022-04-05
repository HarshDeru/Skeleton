using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an istance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerAddress = "some address";
            TestItem.CustomerDateOfBirth = DateTime.Now.Date;
            TestItem.CustomerEmail = "who@gmail.com";
            TestItem.CustomerFullName = "Name surname";
            TestItem.CustomerGender = true;
            TestItem.CustomerId = 1;
            TestItem.CustomerNumber = 07438028474;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to property
            Int32 SomeCount = 0;
            //assign the data to prperty
            AllCustomers.Count = SomeCount;
            //test to see that the two value are the same
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.CustomerAddress = "some address";
            TestCustomer.CustomerDateOfBirth = DateTime.Now.Date;
            TestCustomer.CustomerEmail = "who@gmail.com";
            TestCustomer.CustomerFullName = "Name surname";
            TestCustomer.CustomerGender = true;
            TestCustomer.CustomerId = 1;
            TestCustomer.CustomerNumber = 07438028474;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //Test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
    }
}
