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

        //maps
        private static Dictionary<String, List<String>> states = new Dictionary<String, List<String>>();
        private static Dictionary<String, List<String>> city = new Dictionary<string, List<string>>();

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

                //List<ListItem> countryList = new List<ListItem>() { 
                //    new ListItem("India","1"),
                //};
                //ListItem abc = new ListItem("praveen", "1");
                //List<int> lst = new List<int>();
                //lst.Add(1);

                //List<string> strlist = new List<string>() { "str1","str2","str3"};
                //foreach(var x in strlist) countrylist.Items.Add(x);
                ////   countryList.Add();

                //List<String> strList = new List<string>() {"HYD","Chennai","Pune","Kerala" };
                //Dictionary<string, List<string>> countrystate = new Dictionary<string, List<string>>();
                //countrystate.Add("India", strList);

                //foreach (List<string> x in countrystate.Values) 
                //{
                //    foreach (string y in x) countrylist.Items.Add(y);

                //}


                //List<String> stateListIndia = new List<string>() {"Telangana", "Gujarat", "maharashtra" };
                //List<String> stateListUSA = new List<string>() {"Texas","New Jersey", "Arizona"};

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
    }
}