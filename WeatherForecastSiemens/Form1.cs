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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WeatherForecastSiemens
{
    public partial class Form1 : Form
    {
        string[] unitM = { "Celsius", "Fahrenheit" };
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        string[] city = { "Berlin","Bucharest","Paris","Rome" };
        string date;
        public Form1()
        {
            InitializeComponent();
            date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            Timer t= new Timer();
            t.Interval = 1000;
        }

        private void t_Tick(object sender,EventArgs e)
        {
            date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            this.Form1_Load(sender,e);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Configuration.Default.ApiKey.Add("key", "5be527fd5935439abbc73455231107");
            this.cbTempUnit.DataSource = unitM;
            cbTempUnit.SelectedItem = null;
            cbTempUnit.SelectedText = "Celsius";

            this.cbOras.DataSource = city;
            cbOras.SelectedItem = null;
            cbOras.SelectedText = "Bucharest";

            var apiInstance = new APIsApi();
            InlineResponse200 resultReal;
            InlineResponse2003 resultAstro;
            try
            {
                resultReal = apiInstance.RealtimeWeather(cbOras.Text);
                Debug.WriteLine(resultReal);
                CurrentWeather nou = JsonConvert.DeserializeObject<CurrentWeather>(resultReal.ToString());
                tbAstro.Text = nou.Loc.Name;
                //resultAstro = apiInstance.Astronomy(cbOras.Text, dt);
                //tbAstro.Text = resultAstro.ToString();
            }
            catch (Exception f)
            {
                Debug.Print("Exception when calling APIsApi.RealtimeWeather: " + f.Message);
            }
        }

        private void cbTempUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            var apiInstance = new APIsApi();
            InlineResponse200 resultReal;
            InlineResponse2003 resultAstro;
            try
            {
                //resultReal = apiInstance.RealtimeWeather(cbOras.Text);
                //Debug.WriteLine(resultReal);
                resultAstro = apiInstance.Astronomy(cbOras.Text, DateTime.Parse(date));
                tbAstro.Text = resultAstro.ToString();
            }
            catch (Exception f)
            {
                Debug.Print("Exception when calling APIsApi.RealtimeWeather: " + f.Message);
            }
        }

        private void cbOras_SelectedIndexChanged(object sender, EventArgs e)
        {
            var apiInstance = new APIsApi();
            InlineResponse200 resultReal;
            InlineResponse2003 resultAstro;
            try
            {
                //resultReal = apiInstance.RealtimeWeather(cbOras.Text);
                //Debug.WriteLine(resultReal);
                resultAstro = apiInstance.Astronomy(cbOras.Text, DateTime.Parse(date));
                tbAstro.Text=resultAstro.ToString();
            }
            catch (Exception f)
            {
                Debug.Print("Exception when calling APIsApi.RealtimeWeather: " + f.Message);
            }
        }
    }
}
