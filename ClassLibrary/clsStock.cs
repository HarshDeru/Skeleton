using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Active { get; set; }
        public int ProductID { get; set; }
        public double Product_Price { get; set; }
        public bool Product_Availablilty { get; set; }
        public DateTime Product_Shipped { get; set; }
        public int Product_Quantity { get; set; }
        public string Product_Name { get; set; }
    }
}