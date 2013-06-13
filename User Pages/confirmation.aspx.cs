using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_Pages_confirmation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //gets details from sesssion and prints on screen 
        nameLabel.Text = Convert.ToString(Session["firstName"] + " " +Convert.ToString(Session["lastName"]));
        addressLable.Text = Convert.ToString(Session["address1"]);
        address2Label.Text = Convert.ToString(Session["address2"]);
        cardTypeLabel.Text = Convert.ToString(Session["cardType"]);
        cardNumLabel.Text = Convert.ToString(Session["cardNumber"]);
        cvvNumLabel.Text = Convert.ToString(Session["cvvNumber"]);
        startDateLabel.Text = Convert.ToString(Session["startMonth"] + " / "+Convert.ToString(Session["startYear"]));
        expDateLabel.Text = Convert.ToString(Session["endMonth"] + " / " + Convert.ToString(Session["endYear"]));
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/User Pages/ThankYou.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/User Pages/MakePayment.aspx");
    }
}