using System;
using System.Collections.Generic;



namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }

            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the private data
                return mCustomerList.Count;
            }

            set
            {
                //we shall do this later
            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }

            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }


        public clsCustomerCollection()
        {
           
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //add a new record to the database based on the values of ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerFullName", mThisCustomer.CustomerFullName);
            DB.AddParameter("@CustomerDateOfBirth", mThisCustomer.CustomerDateOfBirth);
            DB.AddParameter("@CustomerGender", mThisCustomer.CustomerGender);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerNumber", mThisCustomer.CustomerNumber);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@CustomerFullName", mThisCustomer.CustomerFullName);
            DB.AddParameter("@CustomerDateOfBirth", mThisCustomer.CustomerDateOfBirth);
            DB.AddParameter("@CustomerGender", mThisCustomer.CustomerGender);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerNumber", mThisCustomer.CustomerNumber);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //delete the reocrd pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByFullName(string CustomerFullName)
        {
            //filters the record based on a full or partial full name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the fullname parameter to the database
            DB.AddParameter("@CustomerFullName", CustomerFullName);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByFullName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are recoreds to process
            while (Index < RecordCount)
            {
                //create a blank full name
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                ACustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                ACustomer.CustomerDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDateOfBirth"]);
                ACustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                ACustomer.CustomerFullName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFullName"]);
                ACustomer.CustomerGender = Convert.ToBoolean(DB.DataTable.Rows[Index]["CustomerGender"]);
                ACustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                ACustomer.CustomerNumber = Convert.ToInt64(DB.DataTable.Rows[Index]["CustomerNumber"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }
            
        }
    }
}