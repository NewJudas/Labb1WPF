using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrganizer.Model
{
    public class Weather
    {
            public long id { get; set; }
            public string weather_state_name { get; set; }
            public string applicable_date { get; set; }
            public double? min_temp { get; set; }
            public double? max_temp { get; set; }
        
    }
}
