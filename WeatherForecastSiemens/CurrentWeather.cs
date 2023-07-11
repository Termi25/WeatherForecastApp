using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastSiemens
{
    [Serializable]
    public class CurrentWeather
    {
        private Location loc;
        private Current current;
        public CurrentWeather(Location loc, Current current)
        {
            this.loc.Name = loc.Name;
            this.loc.Region = loc.Region;
            this.loc.Country = loc.Country;
            this.loc.Lat = loc.Lat;
            this.loc.Lon = loc.Lon;
            this.loc.Tz_id = loc.Tz_id;
            this.loc.Localtime_epoch = loc.Localtime_epoch;
            this.loc.Localtime = loc.Localtime;

            this.current.Temp_c = current.Temp_c;
            this.current.Temp_f = current.Temp_f;
            this.current.Is_day = current.Is_day;
        }

        public Location Loc { get { return this.loc; } set {
                this.loc.Name = value.Name;
                this.loc.Region = value.Region;
                this.loc.Country = value.Country;
                this.loc.Lat = value.Lat;
                this.loc.Lon = value.Lon;
                this.loc.Tz_id = value.Tz_id;
                this.loc.Localtime_epoch = value.Localtime_epoch;
                this.loc.Localtime = value.Localtime;
            } }
        public Current Current{get{ return current;} set {
                this.current.Temp_c = value.Temp_c;
                this.current.Temp_f = value.Temp_f;
                this.current.Is_day = value.Is_day;
            } }
    }
}
