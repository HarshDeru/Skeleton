using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //create data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();

        //public property for the order list
        public List<clsOrder> OrdersList
        {
            get
            {
                //returb the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of list
                return mOrderList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsOrder ThisOrder { get; set; }

        public clsOrderCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank orders
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.Order_DateTime = Convert.ToDateTime(DB.DataTable.Rows[Index]["Order_DateTime"]);
                AnOrder.Order_Description = Convert.ToString(DB.DataTable.Rows[Index]["Order_Description"]);
                AnOrder.Order_TotalAmount = Convert.ToDouble(DB.DataTable.Rows[Index]["Order_TotalAmount"]);
                AnOrder.Order_Dispatched = Convert.ToBoolean(DB.DataTable.Rows[Index]["Order_Dispatched"]);
                //add the record to the private data memeber
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }
    }
}
