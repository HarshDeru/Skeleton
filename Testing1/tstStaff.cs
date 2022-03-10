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
            if (Staff.Staff_Gender!= true)
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

    }
}
