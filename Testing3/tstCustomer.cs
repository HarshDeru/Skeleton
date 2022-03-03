using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
        public object DataTime { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        }


        [TestMethod]
        public void CustomerIdPropertyOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            int TestData = 1;

            ACustomer.CustomerId = TestData;
            Assert.AreEqual(ACustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void CustomerFullNamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "Shila Javani";
            ACustomer.CustomerFullName = TestData;
            Assert.AreEqual(ACustomer.CustomerFullName, TestData);
        }

        [TestMethod]
        public void CustomerDateOfBirthPropertyOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.CustomerDateOfBirth = TestData;
            Assert.AreEqual(ACustomer.CustomerDateOfBirth, TestData);
        }

        [TestMethod]
        public void CustomerGenderPropertyOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            bool TestData = true;
            ACustomer.CustomerGender = TestData;
            Assert.AreEqual(ACustomer.CustomerGender, TestData);
        }

        [TestMethod]
        public void CustomerAddressPropertyOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "54 Uppercut Lane";
            ACustomer.CustomerAddress = TestData;
            Assert.AreEqual(ACustomer.CustomerAddress, TestData);

        }

        [TestMethod]
        public void CustomerNumberPropertyOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            Int64 TestData = 07549466467;
            ACustomer.CustomerNumber = TestData;
            Assert.AreEqual(ACustomer.CustomerNumber, TestData);

        }

        [TestMethod]
        public void CustomerEmailPropertyOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "ShilpeshJentilal@yahoo.com";
            ACustomer.CustomerEmail = TestData;
            Assert.AreEqual(ACustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an istance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIdNoFound()
        {
            //create an istance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check if the CustomerId
            if (ACustomer.CustomerId != 1)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerFullNameFound()
        {
            //create an istance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check if the CustomerId
            if (ACustomer.CustomerFullName != "Test CustomerFullName")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an istance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check if the CustomerId
            if (ACustomer.CustomerDateOfBirth != Convert.ToDateTime("07/10/2001"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerGenderFound()
        {
            //create an istance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check if the CustomerId
            if (ACustomer.CustomerGender != true)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            //create an istance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check if the CustomerId
            if (ACustomer.CustomerAddress != "Test CustomerAddress")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNumberFound()
        {
            //create an istance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check if the CustomerId
            if (ACustomer.CustomerNumber != 00000000000)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {
            //create an istance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check if the CustomerId
            if (ACustomer.CustomerEmail != "Test CustomerEmail")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
    }
}









