using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductID = Convert.ToInt32(Session["ProductID"]);
        if (IsPostBack == false)
        {
            if (ProductID != -1)
            {
                DisplayStock();
            }
        }
    }

    void DisplayStock()
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ThisStock.Find(ProductID);
        txtProductID.Text = Stock.ThisStock.ProductID.ToString();
        txtProductName.Text = Stock.ThisStock.ProductName.ToString();
        txtProductPrice.Text = Stock.ThisStock.ProductPrice.ToString();
        txtProductQuantity.Text = Stock.ThisStock.ProductQuantity.ToString();
        txtProductShipped.Text = Stock.ThisStock.ProductShipped.ToString();
        dblProductAvailability.SelectedValue = Stock.ThisStock.ProductAvailability.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();
        string ProductName = txtProductName.Text;
        string ProductPrice = txtProductPrice.Text;
        string ProductQuantity = txtProductQuantity.Text;
        string ProductShipped = txtProductShipped.Text;
        string Error = "";
        Error = AnStock.Valid(ProductName, ProductShipped);
        if (Error == "")
        {
            //create a new instance of clsStock
            AnStock.ProductID = ProductID;
            AnStock.ProductName = txtProductName.Text;
            AnStock.ProductPrice = Convert.ToDouble(txtProductPrice.Text);
            AnStock.ProductQuantity = Convert.ToInt32(txtProductQuantity.Text);
            AnStock.ProductShipped = Convert.ToDateTime(txtProductShipped.Text);
            AnStock.ProductAvailability = Convert.ToBoolean(dblProductAvailability.SelectedValue);
            clsStockCollection StockList = new clsStockCollection();

            if (ProductID == -1) 
            {
                StockList.ThisStock = AnStock;
                StockList.Add();
            }

            else
            {
                StockList.ThisStock.Find(ProductID);
                StockList.ThisStock = AnStock;
                StockList.Update();
            }

            Response.Redirect("StockList.aspx");

        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the product class
        clsStock AnStock = new clsStock();
        //variable to store the primary key
        Int32 ProductID;
        //variable to store the result of find operation
        Boolean Found=false;
        //get primary key entered by the user
        ProductID = Convert.ToInt32(txtProductID.Text);
        //Find the record
        Found = AnStock.Find(ProductID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtProductName.Text = AnStock.ProductName;
            txtProductPrice.Text = AnStock.ProductPrice.ToString();
            txtProductQuantity.Text = AnStock.ProductQuantity.ToString();
            txtProductShipped.Text = AnStock.ProductShipped.ToString();
            dblProductAvailability.SelectedValue = AnStock.ProductAvailability.ToString();
        }

    }
}