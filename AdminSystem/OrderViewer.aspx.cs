using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of the class
        clsOrder AnOrder = new clsOrder();
        //get the data from the session object
        AnOrder = (clsOrder)Session["AnOrder"];
        //display the OrderID on the page
        Response.Write(AnOrder.OrderId + "<br>");

        //displays the CustomerID
        Response.Write(AnOrder.CustomerId + "<br>");
        //displays the Order Description
        Response.Write(AnOrder.Order_Description + "<br>");
        //displays the Order Date/Time
        Response.Write(AnOrder.Order_DateTime + "<br>");
        //displays the Order Total Amount
        Response.Write(AnOrder.Order_TotalAmount + "<br>");
        //displays the Order Dispatched
        Response.Write(AnOrder.Order_Dispatched + "<br>");


    }
}