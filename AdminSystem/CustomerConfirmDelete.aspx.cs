﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;



public partial class _1_ConfirmDelete : System.Web.UI.Page
{   
    //var to store the primary key value of the record to be deleted
    Int32 CustomerId;
    
    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the customer Id to be deleted from the session object
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create new instance of the customer class
        clsCustomerCollection Customer = new clsCustomerCollection();
        //find the record to delete
        Customer.ThisCustomer.Find(CustomerId);
        //delete the record
        Customer.Delete();
        //redirect back to main page
        Response.Redirect("CustomerList.aspx");

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to main page
        Response.Redirect("CustomerList.aspx");
    }
}