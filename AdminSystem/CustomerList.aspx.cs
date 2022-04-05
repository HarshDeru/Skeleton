using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        //create an instance of the Customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        //set the data source to list of customers in the collection
        lstCustomerList.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerId";
        //set the data field t display 
        lstCustomerList.DataTextField = "CustomerFullName";
        //bind the data to list
        lstCustomerList.DataBind();
    }
}