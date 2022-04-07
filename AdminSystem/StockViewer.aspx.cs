using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of the class
        clsStock anStock = new clsStock();
        //get the data from the session object
        anStock = (clsStock)Session["anStock"];
        //display the OrderID on the page
        Response.Write(anStock.ProductID + "<br>");

        //displays the CustomerID
        Response.Write(anStock.ProductName + "<br>");
        //displays the Order Description
        Response.Write(anStock.ProductPrice + "<br>");
        //displays the Order Date/Time
        Response.Write(anStock.ProductAvailablilty + "<br>");
        //displays the Order Total Amount
        Response.Write(anStock.ProductQuantity + "<br>");
        //displays the Order Dispatched
        Response.Write(anStock.ProductShipped+ "<br>");


    }
}