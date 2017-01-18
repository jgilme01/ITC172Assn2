using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string[,] dates = new string[6,3];




    protected void Page_Load(object sender, EventArgs e)
    {

        dates[0, 0] = "12/25/2017";
        dates[0, 1] = "Christmas";
        dates[0, 2] = "Internet Test Run in 1990";
        dates[1, 0] = "1/16/2017";
        dates[1, 1] = "MLK";
        dates[2, 0] = "1/1/2017";
        dates[2, 1] = "New Year";
        dates[2, 2] = "Sunday Bloody Sunday";
        dates[3, 0] = "2/14/2017";
        dates[3, 1] = "Valentine's";
        dates[4, 0] = "10/31/2017";
        dates[4, 1] = "Halloween";
        dates[5, 0] = "5/29/2017";
        dates[5, 1] = "Memorial Day";

        if (IsPostBack)
        {
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";

        }
    }

    protected void WriteDate(int x)
    {
        Label2.Text = dates[x, 1];
                if(!String.IsNullOrEmpty(dates[x,2]))
                {
                    Label3.Text = dates[x, 2];
                }
    }

    protected void Calendar_SelectionChanged(object sender, EventArgs e)
    {
       
        Label1.Text = Calendar.SelectedDate.ToShortDateString();
        for (int i=0; i< dates.GetLength(0);i++)
        {
            if(Calendar.SelectedDate.ToShortDateString()==dates[i,0])
            {
                WriteDate(i);
               
            }
        }
       
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        for (int x = 0; x < dates.GetLength(0); x++)
        {
            for (int y = 0; y < dates.GetLength(1); y++)
            {
                if (TextBox1.Text.Equals(dates[x,y], StringComparison.OrdinalIgnoreCase))
                {
                    TextBox1.Text = "";
                    Label1.Text = dates[x, 0];
                    WriteDate(x);
                }
            }
        }
    }
}