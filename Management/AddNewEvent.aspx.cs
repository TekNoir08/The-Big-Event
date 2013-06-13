using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Management_AddNewEvent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataClassesDataContext dc = new DataClassesDataContext();
        
        //new event object
        Event ev = new Event();
        
        //set the event properties from the page controls
        ev.CategoryId = Convert.ToInt16(DropDownList1.SelectedValue);
        ev.EventType = EventNameBox.Text;
        ev.VenueId = Convert.ToInt16(DropDownList2.SelectedValue);
        ev.Price = Convert.ToDecimal(PriceTextBox.Text);
        ev.Time = new TimeSpan(Convert.ToInt16(DropDownList3.SelectedValue), Convert.ToInt16(DropDownList4.SelectedValue), 0);
        ev.NumOfTickets = Convert.ToInt16(TicketsBox.Text);
        ev.Date = Calendar1.SelectedDate;
        ev.Description = DescriptionBox.Text;
       
        //submit details to database
        dc.Events.InsertOnSubmit(ev);
        dc.SubmitChanges();

        //confirmation dialogue
        Response.Write("<script>alert('New Event Added');</script>");

        resetPageControls();
    }

    protected void resetPageControls()
    {
        DropDownList1.ClearSelection();
        DropDownList2.ClearSelection();
        DropDownList3.ClearSelection();
        DropDownList4.ClearSelection();
        EventNameBox.Text = "";
        PriceTextBox.Text = "";
        DescriptionBox.Text = "";
    }
}