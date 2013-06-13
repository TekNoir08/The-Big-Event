using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DatabaseModel;

public partial class MyProfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Checks if the user has a profile already set up. If not displays a message to ask user to do this
        if (userProfileNotSet())
        {
            Label1.Text = "Please fill in your profile information to allow you to register for tickets";
        }
        else
        {
            Label1.Visible = false;
        }

    }

    //Adds the details in the text box to the users profile
    protected void Button1_Click(object sender, EventArgs e)
    {
        Profile.FirstName = FirstNameBox.Text;
        Profile.LastName = LastNameBox.Text;
        Profile.EmailAddress = EmailBox.Text;
        Profile.Language = DropDownList4.SelectedValue;
        clearFields();
        
        Response.Write("<script>alert('Your details have been saved');</script>");
        Response.Redirect("~/MyProfile.aspx");
    }


    protected Boolean userProfileNotSet()
    {
        return Profile.FirstName == "";
    }

    //clears fields
    protected void clearFields()
    {
        FirstNameBox.Text = "";
        LastNameBox.Text = "";
        EmailBox.Text = "";
        DropDownList4.ClearSelection();
    }

}