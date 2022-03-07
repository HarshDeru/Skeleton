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
        //capture all attributes
        AnOrder.OrderId = Convert.ToInt32(txtOrderID.Text);
        AnOrder.CustomerId =Convert.ToInt32(txtCustomerID.Text);
        AnOrder.Order_Description = txtOrderDescription.Text;
        AnOrder.Order_DateTime = Convert.ToDateTime(txtOrderDateTime.Text);
        AnOrder.Order_TotalAmount = Convert.ToInt32(txtOrderTotalAmount.Text);
        AnOrder.Order_Dispatched = Convert.ToBoolean(dblOrderDispatched.SelectedIndex);

        //store the address in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to viewer page
        Response.Redirect("OrderViewer.aspx");
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}