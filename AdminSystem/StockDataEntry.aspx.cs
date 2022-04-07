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
        anStock.ProductName = txtProductName.Text;
        anStock.ProductPrice = Convert.ToDouble(txtProductPrice.Text);
        anStock.ProductQuantity = Convert.ToInt32(txtProductQuantity.Text);
        anStock.ProductShipped = Convert.ToDateTime(txtProductShipped.Text);
        anStock.ProductAvailablilty = Convert.ToBoolean(dblProductAvailability.SelectedIndex);
        //store the id in the session object
        Session["anStock"] = anStock;
        //navigate to the viewer page
        Response.Redirect("StockViewer.aspx");

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the product class
        clsStock AnStock = new clsStock();
        //variable to store the primary key
        Int32 ProductId;
        //variable to store the result of find operation
        Boolean Found=false;
        //get primary key entered by the user
        ProductId = Convert.ToInt32(txtProductID.Text);
        //Find the record
        Found = AnStock.Find(ProductId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtProductName.Text = AnStock.ProductName;
            txtProductPrice.Text = AnStock.ProductPrice.ToString();
            txtProductQuantity.Text = AnStock.ProductQuantity.ToString();
            txtProductShipped.Text = AnStock.ProductShipped.ToString();
            dblProductAvailability.SelectedValue = AnStock.ProductAvailablilty.ToString();


        }


    }
}