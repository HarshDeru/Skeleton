using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page levle scope
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        //if this not a new record 
        if (IsPostBack == false)
        {
            if (CustomerId != -1)
            {
                //display the current data for the record
                DisplayCustomers();
            }
        }
    }

    void DisplayCustomers()
    {
        //create an instance of the ACustomer
        clsCustomerCollection ACustomer = new clsCustomerCollection();
        //find the record to update
        ACustomer.ThisCustomer.Find(CustomerId);
        //display the data for this record
        txtCustomerID.Text = ACustomer.ThisCustomer.CustomerId.ToString();
        txtCustomerName.Text = ACustomer.ThisCustomer.CustomerFullName;
        txtCustomerDateOfBirth.Text = ACustomer.ThisCustomer.CustomerDateOfBirth.ToString();
        ddlCustomerGender.Text = ACustomer.ThisCustomer.CustomerGender.ToString();
        txtCustomerAddress.Text = ACustomer.ThisCustomer.CustomerAddress;
        txtCustomerNumber.Text = ACustomer.ThisCustomer.CustomerNumber.ToString();
        txtCustomerEmail.Text = ACustomer.ThisCustomer.CustomerEmail;
    }
    protected void btnOk_Click(object sender, EventArgs e)
    {

        //Create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //Capture the customer full name
        string CustomerFullName = txtCustomerName.Text;
        //capture the customer Date of birth
        string CustomerDateOfBirth = txtCustomerDateOfBirth.Text;
        //capture the customer address
        string CustomerAddress = txtCustomerAddress.Text;
        //capture the customer number
        string CustomerNumber = txtCustomerNumber.Text;
        //capture the customer email
        string CustomerEmail = txtCustomerEmail.Text;
        //variable to store any error message
        string Error = "";
        //validate the data 
        Error = ACustomer.Valid(CustomerFullName, CustomerDateOfBirth, CustomerAddress, CustomerNumber, CustomerEmail);
        if (Error =="")
        {
            //Capture the customer id
            ACustomer.CustomerId = CustomerId;
            //caprue the customer full name 
            ACustomer.CustomerFullName = CustomerFullName;
            //capture the customer date of birth
            ACustomer.CustomerDateOfBirth = Convert.ToDateTime(CustomerDateOfBirth);
            //Capture the customer Gender
            ACustomer.CustomerGender = Convert.ToBoolean(ddlCustomerGender.SelectedValue);
            //Capture the customer address
            ACustomer.CustomerAddress = CustomerAddress;
            //capture the customer number
            ACustomer.CustomerNumber = Convert.ToInt64(CustomerNumber);
            //capture the customer email
            ACustomer.CustomerEmail = CustomerEmail;

            //Create a new instance of the Customer Collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //if this is a new record i.e CustomerId = -1 then add the data
            if (CustomerId == -1)
            {
                //set the thisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //Add the new record
                CustomerList.Add();
            }
            //otherwise it must be update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerId);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //update the record
                CustomerList.Update();
            }
            //navigate to the List page
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
        
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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Customer class
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerId = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = ACustomer.Find(CustomerId);
        //if found
        if (Found == true)
        {
            //display the value of the properties in the form
            lblError.Text = "";
            txtCustomerName.Text = ACustomer.CustomerFullName;
            txtCustomerDateOfBirth.Text = ACustomer.CustomerDateOfBirth.ToString();
            ddlCustomerGender.SelectedValue = ACustomer.CustomerGender.ToString();
            ddlCustomerGender.Text = ACustomer.CustomerGender.ToString();
            txtCustomerAddress.Text = ACustomer.CustomerAddress;
            txtCustomerNumber.Text = ACustomer.CustomerNumber.ToString();
            txtCustomerEmail.Text = ACustomer.CustomerEmail;
        }
        else
        {
            txtCustomerName.Text = "";
            txtCustomerDateOfBirth.Text = "";
            txtCustomerAddress.Text = "";
            txtCustomerNumber.Text = "";
            txtCustomerEmail.Text = "";
            lblError.Text = "Error: This Id doesn't exist!";
            lblError.Visible = true;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}