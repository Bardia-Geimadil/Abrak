using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAPI;

namespace Abrak.Model;

    public class HomeCities
    {
        public static List<string> HomeCitiesListName = new List<string>() { "Isfahan" ,  "Havana", "Cairo" , "Tokyo" , "Moscow" , "Jakarta" , "Lima"};

        public static List<WeatherData> HomeCitiesListData = new List<WeatherData>() { };

        public static bool isChanged = false;
    }

