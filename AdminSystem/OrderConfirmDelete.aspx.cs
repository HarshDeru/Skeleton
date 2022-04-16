using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 OrderId;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be deleted from the session oject
        OrderId = Convert.ToInt32(Session["OrderId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the order class
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find the recod to delete
        OrderBook.ThisOrder.Find(OrderId);
        //delete the record
        OrderBook.Delete();
        //redirect back to the main page
        Response.Redirect("OrderList.aspx");
    }
}