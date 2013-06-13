using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Management_AddNewCategory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //comes from the DataClasses.dbml in App_code. This is a Linq to sql class that maps
        //the tables in the database
        DataClassesDataContext dc = new DataClassesDataContext();

        //create a new category object and set its properties
        Category c = new Category();
        c.CategoryType = TextBox1.Text;

        //submit object to database
        dc.Categories.InsertOnSubmit(c);
        dc.SubmitChanges();

        //confirmation dialogue
        Response.Write("<script>alert('List of Categories Updated');</script>");

        //reset textbox
        TextBox1.Text = "";
    }
}