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
        //create an instance of clsStaff
        clsStaff AStaff = new clsStaff();

        //capture the staff details when they input
        /*AStaff.StaffID = Convert.ToInt32(txtStaffID.Text);
        AStaff.Staff_FullName = txtStaffName.Text;
        AStaff.Staff_Role = txtStaffRole.Text;
        AStaff.Staff_HireDate = Convert.ToDateTime(txtStaffHireDate.Text);
        AStaff.Staff_Salary = Convert.ToInt32(txtStaffSalary.Text);
        AStaff.Staff_Gender = Convert.ToBoolean(dblGender.Text);
       */ //store the staff in the session object

        string Staff_FullName = txtStaffName.Text;
        string Staff_Role = txtStaffRole.Text;
        string Staff_HireDate = txtStaffHireDate.Text;
        string Error = "";



        Error = AStaff.Valid(Staff_FullName, Staff_Role, Staff_HireDate);
        if (Error == "")
        {
            //captures the staff full name
            AStaff.Staff_FullName = Staff_FullName;
            //captures the staff full name
            AStaff.Staff_Role = Staff_Role;
            //capture the staff hire date
            AStaff.Staff_HireDate = Convert.ToDateTime(Staff_HireDate);
            Session["AStaff"] = AStaff;
            //redirects to staff viewer page.
            Response.Write("StaffViewer.aspx");
            Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }





    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff Staff = new clsStaff();
        Int32 StaffID;
        Boolean Found = false;
        StaffID = Convert.ToInt32(txtStaffID.Text);
        Found = Staff.Find(StaffID);

        if (Found == true)
        {
            lblError.Text = "";
            txtStaffName.Text = Staff.Staff_FullName;
            txtStaffRole.Text = Staff.Staff_Role;
            txtStaffSalary.Text = Staff.Staff_Salary.ToString();
            txtStaffHireDate.Text = Staff.Staff_HireDate.ToString();
            dblGender.SelectedValue = Staff.Staff_Gender.ToString();

        }
        else
        {
            txtStaffName.Text = "";
            txtStaffRole.Text = "";
            txtStaffSalary.Text = "";
            txtStaffHireDate.Text = "";

            lblError.Text = "Error: This ID does not exist!";
            lblError.Visible = true;
        }
    }
}



