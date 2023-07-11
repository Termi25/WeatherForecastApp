using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace WeatherForecastSiemens
{
    public partial class Form1 : Form
    {
        string[] unitM = { "Celsius", "Fahrenheit" };
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cbTempUnit.DataSource = unitM;
            cbTempUnit.SelectedItem = null;
            cbTempUnit.SelectedText = "Celsius";

            Configuration.Default.ApiKey.Add("key", "5be527fd5935439abbc73455231107");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("key", "Bearer");

            var apiInstance = new APIsApi();
            var q = "Bucharest";  // string | Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name. Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to learn more.
            DateTime dt = DateTime.Parse("2023 - 07 - 11");  // DateTime? | Date on or after 1st Jan, 2015 in yyyy-MM-dd format
            int days = 7;  // int? | Number of days of weather forecast. Value ranges from 1 to 14
            int hour = 12;

            try
            {
                InlineResponse2001 result = apiInstance.ForecastWeather(q,days,dt,hour);
                Debug.WriteLine(result);
            }
            catch (Exception f)
            {
                Debug.Print("Exception when calling APIsApi.Astronomy: " + f.Message);
            }
        }
    }
}
