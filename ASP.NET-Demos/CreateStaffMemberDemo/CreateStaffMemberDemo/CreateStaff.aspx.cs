using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using CreateStaffMemberDemo;

public partial class CreateStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.ChooseRole.DataSource = ListRoles();
        this.ChooseRole.DataTextField = "Description";
        this.ChooseRole.DataBind();
    }

    // Button click event to submit user data
    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        string firstName = this.FirstName.Value;
        string lastName = this.LastName.Value;
        string emailAddress = this.EmailAddress.Value;
        string password = this.Password.Value;

        
    }

    // Method to display volunteer roles
    protected List<Role> ListRoles()
    {
        List<Role> possibleRoles = new List<Role>();

        possibleRoles.Add(new Role { Description = "Head Librarian"});
        possibleRoles.Add(new Role { Description = "Chief Librarian" });
        possibleRoles.Add(new Role { Description = "Check Out Librarian" });

        return possibleRoles;
    }

    // Method to create a new staff member (write file to JSON)
    protected void CreateNewStaffMember()
    {
        // Write data to JSON file...

    }

    // Method to check if data being input already exists
    protected bool CheckStaffExists(Staff staffMember)
    {
        return true;
    }
}