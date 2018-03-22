using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using CreateStaffMemberDemo;
using Newtonsoft.Json;

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
        Staff newStaff = new Staff();

        newStaff.First_Name = this.FirstName.Value;
        newStaff.Last_Name = this.LastName.Value;
        newStaff.Email = this.EmailAddress.Value;
        newStaff.Password = this.Password.Value;
        newStaff.Volunteer = this.VolunteerCheckbox.Checked;
        newStaff.Role = new Role { Description = this.ChooseRole.SelectedValue };

        if (!CheckStaffExists(newStaff))
        {
            // Create new member of staff (no duplicated detected)
            this.CreateNewStaffMember(newStaff);
        }
        else
        {
            // Do not create new staff member (alert user of duplicate data entry)
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Oops! Duplicate Data Detected!')", true);
        }
    }

    // Method to display possible roles
    protected List<Role> ListRoles()
    {
        List<Role> possibleRoles = new List<Role>();

        possibleRoles.Add(new Role { Description = "Head Librarian"});
        possibleRoles.Add(new Role { Description = "Chief Librarian" });
        possibleRoles.Add(new Role { Description = "Check Out Librarian" });

        return possibleRoles;
    }

    // Method to create a new staff member (write file to JSON)
    protected void CreateNewStaffMember(Staff newStaff)
    {
        string path = Server.MapPath("~/App_Data/data.json");
        string content = File.ReadAllText(path);

        List<Staff> staffMembers = JsonConvert.DeserializeObject<List<Staff>>(content);
        staffMembers.Add(newStaff);

        string serialiseStaff = JsonConvert.SerializeObject(staffMembers);

        using (StreamWriter mySR = new StreamWriter(path))
        {
            mySR.Write(serialiseStaff);
        }
    }

    // Method to check if data being input already exists
    protected bool CheckStaffExists(Staff staffMember)
    {
        bool exists = false;

        string path = Server.MapPath("~/App_Data/data.json");
        string content = File.ReadAllText(path);

        List<Staff> staffMembers = JsonConvert.DeserializeObject<List<Staff>>(content);

        for (int i = 0; i < staffMembers.Count; i++)
        {
            if (staffMember.Email == staffMembers[i].Email)
            {
                exists = true;
            }
        }

        return exists;
    }
}