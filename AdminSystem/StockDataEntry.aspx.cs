using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock anStock = new clsStock();
        //capture the product id
        anStock.ProductID = Convert.ToInt32(txtProductID.Text);
        anStock.Product_Name = txtProductName.Text;
        anStock.Product_Price = Convert.ToInt32(txtProductPrice.Text);
        anStock.Product_Quantity = Convert.ToInt32(txtProductQuantity.Text);
        anStock.Product_Shipped = Convert.ToDateTime(txtProductShipped.Text);
        anStock.Product_Availablilty = Convert.ToBoolean(dblProductAvailability.SelectedIndex);
        //store the id in the session object
        Session["anStock"] = anStock;
        //navigate to the viewer page
        Response.Redirect("StockViewer.aspx");

    }
}