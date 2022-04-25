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
    }
}
