using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool ProductID { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public DateTime ProductShipped { get; set; }
        public bool ProductAvailability { get; set; }
    }
}