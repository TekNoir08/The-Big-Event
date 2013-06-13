using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Management_PickWinners : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        getWinners();
    }

    protected void getWinners()
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        DataClassesDataContext dc = new DataClassesDataContext();

        var ticketWinner = from winner in dc.RegisteredEvents
                           where winner.EventId == Convert.ToInt16( DropDownList1.SelectedValue) //&& winner.Won == false
                           select winner ;

      
        Random random = new Random();
        
        // number of winners to pick. In full version this will be the number of tickets for event
        int numberOfTix = 3;

        for(int i=0; i<numberOfTix; i ++)
        {
            ticketWinner.ToList().ElementAt(random.Next(0, ticketWinner.Count())).Won = true;
                
        }


        dc.SubmitChanges();
        GridView1.DataSource = ticketWinner;
        GridView1.DataBind();
        
    }
}