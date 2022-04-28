using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();
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
        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }

        public clsStockCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            PopulateArray(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductName", mThisStock.ProductName);
            DB.AddParameter("@ProductPrice", mThisStock.ProductPrice);
            DB.AddParameter("@ProductQuantity", mThisStock.ProductQuantity);
            DB.AddParameter("@ProductShipped", mThisStock.ProductShipped);
            DB.AddParameter("@ProductAvailability", mThisStock.ProductAvailability);
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", mThisStock.ProductID);
            DB.AddParameter("@ProductName", mThisStock.ProductName);
            DB.AddParameter("@ProductPrice", mThisStock.ProductPrice);
            DB.AddParameter("@ProductQuantity", mThisStock.ProductQuantity);
            DB.AddParameter("@ProductShipped", mThisStock.ProductShipped);
            DB.AddParameter("@ProductAvailability", mThisStock.ProductAvailability);
            DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", mThisStock.ProductID);
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportByProductName(string ProductName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductName", ProductName);
            DB.Execute("sproc_tblStock_FilterByProductName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStockList = new List<clsStock>();
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