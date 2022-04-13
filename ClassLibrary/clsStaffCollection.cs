
using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();
        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }



        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {

            }
        }

        
        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }

        //============Add Method ====================================
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Staff_FullName", mThisStaff.Staff_FullName);
            DB.AddParameter("@Staff_Gender", mThisStaff.Staff_Gender);
            DB.AddParameter("@Staff_Role", mThisStaff.Staff_Role);
            DB.AddParameter("@Staff_HireDate", mThisStaff.Staff_HireDate);
            DB.AddParameter("@Staff_Salary", mThisStaff.Staff_Salary);

            return DB.Execute("sproc_tblStaff_Insert");
        }

        //============Update Method ====================================
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@Staff_FullName", mThisStaff.Staff_FullName);
            DB.AddParameter("@Staff_Gender", mThisStaff.Staff_Gender);
            DB.AddParameter("@Staff_Role", mThisStaff.Staff_Role);
            DB.AddParameter("@Staff_HireDate", mThisStaff.Staff_HireDate);
            DB.AddParameter("@Staff_Salary", mThisStaff.Staff_Salary);

            DB.Execute("sproc_tblStaff_Update");

        }
        //============Delete Method ====================================
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.Execute("sproc_tblStaff_Delete");
        }


        public clsStaffCollection()
        {
            Int32 Index = 0;

            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();
            
            DB.Execute("sproc_tblStaff_SelectAll");

            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsStaff Staff = new clsStaff();
                Staff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                Staff.Staff_FullName = Convert.ToString(DB.DataTable.Rows[Index]["Staff_FullName"]);
                Staff.Staff_Gender = Convert.ToBoolean(DB.DataTable.Rows[Index]["Staff_Gender"]);
                Staff.Staff_Role = Convert.ToString(DB.DataTable.Rows[Index]["Staff_Role"]);
                Staff.Staff_HireDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["Staff_HireDate"]);
                Staff.Staff_Salary = Convert.ToDouble(DB.DataTable.Rows[Index]["Staff_Salary"]);

                mStaffList.Add(Staff);
                Index++;
            }
        }


        
    }
}