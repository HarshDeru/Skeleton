using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

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
        anStock.ProductId = Convert.ToInt32(txtProductID.Text);
        anStock.ProductName = txtProductName.Text;
        anStock.ProductPrice = Convert.ToInt32(txtProductPrice.Text);
        anStock.ProductQuantity = Convert.ToInt32(txtProductQuantity.Text);
        anStock.ProductShipped = Convert.ToDateTime(txtProductShipped.Text);
        anStock.ProductAvailability = Convert.ToBoolean(dblProductAvailability.SelectedIndex);
        //store the id in the session object
        Session["anStock"] = anStock;
        //navigate to the viewer page
        Response.Redirect("StockViewer.aspx");
    }
}