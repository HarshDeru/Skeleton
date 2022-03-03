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
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //get the data from session object
        AStaff = (clsStaff)Session["AStaff"];
        //displays the staff id
        Response.Write(AStaff.StaffID+"<br>");

        //displays the Staff Full Name for this entry;
        Response.Write(AStaff.Staff_FullName+"<br>");
        //displays the Staff role
        Response.Write(AStaff.Staff_Role+"<br>");
        //displays the Staff hire date
        Response.Write(AStaff.Staff_HireDate+"<br>");
        //displays the Staff salary
        Response.Write(AStaff.Staff_Salary+"<br>");
        //displays the Staff gender
        Response.Write(AStaff.Staff_Gender + "<br>");
        
    }
}