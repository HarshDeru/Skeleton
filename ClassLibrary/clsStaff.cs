using System;

namespace ClassLibrary
{
    public class clsStaff
    {

        private int mStaffID;
        public int StaffID
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffID;
            }
            set
            {
                //this line of code allows data into the property
                mStaffID = value;
            }

        }


        private string mStaff_FullName;
        public string Staff_FullName
        {
            get
            {
                //this line of code sends data out of the property
                return mStaff_FullName;
            }
            set
            {
                //this line of code allows data into the property
                mStaff_FullName = value;
            }

        }

        private Boolean mStaff_Gender;
        public Boolean Staff_Gender
        {
            get
            {
                //this line of code sends data out of the property
                return mStaff_Gender;
            }
            set
            {
                //this line of code allows data into the property
                mStaff_Gender = value;
            }

        }


        private string mStaff_Role;
        public string Staff_Role
        {
            get
            {
                //this line of code sends data out of the property
                return mStaff_Role;
            }
            set
            {
                //this line of code allows data into the property
                mStaff_Role = value;
            }

        }


        private DateTime mStaff_HireDate;
        public DateTime Staff_HireDate
        {
            get
            {
                //this line of code sends data out of the property
                return mStaff_HireDate;
            }
            set
            {
                //this line of code allows data into the property
                mStaff_HireDate = value;
            }

        }


        private double mStaff_Salary;
        public double Staff_Salary
        {
            get
            {
                //this line of code sends data out of the property
                return mStaff_Salary;
            }
            set
            {
                //this line of code allows data into the property
                mStaff_Salary = value;
            }

        }

        public bool Find(int StaffID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", StaffID);
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            if (DB.Count == 1)
            {
                //set the private data members to the test data value
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStaff_FullName = Convert.ToString(DB.DataTable.Rows[0]["Staff_FullName"]);
                mStaff_Gender = Convert.ToBoolean(DB.DataTable.Rows[0]["Staff_Gender"]);
                mStaff_Role = Convert.ToString(DB.DataTable.Rows[0]["Staff_Role"]);
                mStaff_HireDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Staff_HireDate"]);
                mStaff_Salary = Convert.ToDouble(DB.DataTable.Rows[0]["Staff_Salary"]);
                //always return true
                return true;
            }
            else
            {
                return false;


            }
        }
    }
}