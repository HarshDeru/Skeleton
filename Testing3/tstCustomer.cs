using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Test_Framework
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass to the method
        string CustomerFullName = "Ujwal Dharmesh";
        string CustomerDateOfBirth = DateTime.Now.Date.ToString();
        string CustomerAddress = "148 New House Road";
        string CustomerNumber = "7438028474";
        string CustomerEmail = "ujwal710@gmail.com";


        

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

        //========================Find Mthod======================================

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

        //========================Find Mthod for Customer ID=======================

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

        //========================Find Mthod for Customer FullName=======================

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
            if (ACustomer.CustomerFullName != "Ujwal Dharmesh")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        //========================Find Mthod for Customer Date of birth=======================

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

        //========================Find Mthod for Customer Gender=======================

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

        //========================Find Mthod for Customer Address=======================

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
            if (ACustomer.CustomerAddress != "148 New House Road")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }


        //========================Find Mthod for Customer Number=======================
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
            if (ACustomer.CustomerNumber != 7438028474)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }


        //========================Find Mthod for Customer Email=======================
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
            if (ACustomer.CustomerEmail != "ujwal710@gmail.com")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        //========================================Validation Method===============================================================

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //=======================================CustomerFullName=================================================================

        [TestMethod]
        public void CustomerFullnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerFullName = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerFullnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerFullName = "aa";
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerFullnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerFullName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerFullnameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerFullName = "aaaaaaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerFullnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerFullName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerFullnameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerFullName = "";
            CustomerFullName = CustomerFullName.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        //===============================CustomerDateOfBirth======================================================================

        [TestMethod]
        public void CustomerDateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string CustomerDateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string CustomerDateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateOfBirthMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string CustomerDateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string CustomerDateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string CustomerDateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateOfBirthInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the Customer date of birth to todays date
            string CustomerDateOfBirth = "this is not a date!";
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        //=================================CustomerAddress========================================================================


        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerFullName = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerFullName = "aa";
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAdressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(51, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        //===============================================CustomerNumber============================================================

        [TestMethod]
        public void CustomerNumberExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerNumber = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerNumber = "123456789";
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerNumber = "01234567890";
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerNumber = "";
            CustomerNumber = CustomerNumber.PadRight(10, '0');
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNumberMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerNumber = "";
            CustomerNumber = CustomerNumber.PadRight(10, '0');
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerNumber = "";
            CustomerNumber = CustomerNumber.PadRight(12, '0');
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerNumber = "";
            CustomerNumber = CustomerNumber.PadRight(500, '0');
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        //================================================CustomerEmail============================================================

        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerEmail = "@gmail.com";
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerEmail = "aa@gmail.com";
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(39, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerEmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(20, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(41, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerEmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        
    }
}








