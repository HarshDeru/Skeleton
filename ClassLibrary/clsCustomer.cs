using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the customer Id property
        private Int32 mCustomerId;
        //CustomerId public property
        public int CustomerId
        { get
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
        private String mCustomerFullName;
        //CustomerFullName public property
        public string CustomerFullName 
        { get
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
        { get
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
        private bool mCustomerGender;
        //CustomerFullName public property
        public bool CustomerGender
        { get
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
        private String mCustomerAddress;
        //CustomerFullName public property
        public string CustomerAddress
        { get
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
        private long mCustomerNumber;
        //CustomerFullName public property
        public long CustomerNumber
        { get
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
        private String mCustomerEmail;
        //CustomerFullName public property
        public string CustomerEmail
        { get
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
            //set the private data members to the test data value
            mCustomerId = 1;
            mCustomerFullName = "Test CustomerFullName";
            mCustomerDateOfBirth = Convert.ToDateTime("07/10.2001");
            mCustomerGender = true;
            mCustomerAddress = "Test CustomerAddress";
            mCustomerNumber = 00000000000;
            mCustomerEmail = "Test CustomerEmail";
            //always return true
            return true;
        }
    }
}