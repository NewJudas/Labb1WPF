using FriendOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Wrapper
{
    public class WeatherWrapper : ModelWrapper<Weather>
    {
        public WeatherWrapper(Weather model) : base(model)
        {
        }

        public long id { get { return Model.id; } }
        public string weather_state_name { get { return Model.weather_state_name; } }
        public string applicable_date { get { return Model.applicable_date; } }
        public string max_temp { get { return Model.max_temp.ToString(); } }
        public string min_temp { get { return Model.min_temp.ToString(); } }
    }
}
