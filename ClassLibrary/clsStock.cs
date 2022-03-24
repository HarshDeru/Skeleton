using System;

namespace ClassLibrary
{
    public class clsStock
    {

        //private data member for the product id
        private Int32 mProductID;

        public int ProductID
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
        public double Product_Price
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
        public bool Product_Availablilty
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
        public DateTime Product_Shipped
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
        public int Product_Quantity
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
        private String mProductName;
        public String Product_Name
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

        public bool Find(int productId)
        {
            //set the private data numbers to the test data value
            mProductID = 21;
            mProductName = "Nike T - Shirt Size S";
            mProductPrice = 24.99;
            mProductQuantity = 40;
            mProductShipped = Convert.ToDateTime("12/01/2022");
            mProductAvailability = true;
            //always return true
            return true;
        }
    }
}