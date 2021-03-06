using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be processed
        OrderId = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (OrderId != -1)
            {
                //displaye the current data for the record
                DisplayOrders();
            }
        }
    }

    private void DisplayOrders()
    {
        //create an instance of the order book
        clsOrderCollection Orders = new clsOrderCollection();
        //find the record to update
        Orders.ThisOrder.Find(OrderId);
        //display the data for this record
        txtOrderID.Text = Orders.ThisOrder.OrderId.ToString();
        txtCustomerID.Text = Orders.ThisOrder.CustomerId.ToString();
        txtOrderDescription.Text = Orders.ThisOrder.Order_Description;
        txtOrderTotalAmount.Text = Orders.ThisOrder.Order_TotalAmount.ToString();
        txtOrderDateTime.Text = Orders.ThisOrder.Order_DateTime.ToString();
        dblOrderDispatched.Text = Orders.ThisOrder.Order_Dispatched.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //captur Customer ID
        string CustomerId = txtCustomerID.Text;
        //capture Order Dispatechec
        string OrderTotalAmout = txtOrderTotalAmount.Text; 
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
            AnOrder.OrderId = OrderId; //dont miss this bit!!!!!!!!!
            AnOrder.CustomerId = Convert.ToInt32(CustomerId);
            AnOrder.Order_Description = OrderDescription;
            AnOrder.Order_DateTime = Convert.ToDateTime( OrderDateTime);
            AnOrder.Order_TotalAmount = Convert.ToDouble(OrderTotalAmout);
            AnOrder.Order_Dispatched = Convert.ToBoolean(dblOrderDispatched.SelectedIndex);
            //create a new instance of the order collection
            clsOrderCollection OrderList = new clsOrderCollection();

            //if this a new record i.e OrderID = -1 then add the data
            if (OrderId == -1)
            {
                //set the ThisOrder Property
                OrderList.ThisOrder = AnOrder;
                //add the new record
                OrderList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                OrderList.ThisOrder.Find(OrderId);
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //update the record
                OrderList.Update();

            }
            //redirect back to the listpage
            Response.Redirect("OrderList.aspx");
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