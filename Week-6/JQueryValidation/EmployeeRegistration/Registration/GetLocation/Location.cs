using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Registration.GetLocation
{
    public class Location
    {
        // States
        private static List<String> indiaStates = new List<string>() {"Telangana","Punjab"};
        private static List<String> USAStates = new List<string>() {"Texas", "New Jersey" };

        //city
        private static List<String> telanganaCity = new List<string>() {"Hyderabad","Mahbubnagar" };
        private static List<String> punjabCity = new List<string>() {"Jalandar","Amritsar" };
        private static List<String> TexasCity = new List<string>() {"Dallas", "Austin" };
        private static List<String> NewJerseyCity = new List<string>() {"Edison", "Clifton"};

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
}