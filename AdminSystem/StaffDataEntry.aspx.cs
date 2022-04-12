using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{

    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {

        StaffID = Convert.ToInt32(Session["StaffID"]);

        if(IsPostBack == false)
        {
            if (StaffID != -1)
            {
                DisplayStaffs();
            }
        }
    }

    void DisplayStaffs()
    {
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ThisStaff.Find(StaffID);

        txtStaffID.Text = Staff.ThisStaff.StaffID.ToString();
        txtStaffName.Text = Staff.ThisStaff.Staff_FullName;
        txtStaffRole.Text = Staff.ThisStaff.Staff_Role;
        txtStaffHireDate.Text = Staff.ThisStaff.Staff_HireDate.ToString();
        txtStaffSalary.Text = Staff.ThisStaff.Staff_Salary.ToString();
        dblGender.SelectedValue = Staff.ThisStaff.Staff_Gender.ToString();


    }




    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of clsStaff
        clsStaff AStaff = new clsStaff();
        
        string Staff_FullName = txtStaffName.Text;
        string Staff_Role = txtStaffRole.Text;
        string Staff_HireDate = txtStaffHireDate.Text;
        string Staff_Salary = txtStaffSalary.Text;
        String Staff_Gender = dblGender.SelectedValue;


        string Error = "";



        Error = AStaff.Valid(Staff_FullName, Staff_Role, Staff_HireDate);
        if (Error == "")
        {
            AStaff.StaffID = StaffID;
            //captures the staff full name
            AStaff.Staff_FullName = Staff_FullName;
            //captures the staff full name
            AStaff.Staff_Role = Staff_Role;
            //capture the staff hire date
            AStaff.Staff_HireDate = Convert.ToDateTime(Staff_HireDate);

            AStaff.Staff_Gender = Convert.ToBoolean(Staff_Gender);

            AStaff.Staff_Salary = Convert.ToDouble(Staff_Salary);

            clsStaffCollection StaffList = new clsStaffCollection();
            if (StaffID == -1)
            {
                StaffList.ThisStaff = AStaff;
                StaffList.Add();
            }
            else
            {
                StaffList.ThisStaff.Find(StaffID);
                StaffList.ThisStaff = AStaff;

                StaffList.Update();
            }
            Response.Redirect("StaffList.aspx");
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

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}



