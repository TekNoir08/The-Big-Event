using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DatabaseModel;

public partial class User_Pages_MyEvents : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        showRegisteredEvents();
        numTicketsRegistered();
        showWon();
       // Profile.NumberOfTickets = 6; //remove this to allow the number of tickets to decrease
    }

    //show the tickets the user is registered for
    protected void showRegisteredEvents()
    {
        using (DatabaseEntities1 myEntity = new DatabaseEntities1())
        {
            var showReg = from R in myEntity.RegisteredEvents

                          orderby R.Event.EventType descending
                          where Profile.FirstName == R.FirstName && Profile.LastName == R.LastName //idealy this would be the unique user id
                          select new
                          {
                              R.Event.EventType,
                              R.Event.Date
                          };
            RegisteredGridView.DataSource = showReg;
            RegisteredGridView.DataBind();
        }

    }


    protected void numTicketsRegistered()
    {
        NumTickets.Text = Convert.ToString(Profile.NumberOfTickets);
    }


    protected void showWon()
    {
        using (DatabaseEntities1 myEntity = new DatabaseEntities1())
        {
            var showReg = from R in myEntity.RegisteredEvents

                          orderby R.Event.EventType descending
                          where R.Won == true && R.FirstName == Profile.FirstName && R.LastName == Profile.LastName // this should be unique user id
                          select new
                          {
                              R.Event.EventType,
                              R.Event.Date
                          };
            WonGridView.DataSource = showReg;
            WonGridView.DataBind();
        }

    }



    protected void WonGridView_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Accept")
        {
            acceptTicket();

        }
        if (e.CommandName == "Reject")
        {
            rejectTicket(WonGridView.Rows[Convert.ToInt16(e.CommandArgument)].Cells[0].Text); //horrible, sorry it's pretty late
        }
    }


    //removes the ticket from the users profile
    protected void rejectTicket(String row)
    {
        if (Profile.NumberOfTickets <7)
        {
            Profile.NumberOfTickets++;
            DataClassesDataContext dc = new DataClassesDataContext();

            var matchedUser = from R in dc.RegisteredEvents
                              where R.EventId == getEventId(row) 
                              select R;

            

            foreach (var record in matchedUser)
            {
                dc.RegisteredEvents.DeleteOnSubmit(record);                
            }
                dc.SubmitChanges();             
                showWon();
                showRegisteredEvents();
        }

    }

    protected void acceptTicket()
    {

        Response.Redirect("~/User Pages/MakePayment.aspx"); 

    }

    //returns the selected event Id from the event database when given the event name
    protected int getEventId(String eventName)
    {
        using (DatabaseEntities1 myEntity = new DatabaseEntities1())
        {
            var id = (from eventTable in myEntity.Events

                      where eventTable.EventType == eventName
                      select eventTable.Id).SingleOrDefault();
            return id;
        }
    }


}


