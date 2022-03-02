using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
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



    }
}
