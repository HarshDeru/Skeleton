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
            TestItem.CustomerId = 1;
            TestItem.CustomerFullName = "Ujwal Dharmesh";
            TestItem.CustomerDateOfBirth = Convert.ToDateTime("07/10/2001");
            TestItem.CustomerGender = true;
            TestItem.CustomerAddress = "148 New House Road";
            TestItem.CustomerNumber = 07438028474;
            TestItem.CustomerEmail = "ujwal710@gmail.com";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }


        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.CustomerId = 1;
            TestCustomer.CustomerFullName = "Ujwal Dharmesh";
            TestCustomer.CustomerDateOfBirth = Convert.ToDateTime("07/10/2001");
            TestCustomer.CustomerGender = true;
            TestCustomer.CustomerAddress = "148 New House Road";
            TestCustomer.CustomerNumber = 07438028474;
            TestCustomer.CustomerEmail = "ujwal710@gmail.com";

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerId = 1;
            TestItem.CustomerFullName = "Ujwal Dharmesh";
            TestItem.CustomerDateOfBirth = Convert.ToDateTime("07/10/2001");
            TestItem.CustomerGender = true;
            TestItem.CustomerAddress = "148 New House Road";
            TestItem.CustomerNumber = 07438028474;
            TestItem.CustomerEmail = "ujwal710@gmail.com";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        //======================ADD Method=================================

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.CustomerId = 1;
            TestItem.CustomerFullName = "Ujwal Dharmesh";
            TestItem.CustomerDateOfBirth = Convert.ToDateTime("07/10/2001");
            TestItem.CustomerGender = true;
            TestItem.CustomerAddress = "148 New House Road";
            TestItem.CustomerNumber = 07438028474;
            TestItem.CustomerEmail = "ujwal710@gmail.com";
            //set ThisCustomer to test data
            AllCustomers.ThisCustomer = TestItem;
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //Test to see that the two value are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        //===============================Update Method================================

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.CustomerId = 9;
            TestItem.CustomerFullName = "Ujwal Dharmesh";
            TestItem.CustomerDateOfBirth = Convert.ToDateTime("07/10/2001");
            TestItem.CustomerGender = true;
            TestItem.CustomerAddress = "148 New House Road";
            TestItem.CustomerNumber = 07438028474;
            TestItem.CustomerEmail = "ujwal710@gmail.com";
            //set ThisCustomer to test data
            AllCustomers.ThisCustomer = TestItem;
            //Add the record
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //modify the test data
            TestItem.CustomerId = 9;
            TestItem.CustomerFullName = "Ajmal Asraf";
            TestItem.CustomerDateOfBirth = Convert.ToDateTime("30/05/2002");
            TestItem.CustomerGender = true;
            TestItem.CustomerAddress = "18 Amazon Road";
            TestItem.CustomerNumber = 07369854856;
            TestItem.CustomerEmail = "AnjarAsraf@gmail.com";
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        //==================Delete Method===============================
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerId = 9;
            TestItem.CustomerFullName = "Ajmal Asraf";
            TestItem.CustomerDateOfBirth = Convert.ToDateTime("30/05/2002");
            TestItem.CustomerGender = true;
            TestItem.CustomerAddress = "18 Amazon Road";
            TestItem.CustomerNumber = 07369854856;
            TestItem.CustomerEmail = "AnjarAsraf@gmail.com";
            //set This Customer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        //========================ReportByCustomerFullNameMethod=========================

        [TestMethod]
        public void ReportByCustomerFullNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (Shoulf return all the records);
            FilteredCustomers.ReportByFullName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        //=========================ReportByCustomerFullNameNoneFound========================
        [TestMethod]
        public void ReportByCustomerFullNameNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a full naem that doesn't exist
            FilteredCustomers.ReportByFullName("John Watson");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        //========================ReportByCustomerFullNameTestDataFound=====================
        [TestMethod]
        public void ReportByCustomerFullNameTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store outcome 
            Boolean OK = true;
            //apply a full name that doesn't exist
            FilteredCustomers.ReportByFullName("Ujwal Dharmesh");
            //check that the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {
                //check that first record is ID 1
                if (FilteredCustomers.CustomerList[0].CustomerId != 1)
                {
                    OK = false;
                }

                //check that thr first record is Id 27
                if (FilteredCustomers.CustomerList[1].CustomerId != 27)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
        
    }
}
