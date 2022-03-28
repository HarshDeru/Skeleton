using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the customer Id property
        private Int32 mCustomerId;
        //CustomerId public property
        public Int32 CustomerId
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
        }

        //private data member for the customer FullName property
        private string mCustomerFullName;
        //CustomerFullName public property
        public string CustomerFullName
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerFullName;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerFullName = value;
            }
        }

        //private data member for the customer DateOfBirth property
        private DateTime mCustomerDateOfBirth;
        //CustomerFullName public property
        public DateTime CustomerDateOfBirth
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerDateOfBirth;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerDateOfBirth = value;
            }
        }

        //private data member for the customer Gender property
        private Boolean mCustomerGender;
        //CustomerFullName public property
        public Boolean CustomerGender
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerGender;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerGender = value;
            }
        }

        //private data member for the customer Address property
        private string mCustomerAddress;
        //CustomerFullName public property
        public string CustomerAddress
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerAddress;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerAddress = value;
            }
        }

        //private data member for the customer Number property
        private Int64 mCustomerNumber;
        //CustomerFullName public property
        public Int64 CustomerNumber
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerNumber;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerNumber = value;
            }
        }

        //private data member for the customer Email property
        private string mCustomerEmail;
        //CustomerFullName public property
        public string CustomerEmail
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerEmail;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerEmail = value;
            }
        }

        public bool Find(int CustomerId)
        {
            //create an istance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@CustomerId", CustomerId);
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {

                //copy the data from the database to the private data numbers
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mCustomerFullName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFullName"]);
                mCustomerDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDateOfBirth"]);
                mCustomerGender = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerGender"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mCustomerNumber = Convert.ToInt64(DB.DataTable.Rows[0]["CustomerNumber"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                return true;

            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
    }
}
