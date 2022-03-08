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
        //create a new instance of clsStock
        clsStock anStock = new clsStock();
        //get the data from session object
        anStock = (clsStock)Session["anStock"];
        //display the product id for this entry
        Response.Write(anStock.ProductID + "<br>");
        Response.Write(anStock.ProductName + "<br>");
        Response.Write(anStock.ProductPrice + "<br>");
        Response.Write(anStock.ProductQuantity + "<br>");
        Response.Write(anStock.ProductShipped + "<br>");
        Response.Write(anStock.ProductAvailability + "<br>");
    }
}