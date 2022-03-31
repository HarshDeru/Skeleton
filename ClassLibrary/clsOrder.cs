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

        public bool Find(int OrderId)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@OrderID", OrderId);
            //execute the atored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            //if one record is found (there should bt either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to private data member
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mOrderDateTime = Convert.ToDateTime(DB.DataTable.Rows[0]["Order_DateTime"]);
                mOrderDescription = Convert.ToString(DB.DataTable.Rows[0]["Order_Description"]);
                mOrderTotalAmount = Convert.ToDouble(DB.DataTable.Rows[0]["Order_TotalAmount"]);
                mOrderDispatched = Convert.ToBoolean(DB.DataTable.Rows[0]["Order_Dispatched"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string OrderDateTime, string OrderDescription)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the OrderDescription is blank
            if (OrderDescription.Length == 0)
            {
                //record the error
                Error = Error + "The Order Description may not be blank : ";
            }

            //if the order description is greate than 51 characters
            if (OrderDescription.Length > 50)
            {
                Error = Error + "The Order Description must be less than 50 characters : ";
            }

            try
            {
                //copy the OrderDateTime value to the DateTemp variable
                DateTemp = Convert.ToDateTime(OrderDateTime);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
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
            //return any error messages
            return Error;
        }
    }
}