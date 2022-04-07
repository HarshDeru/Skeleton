using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_Framework
{
    [TestClass]
    public class tstStaff
    {






        [TestMethod]
        public void InstanceOK()
        {
            clsStaff Staff = new clsStaff();
            Assert.IsNotNull(Staff);
        }

        //Testing FullName property
        [TestMethod]
        public void FullNamePropertyOK()
        {
            clsStaff Staff = new clsStaff();
            String TestData = "Shilpesh Jentilal";
            Staff.Staff_FullName = TestData;
            Assert.AreEqual(Staff.Staff_FullName, TestData);
        }

        //Testing StaffID property
        [TestMethod]
        public void StaffIDPropertyOK()
        {
            clsStaff Staff = new clsStaff();
            int TestData = 1;
            Staff.StaffID = TestData;
            Assert.AreEqual(Staff.StaffID, TestData);
        }

        //Testing Staff Gender property
        [TestMethod]
        public void Staff_GenderPropertyOK()
        {
            clsStaff Staff = new clsStaff();
            Boolean TestData = true;
            Staff.Staff_Gender = TestData;
            Assert.AreEqual(Staff.Staff_Gender, TestData);
        }

        //Testing Staff role property
        [TestMethod]
        public void Staff_RolePropertyOK()
        {
            clsStaff Staff = new clsStaff();
            String TestData = "Admin";
            Staff.Staff_Role = TestData;
            Assert.AreEqual(Staff.Staff_Role, TestData);
        }

        //Testing Staff Hire Date property
        [TestMethod]
        public void Staff_HireDatePropertyOK()
        {
            clsStaff Staff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            Staff.Staff_HireDate = TestData;
            Assert.AreEqual(Staff.Staff_HireDate, TestData);
        }

        //Testing Staff Salary property
        [TestMethod]
        public void Staff_SalaryPropertyOK()
        {
            clsStaff Staff = new clsStaff();
            Double TestData = 200.03;
            Staff.Staff_Salary = TestData;
            Assert.AreEqual(Staff.Staff_Salary, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of staff class
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the methods
            Found = Staff.Find(StaffID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            //create an instance of staff class
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //bolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the methods
            Found = Staff.Find(StaffID);
            //check the staff id
            if (Staff.StaffID != 1)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestStaffFullNameFound()
        {
            //create an instance of staff class
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //bolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the methods
            Found = Staff.Find(StaffID);
            //check the staff fullname
            if (Staff.Staff_FullName != "Shilpesh Jentilal   ")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestStaffGenderFound()
        {
            //create an instance of staff class
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //bolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the methods
            Found = Staff.Find(StaffID);
            //check the staff gender
            if (Staff.Staff_Gender != true)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffHireDateFound()
        {
            //create an instance of staff class
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //bolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the methods
            Found = Staff.Find(StaffID);
            //check the staff hiredate
            if (Staff.Staff_HireDate != Convert.ToDateTime("13/03/2020"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestStaffRoleFound()
        {
            //create an instance of staff class
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //bolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the methods
            Found = Staff.Find(StaffID);
            //check the staff role
            if (Staff.Staff_Role != "Admin")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestStaffSalaryFound()
        {
            //create an instance of staff class
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //bolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the methods
            Found = Staff.Find(StaffID);
            //check the staff salary
            if (Staff.Staff_Salary != 18000.0000)
            {
                OK = false;

            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        string Staff_FullName = "Shilpesh Jentilal";
        string Staff_Role = "Admin";
        string Staff_HireDate = DateTime.Now.Date.ToString();



        //test for valid method
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the staff class
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_HireDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        //==========================Validation Test for STAFF FULL NAME=======================
        [TestMethod]
        public void Staff_FullNameMinLessOne()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_FullName = "";

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_HireDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_FullNameMin()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_FullName = "a";

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_HireDate);

            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void Staff_FullNameMinPlusOne()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_FullName = "aa";

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_HireDate);

            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void Staff_FullNameMaxMinusOne()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_FullName = "";

            Staff_FullName = Staff_FullName.PadRight(29, 's');

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_HireDate);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_FullNameMax()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_FullName = "";

            Staff_FullName = Staff_FullName.PadRight(30, 's');

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_HireDate);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_FullNameMaxPlusOne()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_FullName = "";

            Staff_FullName = Staff_FullName.PadRight(31, 's');

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_HireDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_FullNameMid()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_FullName = "";

            Staff_FullName = Staff_FullName.PadRight(15, 's');

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_HireDate);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_FullNameExtreme()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_FullName = "";

            Staff_FullName = Staff_FullName.PadRight(500, 's');

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_HireDate);

            Assert.AreNotEqual(Error, "");
        }
        //========================Validation Test for STAFF ROLE================================================

        [TestMethod]
        public void Staff_RoleMinLessOne()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_Role = "";

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_HireDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_RoleMin()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_Role = "a";

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_HireDate);

            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void Staff_RoleMinPlusOne()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_Role = "aa";

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_HireDate);

            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void Staff_RoleMaxMinusOne()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_Role = "";

            Staff_Role = Staff_Role.PadRight(25, 's');

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_HireDate);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_RoleMax()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_Role = "";

            Staff_Role = Staff_Role.PadRight(26, 's');

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_HireDate);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_RoleMaxPlusOne()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_Role = "";

            Staff_Role = Staff_Role.PadRight(27, 's');

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_HireDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_RoleMid()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_Role = "";

            Staff_Role = Staff_Role.PadRight(13, 's');

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_HireDate);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_RoleExtreme()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_Role = "";

            Staff_Role = Staff_Role.PadRight(500, 's');

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_HireDate);

            Assert.AreNotEqual(Error, "");
        }

        //==================Validation Test for STAFF HIRE DATE============================
        [TestMethod]
        public void Staff_HireDateExtremeMin()
        {
            //create an instance of the staff class
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the ate is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date to string variableble
            string Staff_HireDate = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_HireDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void Staff_HireDateMinLessOne()
        {
            //create an instance of the staff class
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the ate is less 100 years
            TestDate = TestDate.AddYears(-1);
            //convert the date to string variableble
            string Staff_HireDate = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_HireDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void Staff_HireDateMin()
        {
            //create an instance of the staff class
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date to string variableble
            string Staff_HireDate = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_HireDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_HireDateMinPlusOne()
        {
            //create an instance of the staff class
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date to string variableble
            string Staff_HireDate = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_HireDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_HireDateExtreme()
        {
            //create an instance of the staff class
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(100);
            //convert the date to string variableble
            string Staff_HireDate = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_HireDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void Staff_HireDateInvalidData()
        {
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //set the date to a non date value;
            string Staff_HireDate = "this is not a date!";
            //invoke the method
            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_HireDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");




        }
    }
}