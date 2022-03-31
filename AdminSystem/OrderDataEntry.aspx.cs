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
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the Order DateTime
        string OrderDateTime = txtOrderDateTime.Text;
        //capture the Order Description
        string OrderDescription = txtOrderDescription.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(OrderDateTime, OrderDescription);
        if (Error == "")
        {
            //capture all attributes
            AnOrder.OrderId = Convert.ToInt32(txtOrderID.Text);
            AnOrder.CustomerId = Convert.ToInt32(txtCustomerID.Text);
            AnOrder.Order_Description = txtOrderDescription.Text;
            AnOrder.Order_DateTime = Convert.ToDateTime(txtOrderDateTime.Text);
            AnOrder.Order_TotalAmount = Convert.ToInt32(txtOrderTotalAmount.Text);
            AnOrder.Order_Dispatched = Convert.ToBoolean(dblOrderDispatched.SelectedIndex);
            //store the address in the session object
            Session["AnOrder"] = AnOrder;
            //navigate to viewer page
            Response.Redirect("OrderViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the order class
        clsOrder AnOrder = new clsOrder();
        //variable to store the primary key
        Int32 OrderID;
        //variable to store the result of the find operation
        Boolean Found= false;
        //get the primary key entered by the user
        OrderID = Convert.ToInt32(txtOrderID.Text);
        //find the record
        Found = AnOrder.Find(OrderID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerID.Text = AnOrder.CustomerId.ToString();
            txtOrderDateTime.Text = AnOrder.Order_DateTime.ToString();
            txtOrderDescription.Text = AnOrder.Order_Description;
            txtOrderTotalAmount.Text = AnOrder.Order_TotalAmount.ToString();
            dblOrderDispatched.Text = AnOrder.Order_Dispatched.ToString();


        }

    }
}