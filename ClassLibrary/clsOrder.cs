using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime Order_DateTime { get; set; }
        public string Order_Description { get; set; }
        public double Order_TotalAmount { get; set; }
        public bool Order_Dispatched { get; set; }
    }
}