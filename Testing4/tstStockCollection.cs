using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstStockCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            Assert.IsNotNull(AllStocks);
        }

        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.ProductID = 1;
            TestItem.ProductName = "Nike T-Shirt Size S";
            TestItem.ProductPrice = 24.9900;
            TestItem.ProductQuantity = 40;
            TestItem.ProductShipped = DateTime.Now.Date;
            TestItem.ProductAvailability = true;
            TestList.Add(TestItem);
            AllStocks.StockList = TestList;
            Assert.AreEqual(AllStocks.StockList, TestList);
        }

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestStock = new clsStock();
            TestStock.ProductID = 1;
            TestStock.ProductName = "Nike T-Shirt Size S";
            TestStock.ProductPrice = 24.9900;
            TestStock.ProductQuantity = 40;
            TestStock.ProductShipped = DateTime.Now.Date;
            TestStock.ProductAvailability = true;
            AllStock.ThisStock = TestStock;
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.ProductID = 1;
            TestItem.ProductName = "Nike T-Shirt Size S";
            TestItem.ProductPrice = 24.9900;
            TestItem.ProductQuantity = 40;
            TestItem.ProductShipped = DateTime.Now.Date;
            TestItem.ProductAvailability = true;
            TestList.Add(TestItem);
            AllStocks.StockList = TestList;
            Assert.AreEqual(AllStocks.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.ProductID = 1;
            TestItem.ProductName = "Nike T-Shirt Size S";
            TestItem.ProductPrice = 24.9900;
            TestItem.ProductQuantity = 40;
            TestItem.ProductShipped = DateTime.Now.Date;
            TestItem.ProductAvailability = true;
            AllStocks.ThisStock = TestItem;
            PrimaryKey = AllStocks.Add();
            TestItem.ProductID = PrimaryKey;
            AllStocks.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            
            TestItem.ProductName = "Nike T-Shirt Size S";
            TestItem.ProductPrice = 24.9900;
            TestItem.ProductQuantity = 40;
            TestItem.ProductShipped = DateTime.Now.Date;
            TestItem.ProductAvailability = true;

            AllStocks.ThisStock = TestItem;
            PrimaryKey = AllStocks.Add();
            TestItem.ProductID = PrimaryKey;

            TestItem.ProductName = "another product";
            TestItem.ProductPrice = 79.9900;
            TestItem.ProductQuantity = 30;
            TestItem.ProductShipped = DateTime.Now.Date;
            TestItem.ProductAvailability = true;

            AllStocks.ThisStock = TestItem;
            AllStocks.Update();
            AllStocks.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.ProductID = 1;
            TestItem.ProductName = "Nike T-Shirt Size S";
            TestItem.ProductPrice = 24.9900;
            TestItem.ProductQuantity = 40;
            TestItem.ProductShipped = DateTime.Now.Date;
            TestItem.ProductAvailability = true;
            AllStocks.ThisStock = TestItem;
            PrimaryKey = AllStocks.Add();
            TestItem.ProductID = PrimaryKey;
            AllStocks.ThisStock.Find(PrimaryKey);
            AllStocks.Delete();
            Boolean Found = AllStocks.ThisStock.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByProductNameMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStockCollection FilteredStocks = new clsStockCollection();
            FilteredStocks.ReportByProductName("");
            Assert.AreEqual(AllStocks.Count, FilteredStocks.Count);
        }

        [TestMethod]
        public void ReportByProductNameNoneFound()
        {
            clsStockCollection FilteredStocks = new clsStockCollection();
            FilteredStocks.ReportByProductName("xxxxxxxxxxxxxxx");
            Assert.AreEqual(0, FilteredStocks.Count);
        }

        [TestMethod]
        public void ReportByProductNameTestDataFound()
        {
            clsStockCollection FilterStocks = new clsStockCollection();
            Boolean OK = true;
            FilterStocks.ReportByProductName("yyyyyyyyyyyyyyy");
            if (FilterStocks.Count ==2)
            {
                if (FilterStocks.StockList[0].ProductID != 1)
                {
                    OK = false;
                }
                if (FilterStocks.StockList[1].ProductID != 2)
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }
        }
    }
}
