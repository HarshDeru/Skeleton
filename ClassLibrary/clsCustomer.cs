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

        public string Valid(string CustomerFullName, string CustomerDateOfBirth, string CustomerAddress, string CustomerNumber, string CustomerEmail)
        {
            //create a string variable to store the error
            String Error = "";
            //Create a tempory variable to store the date value
            DateTime DateTemp;
            //if the CustomerFullName is blank
            if (CustomerFullName.Length == 0)
            {
                //record the error
                Error = Error + "The Customer FullName may not be blank : ";

            }
            if (CustomerFullName.Length > 30)
            {
                //record the error
                Error = Error + "The Customer Full Name must be less than 30 characters : ";
            }

            try
            {
                //Copy the date of birth value to the DateTemp Variable
                DateTemp = Convert.ToDateTime(CustomerDateOfBirth);
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The Date cannot be above today's date : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            //if the Customer Address is blank
            if (CustomerAddress.Length == 0)
            {
                //record the error
                Error = Error + "The Customer Address may not be blank : ";
            }
            if (CustomerAddress.Length > 50)
            {
                //record the error
                Error = Error + "The Customer Address must be less than 50 characters : ";
            }

            //if the customer number is blank or less than 11 characters
            if (CustomerNumber.Length < 10)
            {
                //record the error
                Error = Error + "The Customer Number may not be less than 10 charcters : ";
            }
            if (CustomerNumber.Length > 11)
            {
                //record the error 
                Error = Error + "The Customer Number must not be higher the 11 charcters : ";
            }

            //if the customer Email is left blank
            if (CustomerEmail.Length < 11)
            {
                //record the error
                Error = Error + "The Customer Email may not be less 11 characters : ";
            }
            if (CustomerEmail.Length > 40)
            {
                //record the error
                Error = Error + "The Customer Email must be less than 40 characters : ";
            }

            //return any error message
            return Error;
        }

    }
}
