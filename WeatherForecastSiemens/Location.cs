using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastSiemens
{
    [Serializable]
    public class Location
    {
        private string name, 
            region, 
            country, 
            lat, 
            lon, 
            tz_id, 
            localtime_epoch, 
            localtime;
        public Location(string name, string region, string country, string lat, string lon, string tz_id, string localtime_epoch, string localtime)
        {
            this.name = name;
            this.region = region;
            this.country = country;
            this.lat = lat;
            this.lon = lon;
            this.tz_id = tz_id;
            this.localtime_epoch = localtime_epoch;
            this.localtime = localtime;
        }

        public Location()
        {
            this.name = "";
            this.region = "";
            this.country = "";
            this.lat = "";
            this.lon = "";
            this.tz_id = "";
            this.localtime_epoch = "";
            this.localtime = "";
        }

        public string Name { get { return name;} set { name = value; } }
        public string Region { get { return region;} 
            set
            {
                region = value;
            } }
        public string Country { get { return country;} set { country = value; } }
        public string Lat { get { return lat;}
            set
            {
                lat = value;
            } }
        public string Lon { get { return lon;} set { lon = value; } }
        public string Tz_id { get { return tz_id; } set { tz_id = value; } }
        public string Localtime_epoch { get { return localtime_epoch;}
            set
            {
                localtime_epoch = value;
            } }
        public string Localtime { get { return localtime; } set { localtime = value; } }
        public override string ToString()
        {
            return name+' '+region+' '+country+' '+lat+' '+lon+' '+tz_id+' '+localtime_epoch+' '+localtime+'\n';
        }
    }
}
