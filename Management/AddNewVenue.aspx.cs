using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Management_AddNewVenue : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //comes from the DataClasses.dbml in App_code. This is a Linq to sql class that maps
        //the tables in the database
        DataClassesDataContext dc = new DataClassesDataContext();

        //create a new venue object and set its properties
        Venue x = new Venue();
        x.Name = TextBox1.Text;
        x.Location = TextBox2.Text;

        //submit object to database
        dc.Venues.InsertOnSubmit(x);
        dc.SubmitChanges();

        //confirmation message
        Response.Write("<script>alert('List of Venues Updated');</script>");

        //reset textboxes
        TextBox1.Text = "";
        TextBox2.Text = "";
    }
}