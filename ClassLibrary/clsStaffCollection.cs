
using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
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