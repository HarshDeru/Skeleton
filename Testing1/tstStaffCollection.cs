using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            List<clsStaff> TestList = new List<clsStaff>();

            clsStaff TestItem = new clsStaff();
            TestItem.StaffID = 1;
            TestItem.Staff_FullName = "Shilpesh Jentilal   ";
            TestItem.Staff_Gender = true;
            TestItem.Staff_HireDate = Convert.ToDateTime("13/03/2020");
            TestItem.Staff_Role = "Admin";
            TestItem.Staff_Salary = 18000;

            TestList.Add(TestItem);

            AllStaff.StaffList = TestList;

            Assert.AreEqual(AllStaff.StaffList, TestList);

        }




        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            clsStaff TestStaff = new clsStaff();

            TestStaff.StaffID = 1;
            TestStaff.Staff_FullName = "Shilpesh Jentilal   ";
            TestStaff.Staff_Gender = true;
            TestStaff.Staff_HireDate = Convert.ToDateTime("13/03/2020");
            TestStaff.Staff_Role = "Admin";
            TestStaff.Staff_Salary = 18000;

        }

        [TestMethod]
        public void ListAndCountOk()
        {

            clsStaffCollection AllStaff = new clsStaffCollection();

            List<clsStaff> TestList = new List<clsStaff>();

            clsStaff TestItem = new clsStaff();

            TestItem.StaffID = 1;
            TestItem.Staff_FullName = "Shilpesh Jentilal   ";
            TestItem.Staff_Gender = true;
            TestItem.Staff_HireDate = Convert.ToDateTime("13/03/2020");
            TestItem.Staff_Role = "Admin";
            TestItem.Staff_Salary = 18000;

            TestList.Add(TestItem);

            AllStaff.StaffList = TestList;

            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }
        //======================AddMethod===========================================
        [TestMethod]
        public void AddMehtodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();

            clsStaff TestItem = new clsStaff();

            Int32 PrimaryKey = 0;

            TestItem.StaffID = 1;
            TestItem.Staff_FullName = "Shilpesh Jentilal   ";
            TestItem.Staff_Gender = true;
            TestItem.Staff_HireDate = Convert.ToDateTime("13/03/2020");
            TestItem.Staff_Role = "Admin";
            TestItem.Staff_Salary = 18000;

            AllStaffs.ThisStaff = TestItem;

            TestItem.StaffID = PrimaryKey;

            AllStaffs.ThisStaff.Find(PrimaryKey);

            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);

        }

        //======================UpdateMethod===========================================
        [TestMethod]
        public void UpdateMethod()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();

            clsStaff TestItem = new clsStaff();

            Int32 PrimaryKey = 0;

            TestItem.StaffID = 1;
            TestItem.Staff_FullName = "Shilpesh Jentilal   ";
            TestItem.Staff_Gender = true;
            TestItem.Staff_HireDate = Convert.ToDateTime("13/03/2020");
            TestItem.Staff_Role = "Admin";
            TestItem.Staff_Salary = 18000;

            AllStaffs.ThisStaff = TestItem;
            TestItem.StaffID = PrimaryKey;

            TestItem.StaffID = 1;
            TestItem.Staff_FullName = "Shilpesh Jentilal   ";
            TestItem.Staff_Gender = true;
            TestItem.Staff_HireDate = Convert.ToDateTime("13/03/2020");
            TestItem.Staff_Role = "Admin";
            TestItem.Staff_Salary = 24000;

            AllStaffs.ThisStaff = TestItem;
            AllStaffs.Update();

            AllStaffs.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);

        }

        //======================DeleteMethod===========================================

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();

            clsStaff TestItem = new clsStaff();

            Int32 PrimaryKey = 0;

            TestItem.StaffID = 1;
            TestItem.Staff_FullName = "Shilpesh Jentilal   ";
            TestItem.Staff_Gender = true;
            TestItem.Staff_HireDate = Convert.ToDateTime("13/03/2020");
            TestItem.Staff_Role = "Admin";
            TestItem.Staff_Salary = 18000;

            AllStaffs.ThisStaff = TestItem;

            PrimaryKey = AllStaffs.Add();

            TestItem.StaffID = PrimaryKey;

            AllStaffs.ThisStaff.Find(PrimaryKey);
            AllStaffs.Delete();

            Boolean Found = AllStaffs.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);
        }

        //======================ReportByFullNameMethod===========================================

        [TestMethod]
        public void ReportByFullNameMethodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaffCollection FilteredStaffs = new clsStaffCollection();

            FilteredStaffs.ReportByFullName("");

            Assert.AreEqual(AllStaffs.Count, FilteredStaffs.Count);

        }

        [TestMethod]
        public void ReportByFullNameNoneFound()
        {


            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReportByFullName("xxx xxx");
            Assert.AreEqual(0, FilteredStaff.Count);
        }


        [TestMethod]
        public void ReportByFullNameTestDataFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            Boolean OK = true;

            FilteredStaff.ReportByFullName("Thresh Lantern");
            if(FilteredStaff.Count == 2)
            {
                if (FilteredStaff.StaffList[0].StaffID != 10)
                {
                    OK = false;
                }
                if (FilteredStaff.StaffList[1].StaffID != 14)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


    }

}


