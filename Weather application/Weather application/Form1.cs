using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using Microsoft.SqlServer.Server;
using static System.Net.WebRequestMethods;

namespace Weather_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string APIKEY = "3f88f6c7fb991ab6d325c296117883ef";
        private void btnSearch_Click(object sender, EventArgs e)
        {
            getweather();
        }
        void getweather()
        {
            using (WebClient webClient = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TbCity.Text, APIKEY);
                var json = webClient.DownloadString(url);
                WeatherInfo.root Info= JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                // pictureIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                labCondition.Text = Info.weather[0].main;
                labDetails.Text= Info.weather[0].description;
                labSunset.Text = convertdatetime(Info.sys.sunset).ToShortTimeString();
                labSunrise.Text = convertdatetime(Info.sys.sunrise).ToShortTimeString();
                labWindSpeed.Text=Info.wind.speed.ToString();
                labPressure.Text=Info.main.pressure.ToString();
            }
        }

        DateTime convertdatetime (long sec)
        {
            //yr,,month,day,hr,min,sec,millisec
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime(); 
            return day;
        }
    }
}
