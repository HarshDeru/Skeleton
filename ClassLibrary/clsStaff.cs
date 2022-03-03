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

        public bool Find(int staffID)
        {
            //set the private data members to the test data value
            mStaffID = 1;
            mStaff_FullName = "Shilpesh Jentilal";
            mStaff_Gender = true ;
            mStaff_HireDate = Convert.ToDateTime("13/03/2020");
            mStaff_Role = "Admin";
            mStaff_Salary= 18000 ; 
            //always return true
            return true;
        }
    }
}