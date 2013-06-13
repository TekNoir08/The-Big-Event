using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Make_Payment : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        populateNameFields();   
    }

    protected void populateNameFields()
    {
        TextBox1.Text = Profile.FirstName;
        TextBox2.Text = Profile.LastName;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (captchaCorrect())
        {
            //adds info in text fields to Session to allow us to get them from confirmation page
            Session["firstName"] = TextBox1.Text;
            Session["lastName"] = TextBox2.Text;
            Session["cardType"] = DropDownList2.SelectedValue;
            Session["cardNumber"] = TextBox3.Text;
            Session["cvvNumber"] = TextBox4.Text;
            Session["startMonth"] = DropDownList3.SelectedValue;
            Session["startYear"] = DropDownList4.SelectedValue;
            Session["endMonth"] = DropDownList5.SelectedValue;
            Session["endYear"] = DropDownList6.SelectedValue;
            Session["address1"] = TextBox6.Text;
            Session["address2"] = TextBox6.Text;
            Session["city"] = TextBox6.Text;
            Session["postcode"] = TextBox6.Text;

            Response.Redirect("~/User Pages/confirmation.aspx");

        }
        else
        {
            Label1.Text = "Captcha incorect, Please try again";

        }
    }
    
    // checks the captcha is correct
    protected Boolean captchaCorrect()
    {
        return TextBox5.Text == "overlooks inquiry";
    }
}