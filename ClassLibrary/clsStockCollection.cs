using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {

            }
        }
        public clsStock ThisStock { get; set; }

        public clsStockCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStock AnStock = new clsStock();
                AnStock.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AnStock.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                AnStock.ProductPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["ProductPrice"]);
                AnStock.ProductQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductQuantity"]);
                AnStock.ProductShipped = Convert.ToDateTime(DB.DataTable.Rows[Index]["ProductShipped"]);
                AnStock.ProductAvailability = Convert.ToBoolean(DB.DataTable.Rows[Index]["ProductAvailability"]);
                mStockList.Add(AnStock);
                Index++;
            }
        }

    }
}