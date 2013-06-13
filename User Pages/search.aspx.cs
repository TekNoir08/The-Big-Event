using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatabaseModel;


//apologies for all the duplication


public partial class User_Pages_search : System.Web.UI.Page
{
    protected DateTime today = DateTime.Now;
    protected int lowerPriceRange, upperPriceRange;
    protected DateTime upperDateRange;

    protected void Page_Load(object sender, EventArgs e)
    {
        showAllResults();
    }


    //Populates the gridview with everyting in the database currently
    protected void showAllResults()
    {   
        using (DatabaseEntities1 myEntity = new DatabaseEntities1())
        {
            var showAll = from eventTable in myEntity.Events
                          
                          orderby eventTable.Category.CategoryType descending
                          where eventTable.NumOfTickets !=0 // wont show event if no tickets are left
                          select new
                          {
                              eventTable.Id,
                              eventTable.EventType,
                              eventTable.Category.CategoryType,
                              eventTable.Venue.Name,
                              eventTable.Price,
                              eventTable.Date,
                              eventTable.Time,
                              eventTable.Description
                          };
            GridView1.DataSource = showAll;
            GridView1.DataBind();
        }

    }


    //filter button
    protected void Button1_Click(object sender, EventArgs e)
    {
        //gets the dropdown values
        getDateDropdowRange();
        getPriceDropdownRange();

        // make sure user has selected all 3 dropdowns
        if (CategoryDropdown.SelectedIndex > 0 && PriceDropdown.SelectedIndex > 0 && DateDropdown.SelectedIndex > 0)
        {
            // database search query
            using (DatabaseEntities1 myEntity = new DatabaseEntities1()) 
            {
                //get details
                var filter = from eventTable in myEntity.Events
                             orderby eventTable.Category.CategoryType descending
                             
                             //filter
                             where eventTable.Category.CategoryType == CategoryDropdown.SelectedValue
                                   && eventTable.Price >= lowerPriceRange && eventTable.Price <= upperPriceRange
                                   && eventTable.Date >= today && eventTable.Date <= upperDateRange && eventTable.NumOfTickets !=0

                            //custom output
                             select new
                             {
                                 eventTable.EventType,
                                 eventTable.Category.CategoryType,
                                 eventTable.Venue.Name,
                                 eventTable.Price,
                                 eventTable.Date,
                                 eventTable.Time,
                                 eventTable.Description
                             };

                //add data to the gridview
                GridView1.DataSource = filter;
                GridView1.DataBind();
            }

        }

    }


    //converts the index of the dropdown to variables to be used in the search query
    protected void getPriceDropdownRange()
    {
        int n = Convert.ToInt16(PriceDropdown.SelectedIndex);
        switch (n)
        {
            case 1:
                lowerPriceRange = 0; upperPriceRange = 10; 
                break;

            case 2:
                lowerPriceRange = 11; upperPriceRange = 25;
                break;

            case 3:
                lowerPriceRange = 26; upperPriceRange = 50;
                break;
                
            case 4:
                lowerPriceRange = 51; upperPriceRange = 9999;
                break;
        }
    }


    protected void getDateDropdowRange()
    {
        int n = Convert.ToInt16(DateDropdown.SelectedIndex);

        switch (n)
        {
            case 1:
                upperDateRange = today.AddDays(7);
                break;
            case 2:
                upperDateRange = today.AddDays(14);
                break;
            case 3:
                upperDateRange = today.AddMonths(1);
                break;
            case 4:
                upperDateRange = today.AddMonths(3);
                break;
        }

    }


    //resets the dropdown boxes to their origanal positions
    protected void clearAllDropDowns()
    {
        CategoryDropdown.ClearSelection();
        PriceDropdown.ClearSelection();
        DateDropdown.ClearSelection();

    }


    //Button to reset dropdown fields
    protected void Button2_Click(object sender, EventArgs e)
    {
        clearAllDropDowns();    
    }


    // searches the database using the onscreen calendar
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        using (DatabaseEntities1 myEntity = new DatabaseEntities1())
        {
            var showAll = from eventTable in myEntity.Events

                          orderby eventTable.Category.CategoryType descending
                          where eventTable.Date == Calendar1.SelectedDate && eventTable.NumOfTickets != 0
                          select new
                          {
                              eventTable.EventType,
                              eventTable.Category.CategoryType,
                              eventTable.Venue.Name,
                              eventTable.Price,
                              eventTable.Date,
                              eventTable.Time,
                              eventTable.Description
                          };

            GridView1.DataSource = showAll;
            GridView1.DataBind();
        }

    }


    //get selected event and user info and add to database
    //if the user is not logged in then they will be redirected to the login page
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (userCanRegister())
        {
            if (HttpContext.Current.User.Identity.IsAuthenticated == true) //if the user is logged in
            {
                Int16 num = Convert.ToInt16(e.CommandArgument); //get row number
                DataClassesDataContext dc = new DataClassesDataContext(); //get reference to databases
                RegisteredEvent re = new RegisteredEvent();

                re.EventId = getEventId(GridView1.Rows[num].Cells[0].Text); //gets the text of the gridview cell selected
                re.FirstName = Profile.FirstName;
                re.LastName = Profile.LastName;
                re.EmailAddress = Profile.EmailAddress;
                re.Won = false;

                dc.RegisteredEvents.InsertOnSubmit(re);
                dc.SubmitChanges();
                Profile.NumberOfTickets--;
                Response.Write("<script>alert('You have now been registered');</script>");
            }
            else
            {
                Response.Redirect("~/Login.aspx"); //else send to login page
            }

        }

        else
        {
            Response.Write("<script>alert('You have registered for the maximum number of events');</script>");
        }
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

    //checks if the user can register for a ticket
    protected Boolean userCanRegister()
    {
        return (Profile.NumberOfTickets > 0);
    }


}