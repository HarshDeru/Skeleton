﻿using System;
using System.Collections.Generic;



namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
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
        public clsCustomer ThisCustomer { get; set; }


        public clsCustomerCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer ACustomer = new clsCustomer();
                //read in the field from the current record
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