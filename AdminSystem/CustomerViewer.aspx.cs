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
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //get the data from the session object
        ACustomer = (clsCustomer)Session["ACustomer"];
        //dispay the house number for this entry
        Response.Write(ACustomer.CustomerId + "<br>");
        Response.Write(ACustomer.CustomerFullName + "<br>");
        Response.Write(ACustomer.CustomerDateOfBirth + "<br>");
        Response.Write(ACustomer.CustomerGender + "<br>");
        Response.Write(ACustomer.CustomerAddress + "<br>");
        Response.Write(ACustomer.CustomerNumber + "<br>");
        Response.Write(ACustomer.CustomerEmail + "<br>");
    }
}