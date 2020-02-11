using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration
{
    public class Location
    {
        // States
        private static List<String> indiaStates = new List<string>() { "Telangana", "Punjab" };
        private static List<String> USAStates = new List<string>() { "Texas", "New Jersey" };

        //city
        private static List<String> telanganaCity = new List<string>() { "Hyderabad", "Mahbubnagar" };
        private static List<String> punjabCity = new List<string>() { "Jalandar", "Amritsar" };
        private static List<String> TexasCity = new List<string>() { "Dallas", "Austin" };
        private static List<String> NewJerseyCity = new List<string>() { "Edison", "Clifton" };


        public static List<String> getStates(String country)
        {
            if (country == "India") return indiaStates;
            else if (country == "USA") return USAStates;
            else return null;
        }

        public static List<String> getCity(String State)
        {
            if (State == "Telangana") return telanganaCity;
            else if (State == "Punjab") return punjabCity;
            else if (State == "Texas") return TexasCity;
            else return NewJerseyCity;
        }

    }
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                


                countrylist.Items.Add("India");
                countrylist.Items.Add("USA");
                //List<String> states = Location.getStates("India");
                //foreach (String state in states) countrylist.Items.Add(state);

                statelist.Items.Insert(0, "Select State");
                citylist.Items.Insert(0, "Select City");
                countrylist.Items.Insert(0, "Select Country");

                statelist.Enabled = false;
                citylist.Enabled = false;
            }
        }


        protected void countrylist_SelectedIndexChanged(object sender, EventArgs e)
        {            
            string country = countrylist.Text.ToString();
            statelist.Enabled = true;
            citylist.Enabled = false;
            List<string> states = Location.getStates(country);
            statelist.Items.Clear();
            foreach (String state in states) statelist.Items.Add(state);

        }

        protected void statelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            string state = statelist.Text.ToString();
            citylist.Enabled = true;
            List<String> city = Location.getCity(state);
            citylist.Items.Clear();
            foreach (String ct in city) citylist.Items.Add(ct);
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            if (firstname.Text == "")
            {
                fnameerror.Text = "Enter First Name";
            }
            else fnameerror.Text = "";

            if (lastname.Text == "")
            {
                lnameerror.Text = "Enter Last Name";
            }
            else lnameerror.Text = "";

            if (dotnet.Checked == false&&java.Checked==false&&DEP.Checked==false&&salesforce.Checked==false)
            {
                streamerror.Text = "Select a Stream";
            }
            else streamerror.Text = "";

            if (calender.Text == "")
            {
                doberror.Text = "Select DOB";
            }
            else doberror.Text = "";


        }
    }
}