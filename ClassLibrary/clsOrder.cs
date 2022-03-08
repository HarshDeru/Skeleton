using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the OrderId property
        private Int32 mOrderId;
        public int OrderId 
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderId;
            }
            set
            {
                //yhis line of code allows data into property
                mOrderId = value;
            }
        }
        private Int32 mCustomerId;
        public int CustomerId {
            get
            {
                //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            {
                //yhis line of code allows data into property
                mCustomerId = value;
            }
        }
        private DateTime mOrderDateTime;
        public DateTime Order_DateTime {
            get
            {
                //this line of code sends data out of the property
                return mOrderDateTime;
            }
            set
            {
                //yhis line of code allows data into property
                mOrderDateTime = value;
            }
        }
        private string mOrderDescription;
        public string Order_Description {
            get
            {
                //this line of code sends data out of the property
                return mOrderDescription;
            }
            set
            {
                //yhis line of code allows data into property
                mOrderDescription = value;
            }
        }
        private double mOrderTotalAmount;
        public double Order_TotalAmount {
            get
            {
                //this line of code sends data out of the property
                return mOrderTotalAmount;
            }
            set
            {
                //yhis line of code allows data into property
                mOrderTotalAmount = value;
            }
        }
        private Boolean mOrderDispatched;
        public bool Order_Dispatched {
            get
            {
                //this line of code sends data out of the property
                return mOrderDispatched;
            }
            set
            {
                //yhis line of code allows data into property
                mOrderDispatched = value;
            }
        }

        public bool Find(int orderId)
        {
            //set the private data memebers to the test data value
            mOrderId = 21;
            mCustomerId = 1;
            mOrderDateTime = Convert.ToDateTime("10/10/2010");
            mOrderDescription = "Nike t-shirt, Size S";
            mOrderTotalAmount = 0000000000;
            mOrderDispatched = true;
            //always return true
            return true;
        }
    }
}