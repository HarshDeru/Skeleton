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
            String TestData = "Male";
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
    }
}









