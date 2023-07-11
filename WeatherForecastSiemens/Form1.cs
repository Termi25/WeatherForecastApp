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
        int rep = 0;
        CurrentWeather nou;
        public Form1()
        {
            InitializeComponent();
            Configuration.Default.ApiKey.Add("key", "5be527fd5935439abbc73455231107");

            date = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            this.cbTempUnit.DataSource = unitM;
            cbTempUnit.SelectedItem = null;
            cbTempUnit.SelectedText = "Celsius";
            cbTempUnit.Text = "Celsius";
            
            this.cbOras.DataSource = city;
            cbOras.SelectedItem = null;
            cbOras.SelectedText = "Berlin";
            cbOras.Text = "Berlin";

            Timer t= new Timer();
            t.Interval = 60000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }

        private void t_Tick(object sender,EventArgs e)
        {
            date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            this.Form1_Load(sender,e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            drawChart();
            if (rep < 1)
            {
                cbTempUnit.SelectedText = "Celsius";
                cbOras.SelectedText = "Berlin";
                cbTempUnit.Text = "Celsius";
                cbOras.Text = "Berlin";
                rep++;
            }

            var apiInstance = new APIsApi();
            InlineResponse200 resultReal;
            try
            {
                resultReal = apiInstance.RealtimeWeather(cbOras.Text);
                if (cbTempUnit.Text == "Celsius")
                {
                    tbTempActual.Text = resultReal.Current.TempC.ToString() + " °C";
                }
                else
                {
                    tbTempActual.Text = resultReal.Current.TempF.ToString() + " °F";
                }
                tbHumidity.Text=resultReal.Current.Humidity.ToString();
                tbWindSpeed.Text=resultReal.Current.WindKph.ToString()+" km/h";
                tbPrecipitation.Text = resultReal.Current.PrecipMm.ToString()+" mm";
            }
            catch (Exception f)
            {
                Debug.Print("Exception when calling APIsApi.RealtimeWeather: " + f.Message);
            }
            addCurrentDay();
        }

        private void addCurrentDay()
        {
            var apiInstance = new APIsApi();
            InlineResponse2001 resultForecast;
            try
            {
                foreach (ListViewItem itm in lvCurrentDay.Items)
                {
                    itm.Remove();
                }
                foreach (ListViewItem itm in lv7Days.Items)
                {
                    itm.Remove();
                }
                resultForecast = apiInstance.ForecastWeather(cbOras.Text, 1, DateTime.Parse(date));
                //The WeatherApi.com Forecast Method does not work, even after fixing some issues with it
                //when it comes to getting the values from the json given by the request
                for (int i = 0; i < 23; i++)
                {
                    ListViewItem item = new ListViewItem(resultForecast.Location.Localtime);
                    ListViewItem item2 = new ListViewItem(resultForecast.Location.Localtime);
                    if (cbTempUnit.Text == "Celsius")
                    {
                        item.SubItems.Add(resultForecast.Current.TempC.ToString() + " °C");
                        item2.SubItems.Add(resultForecast.Current.TempC.ToString() + " °C");
                    }
                    else
                    {
                        item.SubItems.Add(resultForecast.Current.TempC.ToString()+ " °F");
                        item2.SubItems.Add(resultForecast.Current.TempC.ToString() + " °F");
                    }
                    lvCurrentDay.Items.Add(item);
                    if (i < 7)
                    {
                        lv7Days.Items.Add(item2);
                    }
                }
            }
            catch (Exception f)
            {
                Debug.Print("Exception when calling APIsApi.ForecastWeather: " + f.Message);
            }
        }

        private void drawChart()
        {
            chart1.Series["Temperatures"].Points.Clear();
            chart1.Titles.Clear();
            chart1.Visible = true;
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            var apiInstance = new APIsApi();
            InlineResponse2002 resultHistory;
            try
            {
                for(int i = 0; i < 7; i++)
                {
                    resultHistory = apiInstance.HistoryWeather(cbOras.Text, DateTime.Parse(date));
                    //The HistoryWeather Method does also not work...
                    if (i % 2 == 0)
                    {
                        chart1.Series["Temperatures"].Points.AddXY("Day "+(i+1), 30 + i);
                    }
                    else
                    {
                        chart1.Series["Temperatures"].Points.AddXY("Day " +(i+1), 30 - (i/2));
                    }
                }
                chart1.Titles.Add("Average temperatures in the last 7 days");
            }
            catch(Exception f)
            {
                Debug.Print("Exception when calling APIsApi.HistoryWeather: " + f.Message);
            }
        }

        private void cbTempUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            drawChart();
            var apiInstance = new APIsApi();
            InlineResponse200 resultReal;
            try
            {
                resultReal = apiInstance.RealtimeWeather(cbOras.Text);
                if (cbTempUnit.Text == "Celsius")
                {
                    tbTempActual.Text = resultReal.Current.TempC.ToString() + " °C";
                }
                else
                {
                    tbTempActual.Text = resultReal.Current.TempF.ToString() + " °F";
                }
                tbHumidity.Text = resultReal.Current.Humidity.ToString();
                tbWindSpeed.Text = resultReal.Current.WindKph.ToString() + " km/h";
                tbPrecipitation.Text = resultReal.Current.PrecipMm.ToString() + " mm";
            }
            catch (Exception f)
            {
                Debug.Print("Exception when calling APIsApi.RealtimeWeather: " + f.Message);
            }
            addCurrentDay();
        }

        private void cbOras_SelectedIndexChanged(object sender, EventArgs e)
        {
            drawChart();
            var apiInstance = new APIsApi();
            InlineResponse200 resultReal;
            try
            {
                resultReal = apiInstance.RealtimeWeather(cbOras.Text);
                if (cbTempUnit.Text == "Celsius")
                {
                    tbTempActual.Text = resultReal.Current.TempC.ToString() + " °C";
                }
                else
                {
                    tbTempActual.Text = resultReal.Current.TempF.ToString() + " °F";
                }
                tbHumidity.Text = resultReal.Current.Humidity.ToString();
                tbWindSpeed.Text = resultReal.Current.WindKph.ToString() + " km/h";
                tbPrecipitation.Text = resultReal.Current.PrecipMm.ToString() + " mm";
            }
            catch (Exception f)
            {
                Debug.Print("Exception when calling APIsApi.RealtimeWeather: " + f.Message);
            }
            InlineResponse2003 resultAstro;
            try
            {
                resultAstro = apiInstance.Astronomy(cbOras.Text, DateTime.Parse(date));
                tbAstro.Text="City: "+resultAstro.Location.Name+Environment.NewLine+
                    "Country: "+resultAstro.Location.Country+Environment.NewLine+
                    "Local time: "+resultAstro.Location.Localtime+Environment.NewLine+
                    "Sunrise: "+resultAstro.Astronomy.Astro.Sunrise+Environment.NewLine+
                    "Sunset: "+resultAstro.Astronomy.Astro.Sunset+Environment.NewLine+
                    "Moon phase: "+resultAstro.Astronomy.Astro.MoonPhase;

            }
            catch (Exception f)
            {
                Debug.Print("Exception when calling APIsApi.Astronomy: " + f.Message);
            }
            addCurrentDay();
        }
    }
}
