using System;

namespace ClassLibrary
{
    public class clsStock
    {

        //private data member for the product id
        private Int32 mProductID;

        public Int32 ProductID
        {
            get
            {
                //this line of code sends data out of the property
                return mProductID;
            }
            set
            {
                //this line of code allows data into the property
                mProductID = value;
            }
        }

        //private data member for the product price
        private double mProductPrice;
        public double ProductPrice
        {
            get
            {
                //this line of code sends data out of the property
                return mProductPrice;
            }
            set
            {
                //this line of code allows data into the property
                mProductPrice = value;
            }
        }

        private Boolean mProductAvailability;
        public Boolean ProductAvailablilty
        {
            get
            {
                //this line of code sends data out of the property
                return mProductAvailability;
            }
            set
            {
                //this line of code allows data into the property
                mProductAvailability = value;
            }
        }
        private DateTime mProductShipped;
        public DateTime ProductShipped
        {
            get
            {
                //this line of code sends data out of the property
                return mProductShipped;
            }
            set
            {
                //this line of code allows data into the property
                mProductShipped = value;
            }
        }
        private Int32 mProductQuantity;
        public Int32 ProductQuantity
        {
            get
            {
                //this line of code sends data out of the property
                return mProductQuantity;
            }
            set
            {
                //this line of code allows data into the property
                mProductQuantity = value;
            }
        }
        private string mProductName;
        public string ProductName
        {
            get
            {
                //this line of code sends data out of the property
                return mProductName;
            }
            set
            {
                //this line of code allows data into the property
                mProductName = value;
            }
        }

        public bool Find(int ProductId)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@ProductId", ProductId);
            //execute the atored procedure
            DB.Execute("sproc_tblStock_FilterByProductId");
            //if one record is found (there should bt either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to private data member
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mProductPrice = Convert.ToDouble(DB.DataTable.Rows[0]["ProductPrice"]);
                mProductQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["ProductQuantity"]);
                mProductShipped = Convert.ToDateTime(DB.DataTable.Rows[0]["ProductShipped"]);
                mProductAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["ProductAvailability"]);
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
    }
}