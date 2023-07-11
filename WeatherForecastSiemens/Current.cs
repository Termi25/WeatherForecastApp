using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastSiemens
{
    [Serializable]
    public class Current: ICloneable
    {
        private string temp_c;
        private string temp_f;
        private string is_day;
        public Current (string temp_c, string temp_f,string is_day)
        {
            this.temp_f = temp_f;
            this.temp_c = temp_c;
            this.is_day = is_day;
        }
        public string Temp_c { get { return temp_c; } set { temp_c = value; } }
        public string Temp_f { get {  return temp_f; } set { temp_f = value; } }
        public string Is_day { get {  return is_day; }
            set
            {
                is_day = value;
            } }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return temp_c+' '+temp_f+' '+is_day+'\n';
        }
    }
}
