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

    protected void btnOk_Click(object sender, EventArgs e)
    {

        //Create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //Capture the Name
        ACustomer.CustomerId = Convert.ToInt32(txtCustomerID.Text);
        ACustomer.CustomerFullName = txtCustomerName.Text;
        ACustomer.CustomerDateOfBirth = Convert.ToDateTime(txtCustomerDateOfBirth.Text);
        ACustomer.CustomerGender = Convert.ToBoolean(ddlCustomerGender.SelectedIndex);
        ACustomer.CustomerAddress = txtCustomerAddress.Text;
        ACustomer.CustomerNumber = Convert.ToInt64(txtCustomerNumber.Text);
        ACustomer.CustomerEmail = txtCustomerEmail.Text;
        //Store the customer in the session object
        Session["ACustomer"] = ACustomer;
        //navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }
}